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
public class MyKaratsuba {
    
    
    public static int getSize(long num)
    {
        int ctr = 0;
        while(num != 0)
        {
            ctr++;
            num /= 10;
            System.out.println(num);
        }
        return ctr;
    }
    
    
    // Assume that number is 1234,5678
    private static long Calculation(long num1, long num2)
    {
        int howMany1 = getSize(num1);
        int howMany2 = getSize(num2);
        
        // Start Calculation 
        // based on the number of.. digits
        // How I get First two number?
        
        return 10;
    }
    
    public static void main(String[] args)
    {
        Scanner scan = new Scanner(System.in);
        long num1 = scan.nextLong();
        long num2 = scan.nextLong();
        int check = getSize(num1);
        int check2 = getSize(num2);
        System.out.println(check + " " + check2);
      //  long result = Calculation(num1, num2);
      //  System.out.println(result);
    }
    
}
