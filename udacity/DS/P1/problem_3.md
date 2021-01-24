
Encoding Time Complexity :
For the encoding part, I believe there are two parts: Building huffman Tree and encoding based on the tree.
In order to build tree, I've used a for statement, so it should be O(n).
# The time complexity of creation of tree is O(nlogn)

For encoding portion, I've used two for statment, so it should be O(n) + O(n).
So, total it should be O(3n).
# Space Complexity ... for Decoding.



Decoding time complexity : 
    In the worst case, I believe it can be O(n^2) because there is a while statement to run every bits as well as recursive methods
    need to check each node.
    So time complexity : O(n^2)
# Space complexity is missing here.

# Space Complexity ... for Decoding.
