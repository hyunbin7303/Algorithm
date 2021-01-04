class Node:
    def __init__(self, value):
        self.next = None
        self.prev = None
        self.value = value


class DoublyLL:

    def __init__(self):
        self.head = None
        self.tail = None

    def push(self, value):
        newNode = Node(value)
        if self.head is None:
            self.head = newNode
            self.tail = newNode
        else:
            newNode.next = self.head
            self.head.prev = newNode
            self.head = newNode

    def insertAfterNode(self, selectNode, value):
        if selectNode is None:
            return
        newNode = Node(value)
        newNode.next = selectNode.next 

        selectNode.next = newNode
        newNode.prev = selectNode
        if newNode.next is not None:
            newNode.next.prev = newNode


    def append(self, value):
        newNode = Node(value)
        if head is None:
            self.head = newNode
            self.tail = newNode
        else:
            self.tail.next=  newNode
            newNode.prev = self.tail
            self.tail = newNode

    def traverse(self, node):
        while node != None:
            print(node.value)
            node = node.next



dd = DoublyLL()
dd.push(10)
dd.push(20)
dd.push(30)
dd.push(40)
dd.push(50)
dd.insertAfterNode(dd.head.next, 35)            
dd.traverse(dd.head)