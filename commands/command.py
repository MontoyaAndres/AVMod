import click


@click.group()
@click.option('-i', '--lhost', type=str, prompt=True, help='Ip to use with metasploit')
@click.option('-p', '--lport', type=str, prompt=True, help='Port to use with metasploit')
def system(lhost, lport):
    click.echo(lhost, lport)


@system.command()
def windows():
    click.echo('windows')


all = system
