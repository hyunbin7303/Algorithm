
class Node(object):
    def __init__(self, key, value):
        self.key = key,
        self.value = value
        self.next = None
        self.prev = None


class LRU_Cache(object):
    ## using doubly linked List 

    def __init__(self, capacity):
        # Initialize class variables
        self.size_cache = capacity
        self.dictCache = {}
        # created Doubly Linkedlist. 
        self.head = Node(0,0)
        self.tail = Node(0,0)
        self.head.next = self.tail
        self.tail.prev = self.head        
        self.size = 0

    def get_currentsize(self):
        return self.size


    def delete_node(self, node):
        nodeafter = node.next
        nodebefore = node.prev
        nodebefore.next = nodeafter
        nodeafter.prev = nodebefore

    def move_to_end(self, node):
        prevnode_of_tail = self.tail.prev
        prevnode_of_tail.next = node
        node.prev = prevnode_of_tail
        node.next = self.tail
        self.tail.prev = node


    def get(self, key):
        # Retrieve item from provided key. Return -1 if nonexistent. 
        if key in self.dictCache:
            node = self.dictCache[key]
            self.delete_node(node)
            self.move_to_end(node)
            return key
        else:
            return -1

    def set(self, key, value):
        # To add an item to our cache we need a unique key to grant us constant access to the node we are about to add,
        # and also the value of the node.
        # Set the value if the key is not present in the cache.
        if key in self.dictCache:
            print('key exists in the dictionary.')
            node = self.dictCache[key]
            self.delete_node(node)
            self.move_to_end(node)

        else: # not exist so add in the Dictionary.
            if self.size >=self.size_cache:
                # Remove the oldest item.
                deletenode =self.head.next
                print('size is higher than total size. Delete the least used node key : ', deletenode.key[0])

                del self.dictCache[deletenode.key[0]]
                self.delete_node(deletenode)
                self.size -= 1


            # Add key value in the node.
            newNode = Node(key, value)
            self.dictCache[key] = newNode
            self.move_to_end(newNode)
            self.size+= 1

#if the entry is found in the cache, it is known as a cache hit. If, however, the entry is not found, it is known as a cache miss.
    def traverse(self, node):
        while(node != None):
            print(node.value)
            node = node.next    






our_cache = LRU_Cache(5)
our_cache.set(1, 1)
our_cache.set(2, 2)
our_cache.set(3, 3)
our_cache.set(4, 4)

print(our_cache.get(1))       # returns 1
print(our_cache.get(2))       # returns 2
print(our_cache.get(9))      # returns -1 because 9 is not present in the cache
our_cache.set(5, 5) 
our_cache.set(6, 6)
our_cache.set(9, 9)


print(our_cache.get(3))      # returns -1 because the cache reached it's capacity and 3 was the least recently used entry

our_cache.traverse(our_cache.head)
