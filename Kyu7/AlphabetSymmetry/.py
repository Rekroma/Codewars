from string import ascii_lowercase

def solve(strings : list[str]) -> list[int]:
    res = []
    sum = 0
    for i in range(len(strings)):
        for j in range(len(strings[i])):
            if(strings[i][j].lower() == ascii_lowercase[j % 26]):
                sum += 1
        res.append(sum)
        sum = 0
    return res
        
        