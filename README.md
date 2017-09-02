
# Algorithm
* Dynamic Programming :  Time recursion upside down. - Floyd-Warshall algorithm for the all pairs shortest path problem.
* Greedy : FInd solution by always making the choice that looks optimal at the moment. - Prim's algorithm, Kruskal's algorithm
* Divide and Conquer : Divide the array into smaller arrays segment and then sort this small array element. After all that, combine into as one array. - Merge sort, Quick sort, Strassen's algorithm, FFT.





## Sort

#### Bubble Sort

Bubble Sort algorithm will require a maximum of n-1 passes to entirely sort the array. 
Bubble sort algorithm compares with adjacent elements from an array, which is used pairwise comparison. 
##### Time Efficiency
**Best Case** : O(n)          
**Worst Case** : O(n^2) - Already sorted as a decending order. 

                                Cost                      Time
For(i ~ Length(array) -1         C1                          n                                
  do For(j - Length(array)-i     C2                       (n-1)(n-i+1)                      
  do if(Array(j) > Array(j+1))   C3                        (n-1)(n-i)                     
       Then Change!              C4                        (n-1)(n-i)      
            
 - T(n) = C1 * n + C2 * ((n-1)(n-i+1))  + C3 * (n-1)(n-i)   + C4 * (n-1)(n-i)                     
    
     
**Best Case Proof**




## Tree

https://github.com/hyunbin7303/Algorithm/blob/master/Tree/Readme.md        
