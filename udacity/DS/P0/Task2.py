"""
Read file into texts and calls.
It's ok if you don't understand how to read files
"""
import csv
with open('texts.csv', 'r') as f:
    reader = csv.reader(f)
    texts = list(reader)

with open('calls.csv', 'r') as f:
    reader = csv.reader(f)
    calls = list(reader)

"""
TASK 2: Which telephone number spent the longest time on the phone
during the period? Don't forget that time spent answering a call is
also time spent on the phone.
Print a message:
"<telephone number> spent the longest time, <total time> seconds, on the phone during 
September 2016.".
"""

# telephone number - in the text.csv file?
## longest time... 
longestDur = 0
phoneNum =''
totalTime = 0

for i in calls:
    if int(i[3]) > longestDur:
        longestDur =int(i[3])
        phoneNum = i[0]

print(phoneNum, 'spent the longest time,', longestDur, 'on the phone during September 2016.')
    

dicts = {}
for re in calls:
    if re[0] not in dicts:
        dicts[re[0]] = int(re[3])
    else:
        dicts[re[0]] += int(re[3])
    if re[1] not in dicts:
        dicts[re[1]] = int(re[3])
    else:
        dicts[re[1]] += int(re[3])

longest_caller = max(dicts, key =dicts.get)
longest_duration = max(dicts.values())

print(longest_caller, 'spent the longest time,', longest_duration, 'on the phone during September 2016.')
    


# Calcualate Big O
# perform a runtime analysis (Worst case BigO notation)
#Dcoumjent this for each problem and include this in your submission.



# Check again Rubric and Submit.
# Use the Rubric to check your work before submission.
# 