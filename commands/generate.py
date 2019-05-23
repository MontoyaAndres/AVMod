import click
import sys

from utils.validation import ip_validation, port_validation


@click.group()
@click.option('--lhost', help='I.P to use with metasploit.', callback=ip_validation)
@click.option('--lport', help='Port to use with metasploit.', callback=port_validation)
@click.pass_context
def generate(ctx, lhost, lport):
    if lhost and lport:
        ctx.obj['ip'] = lhost
        ctx.obj['port'] = lport
    else:
        click.secho("The I.P or Port are not correct.",
                    bg='red', fg='white', bold=True)
        sys.exit()


@generate.command()
@click.option('--type', default='powershell', help='Attack type (powershell/clickjacking/ui).')
@click.pass_context
def windows(ctx, type):
    if type == 'powershell':
        click.echo('powershell attack')
    elif type == 'clickjacking':
        click.echo('clickjacking attack')
    elif type == 'ui':
        click.echo('ui attack')
    else:
        click.secho("Wrong type. You need to choose among (powershell/clickjacking/ui).",
                    bg='red', fg='white', bold=True)
        sys.exit()


@generate.command()
@click.option('--type', default='bash', help='Attack type (bash/clickjacking/ui).')
@click.pass_context
def unix(ctx, type):
    if type == 'bash':
        click.echo('bash attack')
    elif type == 'clickjacking':
        click.echo('clickjacking attack')
    elif type == 'ui':
        click.echo('ui attack')
    else:
        click.secho("Wrong type. You need to choose among (bash/clickjacking/ui).",
                    bg='red', fg='white', bold=True)
        sys.exit()


all = generate
