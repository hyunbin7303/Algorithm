using System;
using System.Collections.Generic;
using System.Text;

namespace JobInterviewPrepare.Searching
{

    public class TrieNode {

        public char Value { get; set; }
        public List<TrieNode> Children { get; set; }
        public TrieNode Parent { get; set; }
        public int Depth { get; set; }


        public TrieNode(char value, int depth, TrieNode parent)
        {
            Value = value;
            Depth = depth;
            parent = Parent;
        }
        public bool IsLeaf()
        {
            return Children.Count == 0;
        }

        public TrieNode FindChildNode(char c)
        {
            foreach(var child in Children)
            {
                if (child.Value == c)
                    return child;
            }
            return null;
        }

        public void DeleteChildNode(char c)
        {
            for(var i = 0; i< Children.Count; i++)
            {
                if(Children[i].Value == c)
                {
                    Children.RemoveAt(i);
                }
            }
        }


    }

    //The trie data structure is one alternative method for searching text that can be more efficient than traditional search approaches.
    public class Trie
    {
        private readonly TrieNode _root;
        public Trie()
        {
            _root = new TrieNode('^', 0, null);
        }
        public TrieNode Prefix(string s)
        {
            var curNode = _root;
            var result = curNode;
        }


        
    }
}


/* Finding elements.
 * 1. Get children of the root.
 * 2. Itereate through each character of the string.
 * 3. Check whether that character is already a part of a sub-trie. If it isn't present anywhere in the trie, then stop the search and return false.
 * 4. Repeat the second and the third step until there isn't any chracter left in the string. If the end of the string is reached, return true. 
 */


/* Inserting elements.
 * Set a current node as a root node.
 * Set the current letter as the first letter for the word.
 * If the current node has alreawdy an existing reference to the current letter, then set current node to that referenced node. Otherwise, create a new node, set the letter equal to the current letter.
 * and also initizlie current node to this new node.
 * Rpeat step 3 until the key is traversed. 
 * 
 * 
 */