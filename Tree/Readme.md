


## Red / Black Trees

The algorithm of Red/Black trees is used in a number of standard library implementations in c++ and Java.        
Red/Black algirhtm is a BST in which each node is colered either red or black. 



### Invariants
* Ordering : Same with BST 
* Height   : The number of black nodes on every path from the root to each leaf is the same. 
* Color    : Two red nodes cannot be consecutive. 
* Root     : Root of tree has to be black. 

The balance and color invariants together imply that the longest path from the root to a leaf is at most twice as long as the shortest path. 

From    http://www.geeksforgeeks.org/red-black-tree-set-1-introduction-2/          
### Black Height of a Red-Black Tree
Black height is number of black nodes on a path from a node to a leaf.     
Leaf nodes are alco counted black nodes. 


#### Why Red-black trees?        
Most of the BST take O(h) time where h is the hiegh of the BST.
The height of a Red-Black tree is always O(Log N) where n is the number of nodes in the tree.

#### Comparison with AVL?        
The AVL trees are more balanced compared to Red/Black trees, but they may cause more rotations during insertion and deletion. 
Red-black is used when application has to do many insertions and deletions. Sometimes, AVL tree is desirable when insertions
and deletions are less frequent and search is more frequent operation.


### Insetion


### Rotation


### Implementing Rebalancing 



