# Huffman coding
# Data Compression
# A data compression algorithm reduces the amount of memory (bits) required to represent a message.
# Assume that we have a string message [ ] comprising of 25 characters to be encoded.


# Hufmman coding assigns codes to characters such that the length of the code depends on the relative frequency or weight of the corresponding characters. 
# Huffman codes are of variable-length, and prefix-free (no code is prefix of any other). 
# Any prefix-free binary code can be visualized as a binary tree with the encoded characters stored at the leaves. 

import sys


class Node:
    def __init__(self, left,right):
        self.left = left
        self.right = right

    def children(self):
        return (self.left, self.right)

    def nodes(self):
        return (self.left, self.right)



# Let's finish this one.
def build_huffmantree(data):
    dic_char = {}
    # determine the frequency of each character in the message.
    for c in data:
        if c in dic_char:
            dic_char[c] +=1
        else:
            dic_char[c] = 1

    # Each row in the table above can be represented as a node having a character, frequency, left child and right child.
    # repeatedly require to pop-out the node having the lowest frequency. Therefore, build and sort a list of nodes in the order lowest to highest frequencies.
    sortedDic = sorted(dic_char.items(), key=lambda x: x[1])
    # Pop out two nodes with the minimum frequency from the priority queue created in the above step?
    nodes = sortedDic
    while len(nodes) > 1:
        (key1, c1) = nodes[0]
        (key2, c2) = nodes[1]
        nodes = nodes[2:]
        node = Node(key1, key2)
        nodes.append((node, c1 + c2))
        nodes = sorted(nodes, key=lambda x: x[1])
    return nodes

def encoding_recursive(nodes, direction, strcheck):
    if type(nodes) is str:
        return {nodes: strcheck}
    (l, r) = nodes.children()
    d = dict()
    d.update(encoding_recursive(l, True, strcheck + '0'))
    d.update(encoding_recursive(r, False, strcheck + '1'))


def huffman_encoding(data):
    nodes =build_huffmantree(data)
    getit = encoding_recursive(nodes[0][0], True, '')



    pass

def huffman_decoding(data,tree):
    pass

if __name__ == "__main__":
    codes = {}
    a_great_sentence = "The bird is the word"

    print ("The size of the data is: {}\n".format(sys.getsizeof(a_great_sentence)))
    print ("The content of the data is: {}\n".format(a_great_sentence))

    encoded_data, tree = huffman_encoding(a_great_sentence)

    # print ("The size of the encoded data is: {}\n".format(sys.getsizeof(int(encoded_data, base=2))))
    # print ("The content of the encoded data is: {}\n".format(encoded_data))

    # decoded_data = huffman_decoding(encoded_data, tree)

    # print ("The size of the decoded data is: {}\n".format(sys.getsizeof(decoded_data)))
    # print ("The content of the encoded data is: {}\n".format(decoded_data))