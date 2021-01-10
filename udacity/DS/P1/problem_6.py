# Union and Intersection of Two Linked Lists

class Node:
    def __init__(self, value):
        self.value = value
        self.next = None

    def __repr__(self):
        return str(self.value)


class LinkedList:
    def __init__(self):
        self.head = None

    def __str__(self):
        cur_head = self.head
        out_string = ""
        while cur_head:
            out_string += str(cur_head.value) + " -> "
            cur_head = cur_head.next
        return out_string


    def append(self, value):

        if self.head is None:
            self.head = Node(value)
            return

        node = self.head
        while node.next:
            node = node.next

        node.next = Node(value)

    def size(self):
        size = 0
        node = self.head
        while node:
            size += 1
            node = node.next

        return size

    def traverse_print(self):
        cur = self.head
        while cur:
            print("display : ", cur.value)
            cur = cur.next



def union(llist_1, llist_2):
    # Your Solution Here
    # Store the data in the Dictionary . [key value] pair.

    if llist_1 is None or llist_2 is None:
        return None
    
    storeSet = set()
    cur1 = llist_1.head
    while cur1:
        storeSet.add(cur1.value)
        cur1= cur1.next

    cur2 = llist_2.head
    while cur2:
        storeSet.add(cur2.value)
        cur2 = cur2.next

    resultLL= LinkedList()
    for i in storeSet:
        resultLL.append(i)
    return resultLL


def intersection(llist_1, llist_2):

    if llist_1 is None or llist_2 is None:
        return None
    
    resultLL= LinkedList()
    setA = set()
    cur1 = llist_1.head
    while cur1:
        setA.add(cur1.value)
        cur1= cur1.next

    setResult = set()
    cur2 = llist_2.head
    while cur2:
        if cur2.value in setA:
            setResult.add(cur2.value)
        cur2 = cur2.next

    for i in setResult:
        resultLL.append(i)
    return resultLL


# Test case 1

linked_list_1 = LinkedList()
linked_list_2 = LinkedList()

element_1 = [3,2,4,35,6,65,6,4,3,21]
element_2 = [6,32,4,9,6,1,11,21,1]

for i in element_1:
    linked_list_1.append(i)

for i in element_2:
    linked_list_2.append(i)

print (union(linked_list_1,linked_list_2))
print (intersection(linked_list_1,linked_list_2))

# Test case 2

linked_list_3 = LinkedList()
linked_list_4 = LinkedList()

element_1 = [3,2,4,35,6,65,6,4,3,23]
element_2 = [1,7,8,9,11,21,1]

for i in element_1:
    linked_list_3.append(i)

for i in element_2:
    linked_list_4.append(i)

print (union(linked_list_3,linked_list_4))
print (intersection(linked_list_3,linked_list_4))
