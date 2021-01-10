
import hashlib
from datetime import datetime

class Block:
    def __init__(self, data, previous_hash):
      self.timestamp = datetime.now()
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
            cur = self.genesis_block
            while cur.next:
                cur = cur.next

            block.previous_hash = cur.hash
            cur.next = block

    def display_all_blocks(self):
        curBlock = self.genesis_block
        while curBlock != None:
            print(curBlock.timestamp, ': ','block : ', curBlock.hash)
            curBlock = curBlock.next




# Normal Testing ------
blockchain = BlockChain() 

firstBlock = Block('kevin', None)
blockchain.add_block(firstBlock)

b2 = Block( 'julio', firstBlock.get_hash())
blockchain.add_block(b2)

b3 = Block( 'Udacity', b2.get_hash())
blockchain.add_block(b3)

b4 = Block('This is good', b3.get_hash())
blockchain.add_block(b4)

print("--------------------")
blockchain.display_all_blocks()
##########################################


# Exception Testing
blockchain = BlockChain() 

firstBlock = Block('kevin', None)
blockchain.add_block(firstBlock)

b2 = Block( 'julio', firstBlock.get_hash())
blockchain.add_block(b2)

b3 = Block( 'Udacity', b2.get_hash())
blockchain.add_block(b3)

b4 = Block(1111, b3.get_hash())
blockchain.add_block(b4)
# Display in object has no attribute encode error.