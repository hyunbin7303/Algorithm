
import edu.princeton.cs.algs4.StdIn;
import edu.princeton.cs.algs4.StdOut;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author hyunb
 */
public class Permutation {
    public static void main(String[] args) {
        int k = Integer.parseInt(args[0]);
        RandomizedQueue<String> queue = new RandomizedQueue<>();

        while (!StdIn.isEmpty()) {
            queue.enqueue(StdIn.readString());

            if (queue.size() == k) {
                for (String s : queue) {
                    System.out.println(s);
                }
            }
        }
    }
}