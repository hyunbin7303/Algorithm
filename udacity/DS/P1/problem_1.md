Data Strcture: Dictionary and Doubly LinkedList.
I've used dictionary to save each key with value(Node) and it's appropriate because Dictionaries are implemented as hash tables.
Whenever the new data is inserted, deleted and accessed, it searches from the Dictionary first and updates the status of Node.
Secondly, it uses Doubly Linked list due to the fact that Doubly linkedlist is the best suit for inserting/deleting/updating the selected node.

Time & space efficiency. 

For get and set operation - 

Time complexity : O(1) because it uses hash table for finding the unique value.
Space Complexity : O(n) because it requires to generate the size of the input.