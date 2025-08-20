def evens_and_odds(n):
    return str(bin(n))[2:] if n % 2 == 0 else str(hex(n))[2:]