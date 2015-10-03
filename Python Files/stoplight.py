#!/usr/bin/env python
# stoplight.py
# Manjinder Singh
# demo if with stoplight
#

# 1) modify the code to use red or RED or Red (the same for Yellow and GREEN)
# 2) modify the code to use nine different colors ... 

endprog="start"

while endprog != "exit":
    
    lightcolor= raw_input(" Enter either red, yellow, green, white, purple, orange, auburn, amazon, or almond -> ")
    if lightcolor == "red" or lightcolor == "RED" or lightcolor == "Red":
        print "Please, Stop."
    elif lightcolor == "yellow" or lightcolor == "YELLOW" or lightcolor == "Yellow":
        print "Speed up!"
    elif lightcolor == "green" or lightcolor == "GREEN" or lightcolor == "Green":
        print "Please continue "
    elif lightcolor == "White" or lightcolor == "white" or lightcolor == "WHITE":
        print "Are you a dog?"
    elif lightcolor == "purple" or lightcolor == "Purple" or lightcolor == "PURPLE":
        print "Are you colorblind or something?"
    elif lightcolor == "orange" or lightcolor == "Orange" or lightcolor == "ORANGE":
        print "Did the yellow and red lights merge together?"
    elif lightcolor == "auburn" or lightcolor == "Auburn" or lightcolor == "AUBURN":
        print "If by auburn you mean red then please stop."
    elif lightcolor == "almond" or lightcolor == "Almond" or lightcolor == "ALMOND":
        print "Almond you say? Weirdo."
    elif lightcolor == "amazon" or lightcolor == "Amazon" or lightcolor == "AMAZON":
        print "If by amazon you mean green then please continue, learn your colors next time."
    else:
        print "Say, what? "
    endprog=raw_input("Type exit to quit, any key to continue ... ")
