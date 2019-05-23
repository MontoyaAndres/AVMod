import click


@click.command()
def about():
    click.secho("""
Thank you so much for being using AVMod :D.

Do you have any question about this tool or do you want to help growing up this?

You can contact me here:

Twitter: @AndresMontoyaIN
Email: andresmontoyafcb@gmail.com

Or visit the repository! https://github.com/MontoyaAndres/AVMod
""", fg='white')
