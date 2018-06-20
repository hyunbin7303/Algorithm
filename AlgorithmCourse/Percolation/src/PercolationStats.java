

import edu.princeton.cs.algs4.StdOut;
import edu.princeton.cs.algs4.StdRandom;
import edu.princeton.cs.algs4.StdStats;

/*
FILE : PercolationStats.java
PROGRAMMER : Hyunbin Park
Date       : 2018 / June/ 17
*/

public class PercolationStats {
    
    private int numExperiments;
    private double[] fractions;
    private Percolation percol;
    
   public PercolationStats(int n, int trials)    // perform trials independent experiments on an n-by-n grid
   {    
       int row=0, col =0;
       if(n <=0)
       {
          throw new java.lang.IllegalArgumentException("You should type more than one for the number of grid.");
       }
       numExperiments = trials;
       fractions =new double[numExperiments];
       for(int i=0; i< numExperiments; i++)
       {
           percol = new Percolation(n);
           int result = 0;
           while(!percol.percolates())
           {
               row = StdRandom.uniform(1, n+1);
               col = StdRandom.uniform(1, n+1);
               
               if(!percol.isOpen(row, col))
               {
                   percol.open(row,col);
                   result++;
               }
           }
           
           
           double value = (double) result /(n * n);
           fractions[i] = value;
           
       }
   }
   public double mean()                          // sample mean of percolation threshold
   {
              return StdStats.mean(fractions);

   }
   public double stddev()                        // sample standard deviation of percolation threshold
   {
              return StdStats.stddev(fractions);

   }
   public double confidenceLo()                  // low  endpoint of 95% confidence interval
   {
       return mean()- 1.96 * stddev() / Math.sqrt(numExperiments);
   }
   public double confidenceHi()                  // high endpoint of 95% confidence interval
   {
       return mean() +1.96 * stddev() / Math.sqrt(numExperiments);
   }
    public static void main(String[] args) 
    {
       // System.out.println("INPUT " + args[0] + " " + args[1]);
        int N = Integer.parseInt(args[0]);
        int Trials = Integer.parseInt(args[1]);
        PercolationStats ps = new PercolationStats(N,Trials);
        
        
        String cofidence = ps.confidenceLo() + " - " + ps.confidenceHi();
        StdOut.println("Mean = " + ps.mean());
        StdOut.println("stddev = " + ps.stddev());
        StdOut.println("95% cofidence interval = " + cofidence);

    }

}