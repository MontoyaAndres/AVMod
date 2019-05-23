import click

from commands import generate as avmod_commands
from commands import about


@click.group()
@click.pass_context
def cli(ctx):
    ctx.obj = {}
    ctx.obj['ip'] = ''
    ctx.obj['port'] = ''


cli.add_command(avmod_commands.all)
cli.add_command(about.about)
