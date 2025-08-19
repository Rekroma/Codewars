def minimum_steps(numbers, value):
    total, count = 0, -1
    for count, num in enumerate(sorted(numbers)):
        total += num
        if total >= value:
            break
    return count