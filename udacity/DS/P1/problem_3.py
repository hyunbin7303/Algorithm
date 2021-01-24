import sys

class Node:
    def __init__(self, left,right):
        self.left = left
        self.right = right
    def children(self):
        return (self.left, self.right)
    def nodes(self):
        return (self.left, self.right)


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
    curNodes = sortedDic

    while len(curNodes) > 1:
        # Pop out two nodes with the minimum frequency from the priority queue created in the above step
        (key1, c1) = curNodes[0]
        (key2, c2) = curNodes[1]
        curNodes = curNodes[2:]
        node = Node(key1, key2)
        curNodes.append((node, c1+c2))
        curNodes = sorted(curNodes, key=lambda x: x[1])
    return curNodes, dic_char

def encoding_recursive(node, left=True, binString=''):
    if type(node) is str:
        return {node: binString}
    (l, r) = node.children()
    d = dict()
    d.update(encoding_recursive(l, True, binString + '0'))
    d.update(encoding_recursive(r, False, binString + '1'))
    return d

def huffman_encoding(data):
    encodeStr = ''
    if data is None or data == "":
        encodeStr='No data to encode!'
        return (encodeStr,None)

    nodes, dic_tree =build_huffmantree(data)
    encodeList =dict()
    if len(dic_tree) ==1:
        encodeList = encoding_recursive(nodes[0][0], True,'1')
    else:
        encodeList = encoding_recursive(nodes[0][0], True,'')
    encodeStr = ''
    for c in data:
        encodeStr += encodeList[c]
    return (encodeStr,nodes)

def huffman_decoding(data,tree):
    if data.isnumeric() == False:
        return ('the data is not numeric')
    root = tree[0][0]
    wholeStr = ''
    rest_data = data

    if type(root) is str:
        while rest_data:
            wholeStr += root
            rest_data = rest_data[1:]
        return wholeStr

    while rest_data:
        check, rest_data  = decoding_recursive(rest_data,root, '')
        wholeStr += check

    return wholeStr

def decoding_recursive(data, tree, input):
    decoded_str = ''
    if type(tree) is str:
        decoded_str += tree
        return (decoded_str, data)
       
    if data[0] == '0':
        tree = tree.left
    else:
        tree =tree.right

    return decoding_recursive(data[1:], tree, decoded_str)



def testing(input):
    codes = {}
    a_great_sentence =input
    print ("The size of the data is: {}\n".format(sys.getsizeof(a_great_sentence)))
    print ("The content of the data is: {}\n".format(a_great_sentence))

    encoded_data, tree = huffman_encoding(a_great_sentence)
    print ("The size of the encoded data is: {}\n".format(sys.getsizeof(int(encoded_data, base=2))))
    print ("The content of the encoded data is: {}\n".format(encoded_data))

    decoded_data = huffman_decoding(encoded_data, tree)

    print ("The size of the decoded data is: {}\n".format(sys.getsizeof(decoded_data)))
    print ("The content of the encoded data is: {}\n".format(decoded_data))



if __name__ == "__main__":
    
    # Normal Testing.
    print('Normal Testing.')
    a_great_sentence = "ABCDEFGHI"
    testing(a_great_sentence)

    #Normal Testing 2 
    print('Normal Testing2.')
    a_great_sentence = "The bird is the word"
    testing(a_great_sentence)


    #Edge case Testing 1 
    print('Edge case Testing with the same character repeated multiple times.')
    a_great_sentence = "BBBBBB"
    testing(a_great_sentence)


    #Edge case Testing 2
    print('Empty space. ')
    a_great_sentence = ""
    encoded_data, tree = huffman_encoding(a_great_sentence)
    print(encoded_data)
    decoded_data = huffman_decoding(encoded_data, tree)
    print(decoded_data)


