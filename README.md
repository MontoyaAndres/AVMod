[![Autor](https://img.shields.io/badge/Autor-Andr%C3%A9s%20Montoya-blue.svg)]()
[![Lenguaje](https://img.shields.io/badge/C%23-2017-yellow.svg)]()
[![Licencia](https://img.shields.io/badge/Licencia-GPL--3.0-green.svg)]()
[![version](https://img.shields.io/badge/Version-2.0-red.svg)]()
# AVMod2-OpenSource-Code

[![Capture.png](https://s30.postimg.org/rheiywz5d/Capture.png)](https://postimg.org/image/clfzrbnql/)

La intención de este proyecto es dar a conocer lo importante y necesario que es cuidarse en internet. El creador no se hará responsable de cualquier uso mal intencionado o en contra de la ley.

# ¿Qué es?

El fin de avmod es lograr dar a entender que los AntiVirus no son la manera más segura de estar protegido. Con unas 8 líneas de código o menos, pueden ser espiados con facilidad. Al iniciar el programa se tendrá que aceptar los términos y condiciones que este ofrece, después se ingresa una IP local o publica y un puerto. Se selecciona el sistema a atacar y este generara el Backdoor deseado.

# Descarga

Descarga aquí AVMod2 [![AVMod2 | Backdoors completamente indetectables )](http://icons.iconarchive.com/icons/webalys/kameleon.pics/16/Download-Computer-icon.png)](https://github.com/Spyrock/AVMod2/blob/master/AVMod2/bin/Debug/AVMod2-Project.zip "AVMod2 | Backdoors completamente indetectables.") .

# Dependencias Windows

- Golang
- .NET Framework 4.5.2
- Netcat

# Instalación Dependencias Windows

Si no inicia, windows instalara .Net. Al iniciar el programa este detectara si Netcat o Golang estan instalados, si no es así, los exigirá.

- Golang: https://golang.org/dl/

- Netcat: https://eternallybored.org/misc/netcat/

# Dependencias Linux

- Golang
- Mono C#

# Instalación Dependencias Linux

No se recomienda iniciar AVMod con Wine. Al iniciar el programa este exigira la instalación de Golang.

Instalación Golang Linux:

    wget https://golang.org/doc/install?download=go1.7.5.linux-amd64.tar.gz
    tar -xf go*.tar.gz
    mv go /opt/
    mkdir /opt/gopkg 
    export GOPATH="/opt/gopkg" 
    export GOROOT="/opt/go"
    echo export GOPATH=/opt/gopkg >> ~/.bashrc 
    echo export GOROOT=/opt/go >> ~/.bashrc 
    echo export PATH=$PATH:$GOROOT/bin:$GOPATH/bin >> ~/.bashrc
    export PATH=$PATH:$GOPATH/bin:$GOROOT/bin

Instalación Mono Linux:

    sudo apt-key adv --keyserver hkp://keyserver.ubuntu.com:80 --recv-keys 3FA7E0328081BFF6A14DA29AA6A19B38D3D831EF

echo "deb http://download.mono-project.com/repo/debian wheezy main" | sudo tee /etc/apt/sources.list.d/mono-xamarin.list
    sudo apt-get update
    sudo apt-get mono-complete

# Testeado en 

<table>
    <tr>
        <th>Sistema operativo</th>
        <th> Rendimiento </th>
    </tr>
    <tr>
        <td>Windows 10</td>
        <td> Excelente </td>
    </tr>
    <tr>
        <td>Windows 8 / 8.1</td>
        <td> Excelente</td>
    </tr>
    <tr>
        <td>Windows 7</td>
        <td> Excelente/Ins .NET </td>
    </tr>
    <tr>
        <td>Ubuntu</td>
        <td> Excelente </td>
    </tr>
    <tr>
        <td>Debian</td>
        <td> Excelente </td>
    </tr>
</table>

# Demostración Windows

[![AVMod2 | Crea un backdoor completamente indetectable en menos de 1 minuto. )](https://s29.postimg.org/e2brrl4iv/Capture.png)](https://www.youtube.com/watch?v=r2AZSEqbFpQ&feature=youtu.be "AVMod2 | Crea un backdoor completamente indetectable en menos de 1 minuto.")

# Demostración Linux

[![AVMod2 | Crea un backdoor 100% intedectable en Linux . )](http://i68.tinypic.com/t0rb4w.png)](https://www.youtube.com/watch?v=fzFZkGGnKDI&feature=youtu.be"AVMod2 | Crea un backdoor 100% intedectable en Linux.")

# ¿Cómo usar AVMod2 + Metasploit-Framework?

[![How to get Meterpreter Sessions using AVMod2  . )](http://oi68.tinypic.com/2hdu2l0.jpg)](https://www.youtube.com/watch?v=uifH-YD0jfo&feature=youtu.be"How to get Meterpreter Sessions using AVMod2 .")

# ¿Cómo fue creado?

Todo el código fuente se ofrece desde este repositorio.

# Contacto

- Twitter: @AndresMontoyaIN
- Google+: https://plus.google.com/u/0/+SpyRockLinux
- Correo: andresmontoyafcb@gmail.com
