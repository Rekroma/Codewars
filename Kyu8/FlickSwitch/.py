def flick_switch(lst):
    state = True
    boolst = []
    for i in lst:
        if i == 'flick':
            state = state == False
        boolst.append(state)        
    return boolst