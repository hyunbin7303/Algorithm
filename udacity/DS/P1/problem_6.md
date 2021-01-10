I've used set data strcture because every data is unique value.
For the union part, I've iterate both linkedlist and save those value in the set.
After that, I created the new linked list and inserted into it.
Time complexity : O(n) + O(n) + O(n) = O(3n)

For the Intersection part, 
I've used three loop(to get the first linked list values, comparison with the second linked list and creating the new linked list)
Time complexity : O(3n)