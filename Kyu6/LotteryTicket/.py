def bingo(ticket,win):
    mini_wins = 0;
    for i in range(len(ticket)):
        for j in range(len(ticket[i][0])):
            if ord(ticket[i][0][j]) == ticket[i][1]:
                mini_wins += 1
                break
    return 'Winner!' if mini_wins >= win else 'Loser!'

