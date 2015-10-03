#! usr/bin/env python
# Coins.py
# Manjinder Singh
# Sequence
from time import sleep

FirstName = raw_input("What's your first name? ")
Pennies = raw_input("How many pennies do you have? ")
Nickels = raw_input("How many nickels do you have? ")
Dimes = raw_input("How many dimes do you have? ")
Quarters = raw_input("How many quarters do you have? ")
Optional = raw_input("Do you have half-dollar or dollar coins? ")

cents = int(Pennies) + (int(Nickels) * 5) + (int(Dimes) * 10) + (int(Quarters) * 25)

if Optional == "yes" or Optional == "Yes" or Optional == "YES":
    HalfDollar = raw_input("How many half-dollar coins do you have? ")
    DollarCoin = raw_input("How many dollar coins do you have? ")
    cents = cents +  (int(HalfDollar) * 50) + (int(DollarCoin) * 100)

dollars = cents / 100
change = cents % 100

print "Hello,", FirstName, "you have", dollars, "dollars and", change, "cents."
sleep(5)