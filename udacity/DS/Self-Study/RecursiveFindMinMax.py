#Recursive Programs to find Minimum and Maximum elements of array
#https://www.geeksforgeeks.org/recursive-programs-to-find-minimum-and-maximum-elements-of-array/
# If there is single element, return it.
# Else return minimum of following.
#     a) Last Element
#     b) Value returned by recursive call
#        fir n-1 elements.





def findMinRec(A, n): 
      
    # if size = 0 means whole array 
    # has been traversed 
    if (n == 1): 
        return A[0] 
    return min(A[n - 1], findMinRec(A, n - 1)) 




A = [1, 4, 45, 6, -50, 10, 2] 
n = len(A) 
print(findMinRec(A, n))
