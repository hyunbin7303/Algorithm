




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


## Stacks and queues
### Stack : Array Implementation
**Array Implementation of a stack
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



## Sort

#### Bubble Sort

Bubble Sort algorithm will require a maximum of n-1 passes to entirely sort the array. 
Bubble sort algorithm compares with adjacent elements from an array, which is used pairwise comparison. 
##### Time Efficiency
**Best Case** : O(n)          
**Worst Case** : O(n^2) - Already sorted as a decending order. 


**Best Case Proof**




## Tree

https://github.com/hyunbin7303/Algorithm/blob/master/Tree/Readme.md        
