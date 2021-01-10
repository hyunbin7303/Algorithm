
import hashlib
from datetime import datetime

class Block:
    def __init__(self, timestamp, data, previous_hash):
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
        self.numBlock = 0

    def add_block(self, block):
        if self.genesis_block is None:
            self.genesis_block = block
            self.genesis_block.previous_hash = None
            self.last_block = self.genesis_block
            print('Genesis Block : ', self.genesis_block.hash)

        else:
            cur = self.genesis_block
            while cur.next:
                cur = cur.next

            print(cur.hash)
            block.previous_hash = cur.hash
            cur.next = block

    def display_all_blocks(self):
        initBlock = self.genesis_block
        while initBlock != None:
            print('block : ', initBlock.hash)
            initBlock = initBlock.next

# initial block or first block
blockchain = BlockChain()

firstBlock = Block('2021-01-06', 'kevin', None)
blockchain.add_block(firstBlock)

b2 = Block('2021-01-07', 'julio', firstBlock.get_hash())
blockchain.add_block(b2)


# b3 = Block('2021-01-08', 30, b2.get_hash())
#blockchain.add_block(b3)

print("--------------------")
blockchain.display_all_blocks()
