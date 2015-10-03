#Hotdog

class Hotdog:
    def __init__(self):
        self.cooked_level = 0
        self.cooked_string = "Raw"
        self.condiments = []

    def __str__(self):
        msg = "hot dog"
        if len(self.condiments) > 0:
            msg = msg + " with "
        for i in self.condiments:
            msg = msg+i+", "
        msg = msg.strip(", ")
        msg = self.cooked_string + " " + msg + "."
        return msg

    def cook(self, time):
        self.cooked_level = self.cooked_level + time
        if self.cooked_level > 8:
            self.cooked_string = "Charcoal"
        elif self.cooked_level > 5:
            self.cooked_string = "Well-done"
        elif self.cooked_level > 3:
            self.cooked_string = "Medium"
        else:
            self.cooked_string = "Raw"

    def addcondiment(self, condiment):
        self.condiments.append(condiment)
        

myDog = Hotdog()
print myDog
print "Cooking hot dog for 4 mintues..."
myDog.cook(4)
print myDog
print "Cooking hot dog for 3 mintues..."
myDog.cook(3)
print myDog
print "What happens if I cook it for 10 more mintues?"
myDog.cook(10)
print myDog
print "Now, I'm going to add some stuff on my hot dog"
myDog.addcondiment("ketchup")
myDog.addcondiment("mustard")
print myDog
