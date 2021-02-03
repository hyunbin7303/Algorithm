# Search in a rotated sorted array.
#given sorted array which is rotated at some random pivot point.
# Given a target value to search. 
# Runtime complexity O(log N)


# Use the binary search algorithm to make it as O(log N )


def rotated_array_search(input_list, number):
    """
    Find the index by searching in a rotated sorted array
    Args:
       input_list(array), number(int): Input array to search and the target
    Returns:
       int: Index or -1
    """
    # how can i set up pivot value? 
    left = 0
    right = len(input_list) -1

    while left <= right:
        mid = (left + right ) // 2
        if mid == number: 
            return mid

        # left sorted case. 
        if input_list[left] <= input_list[mid]:

            if number > input_list[mid] or number < input_list[left]:
                # what should I do?
                left = mid + 1
            elif number < input_list[left]:
                right = mid - 1


        # right sorted case.
        else:
            if number < input_list[mid]
            


        # right sorted case
        else:
            if number   


def linear_search(input_list, number):
    for index, element in enumerate(input_list):
        if element == number:
            return index
    return -1

def test_function(test_case):
    input_list = test_case[0]
    number = test_case[1]
    if linear_search(input_list, number) == rotated_array_search(input_list, number):
        print("Pass")
    else:
        print("Fail")

test_function([[6, 7, 8, 9, 10, 1, 2, 3, 4], 6])
test_function([[6, 7, 8, 9, 10, 1, 2, 3, 4], 1])
test_function([[6, 7, 8, 1, 2, 3, 4], 8])
test_function([[6, 7, 8, 1, 2, 3, 4], 1])
test_function([[6, 7, 8, 1, 2, 3, 4], 10])