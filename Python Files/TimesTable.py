# times table program

import easygui

mg1 = 'Enter which multiplication table and how high you would like'
title = 'Times Table'
names = ['Multiplication Table', 'How high?']
values = []
values = easygui.multenterbox(mg1, title, names)
table, length = values

for multi in range(int(length) + 1):
    print table, "x ", multi, "= ", int(table) * multi
