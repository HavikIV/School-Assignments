import random
from operator import itemgetter
from collections import Counter
import heapq, pickle
from PythonCard import model

class MainWindow(model.Background):

    BallDictionary = {
        1:'Lottery_Ball.png',
        2:'Lottery_Ball2.png',
        3:'Lottery_Ball3.png',
        4:'Lottery_Ball4.png',
        5:'Lottery_Ball5.png',
        6:'Lottery_Ball6.png',
        7:'Lottery_Ball7.png',
        8:'Lottery_Ball8.png',
        9:'Lottery_Ball9.png',
        10:'Lottery_Ball10.png',
        11:'Lottery_Ball11.png',
        12:'Lottery_Ball12.png',
        13:'Lottery_Ball13.png',
        14:'Lottery_Ball14.png',
        15:'Lottery_Ball15.png',
        16:'Lottery_Ball16.png',
        17:'Lottery_Ball17.png',
        18:'Lottery_Ball18.png',
        19:'Lottery_Ball19.png',
        20:'Lottery_Ball20.png',
        21:'Lottery_Ball21.png',
        22:'Lottery_Ball22.png',
        23:'Lottery_Ball23.png',
        24:'Lottery_Ball24.png',
        25:'Lottery_Ball25.png',
        26:'Lottery_Ball26.png',
        27:'Lottery_Ball27.png',
        28:'Lottery_Ball28.png',
        29:'Lottery_Ball29.png',
        30:'Lottery_Ball30.png',
        31:'Lottery_Ball31.png',
        32:'Lottery_Ball32.png',
        33:'Lottery_Ball33.png',
        34:'Lottery_Ball34.png',
        35:'Lottery_Ball35.png',
        36:'Lottery_Ball36.png',
        37:'Lottery_Ball37.png',
        38:'Lottery_Ball38.png',
        39:'Lottery_Ball39.png',
        40:'Lottery_Ball40.png',
        41:'Lottery_Ball41.png',
        42:'Lottery_Ball42.png',
        43:'Lottery_Ball43.png',
        44:'Lottery_Ball44.png',
        45:'Lottery_Ball45.png',
        46:'Lottery_Ball46.png',
        47:'Lottery_Ball47.png',
        48:'Lottery_Ball48.png',
        49:'Lottery_Ball49.png',
        50:'Lottery_Ball50.png',
        51:'Lottery_Ball51.png',
        52:'Lottery_Ball52.png',
        53:'Lottery_Ball53.png',
        54:'Lottery_Ball54.png',
        55:'Lottery_Ball55.png',
        56:'Lottery_Ball56.png',
        57:'Lottery_Ball57.png',
        58:'Lottery_Ball58.png',
        59:'Lottery_Ball59.png',
	60:'Lottery_Ball60.png',
        61:'Lottery_Ball61.png',
        62:'Lottery_Ball62.png',
        63:'Lottery_Ball63.png',
        64:'Lottery_Ball64.png',
        65:'Lottery_Ball65.png',
        66:'Lottery_Ball66.png',
        67:'Lottery_Ball67.png',
        68:'Lottery_Ball68.png',
        69:'Lottery_Ball69.png',
	70:'Lottery_Ball70.png',
        71:'Lottery_Ball71.png',
        72:'Lottery_Ball72.png',
        73:'Lottery_Ball73.png',
        74:'Lottery_Ball74.png',
        75:'Lottery_Ball75.png'
        }

    def on_SuperLottobutton_mouseClick(self, event): ##this function tells the computer what to do when the superlotto button is clicked
        global maxNumber1, maxNumber2, which
        which = "super"
        maxNumber1 = 47
        maxNumber2 = 27
        self.changeButtons()

    def on_MegaMillionsbutton_mouseClick(self, event): ##this function tells the computer what to do when the megamillions button is clicked
        global maxNumber1, maxNumber2, which
        which = "mega"
        maxNumber1 = 75
        maxNumber2 = 15
        self.changeButtons()

    def on_PowerBallbutton_mouseClick(self, event): ##this function tells the computer what to do when the powerball button is clicked
        global maxNumber1, maxNumber2, which
        which = "power"
        maxNumber1 = 59
        maxNumber2 = 35
        self.changeButtons()

    def on_tick1_mouseClick(self, event): ##this function sets the number of tickets to 1
        global maxNumber1, maxNumber2, quick_pick
        quick_pick = "1"
        tickets = 1
        self.showResults(1)
        self.Number_of_Tickets(tickets, maxNumber1, maxNumber2)

    def on_tick5_mouseClick(self, event): ##this function sets the number of tickets to 5
        global maxNumber1, maxNumber2, quick_pick
        quick_pick = "5"
        tickets = 5
        self.showResults(5)
        self.Number_of_Tickets(tickets, maxNumber1, maxNumber2)

    def on_tick10_mouseClick(self, event): ##this function sets the number of tickets to 10
        global maxNumber1, maxNumber2, quick_pick
        quick_pick = "10"
        tickets = 10
        self.showResults(10)
        self.Number_of_Tickets(tickets, maxNumber1, maxNumber2)

    def on_luckyNumbers_mouseClick(self, event):
        global quick_pick
        quick_pick = "lucky"
        if which == "super":
            tickets = 41416353
        elif which == "mega":
            tickets = 175711536
        elif which == "power":
            tickets = 175223510
        self.showResults(10)
        self.Combos(tickets, maxNumber1, maxNumber2)

    def changeButtons(self): ## changes buttons
        self.components.SuperLottobutton.enabled = False
        self.components.SuperLottobutton.visible = False
        self.components.MegaMillionsbutton.enabled = False
        self.components.MegaMillionsbutton.visible = False
        self.components.PowerBallbutton.enabled = False
        self.components.PowerBallbutton.visible = False
        self.components.tick1.enabled = True
        self.components.tick1.visible = True
        self.components.tick5.enabled = True
        self.components.tick5.visible = True
        self.components.tick10.enabled = True
        self.components.tick10.visible = True
        self.components.luckyNumbers.enabled = True
        self.components.luckyNumbers.visible = True
        self.components.HOME.enabled = True
        self.components.HOME.visible = True

    def on_HOME_mouseClick(self, event): ## takes the user back to the beginning of the program
        self.components.tick1.enabled = False
        self.components.tick1.visible = False
        self.components.tick5.enabled = False
        self.components.tick5.visible = False
        self.components.tick10.enabled = False
        self.components.tick10.visible = False
        self.components.luckyNumbers.enabled = False
        self.components.luckyNumbers.visible = False
        self.components.SuperLottobutton.enabled = True
        self.components.SuperLottobutton.visible = True
        self.components.MegaMillionsbutton.enabled = True
        self.components.MegaMillionsbutton.visible = True
        self.components.PowerBallbutton.enabled = True
        self.components.PowerBallbutton.visible = True
        self.components.HOME.enabled = False
        self.components.HOME.visible = False
        self.components.BACK.enabled = False
        self.components.BACK.visible = False
        self.components.TextArea1.visible = False
        self.components.TextArea1.clear()
        self.components.Ball1.visible = False
        self.components.Ball2.visible = False
        self.components.Ball3.visible = False
        self.components.Ball4.visible = False
        self.components.Ball5.visible = False
        self.components.MegaBall.visible = False

    def showResults(self, tickets): ##prepares the gui to show the tickets
        number_of_tickets = tickets
        self.components.tick1.visible = False
        self.components.tick5.enabled = False
        self.components.tick5.visible = False
        self.components.tick10.enabled = False
        self.components.tick10.visible = False
        self.components.luckyNumbers.enabled = False
        self.components.luckyNumbers.visible = False
        self.components.BACK.enabled = True
        self.components.BACK.visible = True
        self.components.TextArea1.visible = True
        if number_of_tickets == 1:
            self.components.TextArea1.visible = False
            self.components.Ball1.visible = True
            self.components.Ball2.visible = True
            self.components.Ball3.visible = True
            self.components.Ball4.visible = True
            self.components.Ball5.visible = True
            self.components.MegaBall.visible = True
            
    def on_BACK_mouseClick(self, event): ##changes the screen back from the ticket results to previous screen
        self.components.tick1.enabled = True
        self.components.tick1.visible = True
        self.components.tick5.enabled = True
        self.components.tick5.visible = True
        self.components.tick10.enabled = True
        self.components.tick10.visible = True
        self.components.luckyNumbers.enabled = True
        self.components.luckyNumbers.visible = True
        self.components.BACK.enabled = False
        self.components.BACK.visible = False
        self.components.TextArea1.visible = False
        self.components.TextArea1.clear()
        self.components.Ball1.visible = False
        self.components.Ball2.visible = False
        self.components.Ball3.visible = False
        self.components.Ball4.visible = False
        self.components.Ball5.visible = False
        self.components.MegaBall.visible = False

    def lotto(self, maxNum1, maxNum2): ##this function is to the pick the numbers for lottery tickets
        number1 = number2 = number3 = number4 = number5 = 0
        myList = list(xrange(1,maxNum1))
				
        while number1 == 0:
            number1 = random.choice(myList)
            myList.remove(number1)
            number2 = random.choice(myList)
            myList.remove(number2)
            number3 = random.choice(myList)
            myList.remove(number3)
            number4 = random.choice(myList)
            myList.remove(number4)
            number5 = random.choice(myList)
            myList.remove(number5)

        megaNumber = random.randint(1, maxNum2)
        numList = [number1, number2, number3, number4, number5]
        numList.sort()
        num1 = numList[0]
        num2 = numList[1]
        num3 = numList[2]
        num4 = numList[3]
        num5 = numList[4]
        return num1, num2, num3, num4, num5, megaNumber

    def Number_of_Tickets(self, tickets, numLimit1, numLimit2): ##this function is for picking the amount of the tickets the user wants and then displaying them
        global which, quick_pick, List_of_Numbers
        many = 0
        List_of_Numbers = list()
        List_of_MegaNumbers = list()
        while many < int(tickets):
            ticket = self.lotto(numLimit1, numLimit2)
            megaNum = ticket[-1:]
            List_of_Numbers.extend(ticket)
            List_of_MegaNumbers.extend(megaNum)
            many += 1
            ##can delete this section later--------------------------##
            if not quick_pick == "lucky":
                numbers = List_of_Numbers[:5]
                stringVariable = "Numbers " + str(numbers)+ ' Mega ' + str(List_of_MegaNumbers) + "\n"
                self.components.TextArea1.appendText(stringVariable)

                self.components.Ball1.file = self.BallDictionary[numbers[0]]
                self.components.Ball2.file = self.BallDictionary[numbers[1]]
                self.components.Ball3.file = self.BallDictionary[numbers[2]]
                self.components.Ball4.file = self.BallDictionary[numbers[3]]
                self.components.Ball5.file = self.BallDictionary[numbers[4]]
                self.components.MegaBall.file = self.BallDictionary[List_of_MegaNumbers[0]]

                List_of_Numbers = list()
                List_of_MegaNumbers = list()
            ##-------------------------------------------------------##

        if quick_pick == "lucky":
            List_of_Numbers.sort()
            List_of_MegaNumbers.sort()
        return List_of_Numbers, List_of_MegaNumbers

    def Counting(self, LuckyCombo): ##this function is to count all the tickets by the combination of numbers
        global List_of_Numbers, List_of_MegaNumbers, list_of_combos
        lucky = LuckyCombo
        if lucky == "most": ##chooses the most occuring NUMBERS
            number_to_count = (x for x in List_of_Numbers)
            c = Counter(number_to_count)
            d =  c.most_common(5)
            d.sort()

            mega_to_count = (x for x in List_of_MegaNumbers)
            CC = Counter(mega_to_count)
            DD = CC.most_common(1)
            return d, DD
        elif lucky == "combo": ##chooses the most and least occurring combinations
            combo_to_count = (tuple(x) for x in list_of_combos)
            combo_count = Counter(combo_to_count)
            print 'most', combo_count.most_common(1), 'least', list(combo_count.most_common())[-1]
            dcombo = list(combo_count)[-1:]
            ecombo = list(x for x in dcombo)
            return dcombo
        else: ##chooses the least occurring NUMBERS
            number_to_count = (x for x in List_of_Numbers)
            c = Counter(number_to_count)
            reverse = heapq.nsmallest(5, c.items(), key=itemgetter(1))
            d = reverse
            d.sort()

            mega_to_count = (x for x in List_of_MegaNumbers)
            CC = Counter(mega_to_count)
            Reverse = heapq.nsmallest(1, CC.items(), key=itemgetter(1))
            DD = Reverse
            return d, DD

    def Combos(self, tickets, maxNum1, maxNum2): ##function to pick huge amount of tickets to be used for finding the "LUCKY COMBINATION"
        global list_of_combos
        list_of_combos = list()
        combo = list()
        many = 0
        while many < tickets:
            combo = self.lotto(maxNum1, maxNum2)
            combo1 = list(combo)
            list_of_combos.append(combo1)
            many += 1
        #print list_of_combos
        Count = self.Counting("combo")
        stringVariable = str(Count)
        self.components.TextArea1.appendText(stringVariable)

app = model.Application(MainWindow)
app.MainLoop()
