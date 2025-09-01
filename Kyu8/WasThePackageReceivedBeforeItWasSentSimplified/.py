def was_package_received_yesterday(tz_from, tz_to, start, duration):
    return start + duration - (tz_from - tz_to) < 0
        