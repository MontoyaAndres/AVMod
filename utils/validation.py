import re


def _validation(regex, value):
    if value is not None:
        if re.match(regex, value):
            return value
        return False
    return False


def ip_validation(ctx, param, value):
    return _validation('^([0-9]{1,3}\\.){3}[0-9]{1,3}$', value)


def port_validation(ctx, param, value):
    if value is not None:
        if int(value) >= 1 and int(value) <= 65536:
            return value
        return False
    return False
