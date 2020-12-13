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
TASK 3:
(080) is the area code for fixed line telephones in Bangalore.
Fixed line numbers include parentheses, so Bangalore numbers
have the form (080)xxxxxxx.)

Part A: Find all of the area codes and mobile prefixes called by people
in Bangalore.
 - Fixed lines start with an area code enclosed in brackets. The area
   codes vary in length but always begin with 0.
 - Mobile numbers have no parentheses, but have a space in the middle
   of the number to help readability. The prefix of a mobile number
   is its first four digits, and they always start with 7, 8 or 9.
 - Telemarketers' numbers have no parentheses or space, but they start
   with the area code 140.

Print the answer as part of a message:
"The numbers called by people in Bangalore have codes:"
 <list of codes>
The list of codes should be print out one per line in lexicographic order with no duplicates.
"""

codes_list = set()

def called_by_bangalore(alldata):
  for record in alldata:

    caller_area_code = record[0]
    receiver = record[1]
    
    if caller_area_code.startswith('(080)') != -1:
      
      if receiver.startswith('(0') == True:
        endindex = receiver.find(')')
        areacode = receiver[1:endindex]
        codes_list.add(areacode)

      if receiver.startswith('140') == True:
        codes_list.add("140")

      if '7' in receiver[0] or '8' in receiver[0] or '9' in receiver[0]:
        codes_list.add(receiver[0:4])


  result = sorted(codes_list)
  print("The numbers called by people in Bangalore have codes:")
  for i in result:
    print(i)


called_by_bangalore(calls)
# Both these sorting methods have a wrost-case time-complexity of O(n log n ) . 
"""
Part B: What percentage of calls from fixed lines in Bangalore are made
to fixed lines also in Bangalore? In other words, of all the calls made
from a number starting with "(080)", what percentage of these calls
were made to a number also starting with "(080)"?

Print the answer as a part of a message::
"<percentage> percent of calls from fixed lines in Bangalore are calls
to other fixed lines in Bangalore."
The percentage should have 2 decimal digits
"""

def percent_check(alldata):
  totalnum_calls = 0
  Bangalore_calls = 0
  for i in alldata:

    if i[0].startswith('(080)') == True: 

      totalnum_calls+=1
      if i[1].startswith('(080)') == True:
        Bangalore_calls+=1

  result = (Bangalore_calls/totalnum_calls) * 100.0
  round_result = round(result,2)
  return round_result


round_result = percent_check(calls)
print(round_result, " percent of calls from fixed lines in Bangalore are calls to other fixed lines in Bangalore")

# ITERATE THROUGH THE CALLS...

#THE denominator will be the number of times a caller(col 1) is from bangalore.

# The numerator will be the number of times both the caller and receiver (column 1 and col 2) ar from Bangalore.

# Answer should be between 23.00 to 26.00.