def calc(x):
    res = ''.join(str(ord(c)) for c in x)
    total1 = sum(int(digit) for digit in res)
    total2_str = res.replace('7', '1')
    total2 = sum(int(digit) for digit in total2_str)
    return total1 - total2