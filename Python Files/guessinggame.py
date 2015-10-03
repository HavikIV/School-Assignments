#! usr/bin/env python
# guessinggame.py
# manjinder singh

import random
import easygui
game = 'Yes'
while game != 'No':
    secret = random.randint(1, 99)
    guess = 0
    tries = 0

    easygui.msgbox("AHOY! I'm the Dread Pirate Roberts, and I have a secret! Its is a number from 1 to 99. I'll give you 6 tries.", title = "Guessing Game")

    while guess != secret and tries < 6:
        guess = easygui.integerbox('Whats yer guess? ')
        if guess < secret:
            easygui.msgbox('Too low, ye scurvy dog!')
        elif guess > secret:
            easygui.msgbox('Too high, landlubber!')
        tries = tries + 1

    if guess == secret:
        easygui.msgbox('Avast! Ye got it! Found my secret, ye did!')
    else:
        easygui.msgbox('No more guesses! Better luck next time, matey!')
        easygui.msgbox('The secret number was ' + str(secret))
        
    game = easygui.buttonbox('Would like to continue playing?',
                            choices = ['Yes', 'No'])
