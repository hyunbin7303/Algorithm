

import edu.princeton.cs.algs4.WeightedQuickUnionUF;
/*
FILE : PercolationStats.java
PROGRAMMER : Hyunbin Park
Date       : 2018 / June/ 17
 */

public class Percolation {  
    // create n-by-n grid, with all sites blocked
    private WeightedQuickUnionUF quickU;
    private WeightedQuickUnionUF Check_BackWash;
                                                                                                                                                
    private boolean[][] Grid;
    private int size;
    private int top;
    private int bottom;
    private int num_OpenSite;
    // create n-by-n grid, with all sites blocked
   public Percolation(int n) // n is the size of the grid
   {
       if(n <=0)
       {
           throw new java.lang.IllegalArgumentException("You should type more than one for the number of grid.");
       }
       size = n;
       top = 0;
       bottom = size * size + 1;
       Grid = new boolean[size][size];
       quickU = new WeightedQuickUnionUF((size * size + 2));
       Check_BackWash = new WeightedQuickUnionUF(size*size + 1);
       for (int i = 0; i < size; i++) {
           for (int j = 0; j < size; j++) {
               Grid[i][j] = false;
           }
       }
   } 
   // open site (row, col) if it is not open already
   public    void open(int row, int col)  
   {
       if(row < 0 || row > size || col <0 || col > size)
       {
           throw new java.lang.IllegalArgumentException("Wrong input for the number of size.");
       }
       
       if(row == 1)
       {
           quickU.union(IndexNum(row, col), top);
           Check_BackWash.union(IndexNum(row,col), top);
       }
       if(row == size)
       {
           quickU.union(IndexNum(row,col), bottom);
        //   Check_BackWash.union(IndexNum(row,col), bottom);
       }

       Grid[row-1][col-1] = true;
       num_OpenSite++;
       if(row>1 && isOpen(row-1,col)) // Checking upper of the grid.
       {
           quickU.union(IndexNum(row, col), IndexNum(row-1, col));
           Check_BackWash.union(IndexNum(row, col), IndexNum(row-1, col));
       }
       if(row<size && isOpen(row+1, col)) // CHecking below of the grid.
       {
           quickU.union(IndexNum(row,col), IndexNum(row+1, col));
           Check_BackWash.union(IndexNum(row, col), IndexNum(row+1, col));
       }
       if(col>1 && isOpen(row, col-1) ) // CHecking left on the grid.
       {
           quickU.union(IndexNum(row,col), IndexNum(row,col-1));
           Check_BackWash.union(IndexNum(row, col), IndexNum(row, col-1));
       }
       if(col<size && isOpen(row,col+1)) // CHecking right side of the grid
       {
           quickU.union(IndexNum(row,col), IndexNum(row,col+1));
           Check_BackWash.union(IndexNum(row, col), IndexNum(row, col+1));
       }
   }
   
   public boolean isOpen(int row, int col)  // is site (row, col) open?
   {
       if (row < 1 || row > size || col < 1 || col > size) 
           throw new IndexOutOfBoundsException();
       return Grid[row-1][col-1];
   }
   public boolean isFull(int row, int col)  // is site (row, col) full
   {    
     if (row <= 0 || row > size || col <= 0 || col > size) 
     {
         throw new IndexOutOfBoundsException();
     } 
     return Check_BackWash.connected(IndexNum(row,col), top);
   }
   private int IndexNum(int i, int j)       // number of open sites
   {
       return size * (i-1) + j; 
   }
   public int numberOfOpenSites()
   {
       return num_OpenSite;
   }

   public boolean percolates()              // does the system percolate?
   {
       return quickU.connected(top, bottom);
   }
} 
