import click

from commands import command as avmod_commands


@click.group()
@click.pass_context
def cli(ctx):
    ctx.obj = {}


cli.add_command(avmod_commands.all)
