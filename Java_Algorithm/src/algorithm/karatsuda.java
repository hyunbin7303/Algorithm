/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package algorithm;

import java.util.Scanner;

/**
 *
 * @author hyunb
 */
public class karatsuda {
    
    public static int getSize(long num)
    {
        int ctr = 0;
        while(num != 0)
        {
            ctr++;
            num /= 10;
        }
        return ctr;
    }
    public static long KaratsudaAlgorithm(long num1, long num2)
    {
        int size1 = getSize(num1);
        int size2 = getSize(num2);
        int N = Math.max(size1, size2);
        if(N < 10)
        {
            return num1 * num2;
        }
        N = (N/2) + (N%2);
        long m = (long)Math.pow(10, N);
        
        
        long b = num1/m;
        long a = num1 - (b * m);
        long d = num2 / m;
        long c = num2 - (d * N);
        
        
        long z0 = KaratsudaAlgorithm(a,c);
        long z1 = KaratsudaAlgorithm(a+b, c+d);
        long z2 = KaratsudaAlgorithm(b, d);
        return z0 + ((z1-z0-z2)* m) +(z2 * (long)(Math.pow(10, 2*N)));
        
    }
    
    
    public static void main(String[] args)
    {
        Scanner scan = new Scanner(System.in);
        long num1 = scan.nextLong();
        long num2 = scan.nextLong();
        
        long result = KaratsudaAlgorithm(num1, num2);
        System.out.println(result);
    }
}
