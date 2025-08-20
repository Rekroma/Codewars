def neutralise(s1, s2):
    s = ""
    for i in range(len(s1)):
        if(s1[i] == s2[i]): s += s1[i]
        else: s += "0"
    return s