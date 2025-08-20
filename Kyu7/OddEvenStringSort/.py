def sort_my_string(s):
    s1 = ''
    s2 = ''   
    for i in range(len(s)):
        if(i % 2 == 0):
            s1 += s[i]
        else:
            s2 += s[i]
    return s1 + ' ' + s2