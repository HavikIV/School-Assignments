import random
from operator import itemgetter
from collections import Counter
import heapq, pickle
def lotto(num1, num2):
    number1 = number2 = number3 = number4 = number5 = 0
    while number1 == 0:
        number1 = random.randint(1,num1)
        #number2 = 0
        while number2 == number1 or number2 == 0:
            number2 = random.randint(1,num1)
            #number3 = 0
        while number3 == number1 or number3 == 0 or number3 == number2:    
            number3 = random.randint(1,num1)
            #number4 = 0
        while number4 == number1 or number4 == 0 or number4 == number2 or number4 == number3:
            number4 = random.randint(1,num1)
            #number5 = 0
        while number5 == number1 or number5 == 0 or number5 == number2 or number5 == number3 or number5 == number4:
            number5 = random.randint(1,num1)
        mega = random.randint(1,num2)
        num_list = [number1, number2, number3, number4, number5]
        num_list.sort()
        number11 = num_list[0]
        number21 = num_list[1]
        number31 = num_list[2]
        number41 = num_list[3]
        number51 = num_list[4]
    return number11, number21, number31, number41, number51, mega

which = raw_input('which lottery titcket? ')
quick_pick = raw_input("How many tickets? 1, 5, 10, lucky? ")

if quick_pick == "1":
    tickets = 1
elif quick_pick == "5":
    tickets = 5
elif quick_pick == "10":
    tickets = 10
elif quick_pick == "lucky":
    if which == "super":
        tickets = 41416353
    elif which == "mega":
        tickets = 175711536
    elif which == "power":
        tickets = 175223510

if which == "super":
    num1 = 47
    num2 = 27
elif which == "mega":
    num1 = 56
    num2 = 46
elif which == "power":
    num1 = 59
    num2 = 35

def kill(tickets, num1, num2):
    many = 0
    global tit, megatit, quick_pick, which
    tit = list()
    megatit = list()
    while many < int(tickets):
        titties = lotto(num1, num2)
        #print "titties ", titties
        megatitties = titties[-1:]
        tit.extend(titties)
        megatit.extend(megatitties)
        many += 1
        if not quick_pick == "lucky":
            if which == "power":
                sixth_number = "Power"
            else:
                sixth_number = "Mega"
            ready_to_TIT = tit[:5]
            print "numbers" , ready_to_TIT, sixth_number, str(megatit)
            tit = list()
            megatit = list()
    if quick_pick == "lucky":
        tit.sort()
        megatit.sort()
    #print tit
    #print megatit
    return tit, megatit
    
def counting(kyle):
    global tit, megatit, list_of_combos
    lucky = kyle
    if lucky == "most":
        number_to_count = (x for x in tit)
        c = Counter(number_to_count)
        d =  c.most_common(5)
        d.sort()

        mega_to_count = (x for x in megatit)
        CC = Counter(mega_to_count)
        DD = CC.most_common(1)
        return d, DD
    elif lucky == "combo":
        combo_to_count = (tuple(x) for x in list_of_combos)
        combo_count = Counter(combo_to_count)
        print 'most', combo_count.most_common(1), 'least', list(combo_count.most_common())[-1]
        dcombo = list(combo_count)[-1:]
        return dcombo
    else:
        number_to_count = (x for x in tit)
        c = Counter(number_to_count)
        reverse = heapq.nsmallest(5, c.items(), key=itemgetter(1))
        d = reverse
        d.sort()

        mega_to_count = (x for x in megatit)
        CC = Counter(mega_to_count)
        Reverse = heapq.nsmallest(1, CC.items(), key=itemgetter(1))
        DD = Reverse
        return d, DD

def combos(num1, num2):
    global list_of_combos
    list_of_combos = list()
    combo = list()
    many = 0
    while many < 5000:
        combo = lotto(num1, num2)
        combo1 = list(combo)
        list_of_combos.append(combo1)
        many += 1
    print list_of_combos
    fool = counting("combo")
    return fool
    
if not quick_pick == "lucky" and not quick_pick == "combo":
    joke = kill(tickets, num1, num2)
elif quick_pick == "combo":
    print "Combos are..."
    joke = combos(num1, num2)
    print "done ", joke
else:
    joke = kill(tickets, num1, num2)
    kyle = raw_input("most or least? ")
    print counting(kyle)
