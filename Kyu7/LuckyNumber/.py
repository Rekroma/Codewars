def is_lucky(n):
    s = 0
    while n:
        s += n % 10
        n //= 10
    return s == 0 or s % 9 == 0