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

"""



outgoing_list = set()
nontele_list = set()
def get_telemarketer(calls):
    for i in calls:
        outgoing_list.add(i[0])
        nontele_list.add(i[1])


get_telemarketer(calls)
get_telemarketer(texts)       
print('total outgoing list: ', len(outgoing_list))
print('total nontele_list: ', len(nontele_list))

tele = nontele_list.difference(outgoing_list)
tele = sorted(tele)

print("These numbers could be telemarketers: ")
for i in tele:
    print('    ',i)
