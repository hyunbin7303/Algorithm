
import hashlib
from datetime import datetime, timedelta
class Block:

    #     def __init__(self, timestamp, data, previous_hash):
    #   self.timestamp = timestamp
    #   self.data = data
    #   self.previous_hash = previous_hash
    #   self.hash = self.calc_hash()

    def __init__(self, timestamp, data, previous_hash):
      self.timestamp = timestamp
      self.data = data
      self.previous_hash = previous_hash
      self.hash = self.calc_hash(data)      
      self.next = None

    def calc_hash(self, input):
        sha = hashlib.sha256()
        hash_str = input.encode('utf-8')
        sha.update(hash_str)
        return sha.hexdigest()

    def get_prevhash(self):
        return self.previous_hash

    def get_hash(self):
        return self.hash

class BlockChain:
    def __init__(self):
        self.genesis_block = None
        self.last_block = None

    def add_block(self, block):
        if self.genesis_block is None:
            self.genesis_block = block
            self.genesis_block.previous_hash = None
            self.last_block = self.genesis_block

        else:
            cur = self.last_block
            self.last_block.next = block
            block.previous_hash = cur.hash
            self.last_block = self.last_block.next

    def display_all_blocks(self):
        curBlock = self.genesis_block
        while curBlock != None:
            print(curBlock.timestamp, ': ','block : ', curBlock.hash)
            curBlock = curBlock.next

#This is an O(n) operation. You can make it O(1) by maintaining a tail pointer instead of head and previous pointer instead of next for each block.
# Normal Testing ------
def normal_test():
    blockchain = BlockChain() 

    firstBlock = Block(datetime.now(), 'kevin', None)
    blockchain.add_block(firstBlock)
    b2 = Block(datetime.now()+ timedelta(seconds=1), 'julio', firstBlock.get_hash())
    blockchain.add_block(b2)

    b3 = Block(datetime.now()+ timedelta(seconds=2), 'Udacity', b2.get_hash())
    blockchain.add_block(b3)

    b4 = Block(datetime.now()+ timedelta(seconds=3),'This is good', b3.get_hash())
    blockchain.add_block(b4)

    print("--------------------")
    blockchain.display_all_blocks()

# Exception Testing - Invalid data type.
def edgecase_invalidDataInput():
    blockchain = BlockChain() 

    firstBlock = Block(datetime.now(),'kevin', None)
    blockchain.add_block(firstBlock)

    b2 = Block(datetime.now(), 'julio', firstBlock.get_hash())
    blockchain.add_block(b2)

    b3 = Block(datetime.now(), 'Udacity', b2.get_hash())
    blockchain.add_block(b3)

    b4 = Block(datetime.now(),1111, b3.get_hash())
    blockchain.add_block(b4)
# Display in object has no attribute encode error.

#Edge test cases in this scenario would be, for example:
#    Trying to create an empty block
def edgetest_create_emptyblock():
    blockchain = BlockChain() 

    emptyBlock = Block(datetime.now(),'', None)
    blockchain.add_block(emptyBlock)

    b2 = Block(datetime.now()+ timedelta(seconds=1), '', emptyBlock.get_hash())
    blockchain.add_block(b2)

    b3 = Block(datetime.now()+ timedelta(seconds=2), '', b2.get_hash())
    blockchain.add_block(b3)
    blockchain.display_all_blocks()


def edgetest_timestamp_exactsametime():
    blockchain = BlockChain() 

    emptyBlock = Block(datetime.now(),'Kevin', None)
    blockchain.add_block(emptyBlock)

    b2 = Block(datetime.now(), 'Invalid', emptyBlock.get_hash())
    blockchain.add_block(b2)

    b3 = Block(datetime.now(), 'checking', b2.get_hash())
    blockchain.add_block(b3)
    blockchain.display_all_blocks()


#normal_test()
#edgecase_invalidDataInput() # AttributeError: 'int' object has no attribute 'encode'
#edgetest_create_emptyblock() # Display the same block code.
edgetest_timestamp_exactsametime() # Display without any problems.