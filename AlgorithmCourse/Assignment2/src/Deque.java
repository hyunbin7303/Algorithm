
import edu.princeton.cs.algs4.StdIn;
import edu.princeton.cs.algs4.StdOut;
import java.util.Iterator;
import java.util.NoSuchElementException;
import java.util.Queue;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
/**
 *
 * @author hyunb
 */
public class Deque<Item> implements Iterable<Item> {

    private int length;
    private Node first;
    private Node last;

    private class Node {

        private Item item;
        private Node prev;
        private Node next;

        Node(Item item) {
            this.item = item;
            next = null;
            prev = null;
        }
    }

    private class ListIterator implements Iterator<Item> {

        private Node cur = first;

        @Override
        public boolean hasNext() {
            return cur != null;
        }

        @Override
        public Item next() {
            if (!hasNext()) {
                throw new NoSuchElementException("THERE ARE NO MORE ITEMS TO RETURN.");
            } else {
                Node node = cur;
                cur = cur.next;
                return node.item;
            }

        }

        public void remove() {
            throw new UnsupportedOperationException();
        }
    }

    public Deque() // construct an empty deque
    {
        length = 0;
        first = null;
        last = null;
    }

    public boolean isEmpty() // is the deque empty?
    {
        return size() == 0;
    }

    public int size() // return the number of items on the deque
    {
        return length;
    }

    public void addFirst(Item item) // add the item to the front
    {
        if (item == null) {
            throw new IllegalArgumentException("Calling addFirst() method with a null argument.");
        }

        if (isEmpty()) {
            first = new Node(item);
            last = first;
        } else {
            Node node = new Node(item);
            node.next = first;
            first.prev = node;
            first = node;

        }
        length++;

    }

    public void addLast(Item item) // add the item to the end
    {
        if (item == null) {
            throw new IllegalArgumentException("Client calls add Last() with a null argument.");
        }
        if (isEmpty()) {
            last = new Node(item);
            first = last;
        } else {
            Node node = new Node(item);
            last.next = node;
            node.prev = last;
            this.last = node;
        }
        length++;
    }

    public Item removeFirst() // remove and return the item from the front
    {
        // Exception handling.
        if (isEmpty()) {
            throw new NoSuchElementException("there is no element in the Queue.");
        }
        Item item = first.item;
        if (size() == 1) {
            first = null;
            last = null;
        } else {
            first = first.next;
            first.prev = null;
        }
        length--;
        return item;
    }

    public Item removeLast() // remove and return the item from the end
    {
        if (isEmpty()) {
            throw new NoSuchElementException("Deque is empty.");
        }
        Item item = last.item;
        if (this.size() == 1) {
            first = null;
            last = null;
        } else {
            last = last.prev;
            last.next = null;
        }
        length--;
        return item;
    }

    public Iterator<Item> iterator() // return an iterator over items in order from front to end
    {
        return new ListIterator();
    }

    public static void main(String[] args) {
        Deque<Integer> deque = new Deque<Integer>();
        deque.addLast(0);
        deque.addLast(1);
        deque.addLast(2);
        deque.addLast(3);
        deque.addLast(4);
        deque.addLast(5);
        deque.addLast(6);
        deque.removeFirst();
        Iterator it = deque.iterator();
        while (it.hasNext()) {
            System.out.println(it.next());
        }
    }
}
