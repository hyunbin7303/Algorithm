




# Algorithm
* Dynamic Programming :  Time recursion upside down. - Floyd-Warshall algorithm for the all pairs shortest path problem.
* Greedy : FInd solution by always making the choice that looks optimal at the moment. - Prim's algorithm, Kruskal's algorithm
* Divide and Conquer : Divide the array into smaller arrays segment and then sort this small array element. After all that, combine into as one array. - Merge sort, Quick sort, Strassen's algorithm, FFT.



## Percolation
A model for many physical systems:
* N-by-N grid of sites.
* Each site is open with probability p (or blocked with probabily 1 -p).
* Systemm percolates if top and bottom are connected by open sites.      

### Montel Carlo Simulation
* Initialize N-by-N whole grid to be blocked.
* Declare random sites open until top connected to bottom.
* Vacancy percentage estimates p*. 


## Array 
An Array  is a random access data structure, where3 each element can be accessed directly and in Constant time.      
Array are stored in contigous 
**But why is this?**           

* A linked list is a sequential access data structure, where each element can be accessed
only in particular order. 


## Stacks and queues
### Stack 
A stack is a container of objects that are inserted and removed according to the
Last-In First-Out principle....
Push the item into the stack, and pop the item out of the stack.

**Array Implementation of a stack**
* Use array s[] to store N items on stack.
* Push() : add new item at s[N].
* pop() : remove item from s[N-1].
* Defect : Stack overflows happen when N exceeds capacity.

* Overflow and underflow
  - Underflow - throw exception if pop from an empty stack.
  - Overflow - use resizing array for array implementation.
* Loitering - Holding a reference to an object when it is no longer needed.
```
public String pop()
{
  String item = s[--N];
  s[N] = null;
  return item;
}
```
### Queue 



## Generics 


### Iterators
Suppose that we copy the iterator code from our linked list and resizing array implementations of a stack to the corresponding implementations of a queue.
Which queue iterator(s) will correctly return the items in FIFO order?       
Answer : linked-list iterator only            
The linked-list iterator will work without modification because the items in the linked list are ordered in FIFO order (which is the main reason we dequeue from the front and enqueue to the back instead of vice versa).
The array iterator will fail for two reasons. First, the the items should be iterated over in the opposite order. Second, the items won't typically be stored in the array as entries 0 to n-1n−1.


## Sort

#### Bubble Sort

Bubble Sort algorithm will require a maximum of n-1 passes to entirely sort the array. 
Bubble sort algorithm compares with adjacent elements from an array, which is used pairwise comparison. 
##### Time Efficiency
**Best Case** : O(n)          
**Worst Case** : O(n^2) - Already sorted as a decending order. 


**Best Case Proof**




## Tree



## Binary Search 

### Analysis
**Proposition** : Binary search uses at most 1+lgN compares to search in a sorted array of size N.     
* Def. T(N) = # compares to binary search in a sorted subarray of size <= N.

Binary Search recurrence  T(N) <= T(N/2) + 1 for N>1 , with T(1) = 1    
In here, T(N/2) part --> Left or right half        
+1 part - possible to implement with one 2-way compare (instead of 3-way)      

T(N) <= T(N/2) + 1    .....     
     <= T(N/4) + 1 + 1.......           
     <= T(N/8) + 1 + 1 + 1...........               
     .............
     <= T(N/N) +1 +1 +1 + .... + 1        **Stop Applying , T(1) = 1**
     = 1+ lgN





## Karatsuba Algorithm
Resource :  https://brilliant.org/wiki/karatsuba-algorithm/        
The Karatsuba algorithm is a fast multiplication algorithm that uses a divide and conqure approach
to multiply two numbers.    
The algorithm takes two digits of n-length and splits digits recursively into n/2 length
until they're small enough to computer using grade-school multiplication.
```
x = a* B^m + b
y = c* B^m + d
x*y = B^m(ac) + b^m/2(ad+bc) + bd*
```



* Running time : O(n^log3)


## 3-Way Merge Sort 
Divide into thirds, sort each third, combine all of them using a three-way merge subroutine.        
Running time : nlog(n)            


## K-Way Merge Algorithm          
K-Way Merge Sort. K-sorted Arrays.           
Each with n elements, want to combine them into a single array of kn elements.        
Using the merge subroutine taught in lecture, you merge the first 2 arrays, then merege the 3rd given

            
The merge list size is always O(kn), merging is linear in the size of the larger array, 
and there are k iterations. 





## Required to study for Job Interview.
3. Remove duplicates from an unsorted binary tree

4. Find the angle between an hour and second hand.

3. Count the number of 1 bits in a block of memory.

4. Algorithms and data structures.
// Code solutions.
    Implement a stack using array.
    Implement a stack using linked list.
    Implement a stack using two queues.
    Implement sort an stack using another stack????

// Implementing a stack using array.

5. Dynamic Programming.

    Longest Increasing Subsequence.
    Edit Distance
    Minimum Partition
    Ways to cover a distance.
    Longest Path in Matrix.
    Subset Sum Problems.
    Optimal Strategy for a game.
    0-1 Knapsack Problem.
    Boolean Paranthesizataion Problem.
    