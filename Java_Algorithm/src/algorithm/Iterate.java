
package algorithm;

import java.util.Iterator;
import java.util.LinkedList;
import java.util.Queue;

/**
 *
 * @author hyunb
 */
public class Iterate {
  
    public static void main(String[] args)
    {
        Queue<Integer> queue = new LinkedList<Integer>();
        queue.add(1);
        queue.add(2);
        queue.add(3);
        Iterator<Integer> it = queue.iterator();
        while(it.hasNext())
        {
            System.out.println(it.next());
        }
        
        
    }
}
