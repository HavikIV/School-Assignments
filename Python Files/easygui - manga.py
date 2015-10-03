import easygui
manga = easygui.choicebox("What is your favorite manga?",
                          choices = ['One Piece', 'Naruto', 'Code:Breaker'])
if manga == 'One Piece':
    easygui.msgbox ("You picked " + manga + ". Awesome, mine too!")
else:
    easygui.msgbox ("You picked " + manga)
Help
