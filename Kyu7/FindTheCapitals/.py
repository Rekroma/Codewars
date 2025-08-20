def capitals(word):
    x = []
    for i in range(len(word)):
        if(word[i].isupper()):
            x.append(i)
    return x