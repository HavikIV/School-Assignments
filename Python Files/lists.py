#! usr/bin/env python
# lists.py
# manjinder singh

ltrs = ['a', 'b', 'c', 'd']
nums = [1, 2, 3, 4]

for ltr in ltrs:
    print ltr, "it's type is", type(ltr)

for num in nums:
    print num, "it's type is", type(num)

print 'Sum of the of the numbers in the list nums is', sum(x for x in nums)
