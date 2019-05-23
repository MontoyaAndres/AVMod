from setuptools import setup

setup(
    name="avmod",
    version="0.0.1",
    author="Andrés Mauricio Montoya Sánchez",
    author_email="andresmontoyafcb@gmail.com",
    license="MIT",
    keywords="avmod powershell bash shellcode",
    url="https://github.com/MontoyaAndres/AVMod",
    py_modules=['avmod'],
    install_requires=['Click'],
    entry_points="""
    [console_scripts]
    avmod=avmod:cli
  """
)
