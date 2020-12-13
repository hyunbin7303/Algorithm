
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
phone_nums = set()
for i in calls:
    phone_nums.add(i[0])
    phone_nums.add(i[1])

for i in texts:
    phone_nums.add(i[0])
    phone_nums.add(i[1])

print("There are ", len(phone_nums), " different telephone numbers in the records.")


# use set to store its item making the time constant O(1), this will replace the if-not-in code block so worst-time notation would be O(n)
# Worst case scenario: 
