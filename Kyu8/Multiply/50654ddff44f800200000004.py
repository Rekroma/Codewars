def multiply(a, b):
    return a * b

def test_basic_cases():
    assert multiply(2, 1) == 2
    assert multiply(5, 0) == 0
    assert multiply(0, 5) == 0
    assert multiply(0, 0) == 0
