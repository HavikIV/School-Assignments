#! usr/bin/env python
# Conversions.py
# Manjinder Singh

pro = "true"

while pro == "true":
        
        mode = raw_input("What do you want to convert? (Enter either Celsius or Fahreneit) ")

        if mode == "Celsius" or mode == "CELSIUS" or mode == "celsius":
                Fah = raw_input("Enter the Fahreneit ")
                CEL = 5.0/9 * (float(Fah) - 32)
                print Fah, "converted to celsius is", CEL
        elif mode == "Fahreneit" or mode == "FAHRENEIT" or mode == "fahreneit":
                Cel = raw_input("Enter the Celsius ")
                FAH = (float(Cel) * (9.0/5)) + 32
                print Cel, "converted to fahreneit is", FAH
