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
TASK 1:
How many different telephone numbers are there in the records? 
Print a message:
"There are <count> different telephone numbers in the records."
"""
lists = list()
i = 0
for i in range(len(calls)):
    if lists.count(calls[i][1]) >1:
        continue
    else:
        lists.append(calls[i][1])


print("There are ",len(lists)," different telephone numbers in the records.")

