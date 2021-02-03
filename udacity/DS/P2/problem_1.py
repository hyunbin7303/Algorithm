# Finding tge square root of an integer.
# Find the sqaure root of the integer without using any python library.
# Have to find the floor value of the sqaure root.
# For example if the given number is 16, then the answer would be 4.
# if the given number is 27, the answer would be 5 because sqrt(5) = 5.196...
# The expected time complexity is O(log(n))


# In order to make it as O(log(n)) time complexity, it requires to use the binary search. 
def sqrt(number):
    """
    Calculate the floored square root of a number
    Args:
       number(int): Number to find the floored squared root
    Returns:
       int: Floored Square Root
    """
    if number == 0 or number == 1:
        return 1
    if number < 0:
        return None

    start = 1 
    end = number
    while start <= end:
        mid = (start + end) // 2
        value = mid * mid 

        if value == number:
            return mid

        if value < number:
            start = mid + 1
            answer = mid
        else:
            end = mid-1            
    
    return answer 



print ("Pass" if  (3 == sqrt(9)) else "Fail")
print ("Pass" if  (0 == sqrt(0)) else "Fail")
print ("Pass" if  (4 == sqrt(16)) else "Fail")
print ("Pass" if  (1 == sqrt(1)) else "Fail")
print ("Pass" if  (5 == sqrt(27)) else "Fail")