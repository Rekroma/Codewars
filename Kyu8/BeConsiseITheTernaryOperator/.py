def describe_age(a):
    return"You're a(n) "+("kid"if a<=12else"teenager"if a<=17else"adult"if a<=64else"elderly")