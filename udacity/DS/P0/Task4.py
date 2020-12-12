"""
Read file into texts and calls.
It's ok if you don't understand how to read files.
"""
import csv

with open('texts.csv', 'r') as f:
    reader = csv.reader(f)
    texts = list(reader)

with open('calls.csv', 'r') as f:
    reader = csv.reader(f)
    calls = list(reader)

"""
TASK 4:
The telephone company want to identify numbers that might be doing
telephone marketing. Create a set of possible telemarketers:
these are numbers that make outgoing calls but never send texts,
receive texts or receive incoming calls.

Print a message:
"These numbers could be telemarketers: "
<list of numbers>
The list of numbers should be print out one per line in lexicographic order with no duplicates.


* Possible telemarketers are numbers that
* Make outgoing calls.

"""

list_num = []
def possible_telemarketers(codes):
    print('possible telemarket method.')
    for i in codes:
        print(i)
   #     if i[0 ]
    
    # numbers that make outgoing calls but never send texts.
    
    #receiver texts or receive incoming calls?

    


    # Print a message:
    print('These numbers could be telemarketers: ')
    for number in list_num:
        print(number)


#  for values in sorted(set(codes)):
#    print(values)