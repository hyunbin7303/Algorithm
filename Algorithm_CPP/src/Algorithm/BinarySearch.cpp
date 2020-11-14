

// Hierarchical data strctures.
// it merely means data are stored as records which are connected to
// one another through different sorts of links.

// A binary search tree (BST) is a binary tree where each node has a Comparable key (and an associated value) and satisfies the restriction that the key in any node is larger than the keys in all nodes in that node’s left subtree and smaller than the keys in all nodes in that node’s right subtree (Sedgewick & Wyane, 2016)
// A root is a topmost node also known as a parent node
// and a bst contains only one parent node.

// There are three rules to be a BST:-

//     The node’s left subtree contains only a key that’s smaller than the node’s Key.
//     The node’s right subtree contains only a key that’s greater than the node’s Key.
//     It cannot have a duplicate node’s key value.

// https://medium.com/swlh/binary-search-trees-c-484377f0d349
// https://www.softwaretestinghelp.com/binary-search-tree-in-cpp/


#include <iostream>

struct Node
{
public:
    int key;
    int data;
    Node * Left;
    Node * Right;
    Node * Parent;
    int height;
};
namespace BinarySearch
{
    void insert(int key)
    {
    }
    int PrintTreeInOrder()
    {
    }
    bool Search(int key)
    {
    }
    int Successor(int key) 
    {
    }
    int Predecessor(int key)
    {
    }
    void Remove(int key)
    {
    }
}
