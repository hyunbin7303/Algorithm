
import edu.princeton.cs.algs4.StdRandom;
import java.util.Iterator;
import java.util.NoSuchElementException;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author hyunb
 */
public class RandomizedQueue<Item> implements Iterable<Item> {
   private int size;
   private Item[] items;
    
   private class RandomizedQueueIterator implements Iterator<Item>
   {
        private int value = size;
        private int[] order;
        
        public RandomizedQueueIterator()
        {
            order = new int[value];
            for (int j = 0; j < value; j++) {
                order[j] = j;
            }
            StdRandom.shuffle(order);
        }
        
        @Override
        public boolean hasNext() {
            return value > 0;
        }
        @Override
        public Item next() {
            
            if (!hasNext())
            {
                throw new java.util.NoSuchElementException("NOT ENOUGH INFORMATION.");
            }
            value--;
            return items[order[value]];
        }

        @Override
        public void remove() {
            if(size == 0){
                throw new UnsupportedOperationException("THERE IS NO ITEMS.");
            }
        }


       
   }
   
   public RandomizedQueue()                 // construct an empty randomized queue
   {
       items = (Item[]) new Object[1];
       size = 0;
   }
   public boolean isEmpty()                 // is the randomized queue empty?
   {
       return size == 0;
   }
   public int size()                        // return the number of items on the randomized queue
   {
       return this.size;
   }
   
   public void enqueue(Item item)           // add the item
   {
       if(item == null)
       {
           throw new NullPointerException("CANNOT GET ANY POINTER.");
       }
       items[size++] = item;
       if(size == items.length)
       {
           resize(2* items.length);
       }
   }
   
   
   private void resize(int capacity)
   {
       Item[] copy = (Item[]) new Object[capacity];
       for (int i = 0; i < size; i++) 
       {
           copy[i] = items[i];
       }
       items = copy;
   }
   
   public Item dequeue()                    // remove and return a random item
   {
       if(size == 0)
       {
           throw new NoSuchElementException("The randomized queue is empty.");
       }
       int num = StdRandom.uniform(size);
       Item Storeitem = items[num]; // Store item information in the new 
       items[num] = items[--size];
       items[size] = null;
       if (size > 0 && size == items.length/4)
       {
           resize(items.length/2);
       }
       return Storeitem;
       
   }

   public Item sample()                     // return a random item (but do not remove it)
   {
        if (size == 0) throw new java.util.NoSuchElementException();
        int num = StdRandom.uniform(size);
        return items[num];
   }
   // Each iterator must return the items in uniformly random order.
   public Iterator<Item> iterator()         // return an independent iterator over items in random order
   {
       return new RandomizedQueueIterator();
   }
       public static void main(String[] args) {
        RandomizedQueue<Integer> rq = new RandomizedQueue<Integer>();
         rq.enqueue(100);
         rq.enqueue(200);
         rq.enqueue(300);
         rq.enqueue(400);   
         rq.dequeue();   //  ==> 437
         rq.enqueue(255);
         rq.dequeue();//     ==> 518
       //  rq.dequeue();
        Iterator it = rq.iterator();
        while (it.hasNext()) {
            System.out.println(it.next());
        }
    }
}
