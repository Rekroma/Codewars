def sum_triangular_numbers(n):
    return sum((k * (k + 1)) // 2 for k in range(1, n + 1))