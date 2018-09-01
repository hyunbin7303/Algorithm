/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package algorithm;

import java.math.BigInteger;
import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.math.BigInteger;
import java.util.Scanner;
/**
 *
 * @author hyunb
 */
public class KaratsubaTest {

    private static final BigInteger ZERO = new BigInteger("0");
    
    public static BigInteger karatsuba(BigInteger num1, BigInteger num2)
    {
        int N = Math.max(num1.bitLength(), num2.bitLength());
        if(N <= 2000)
        {
            return num1.multiply(num2);
        }
       // Number of bits divided by 2, rounded up
        N = (N/2) + (N % 2);
        
        // num1 = a+ 2^N b, 
        BigInteger b = num1.shiftRight(N);
        BigInteger a = num1.subtract(b.shiftLeft(N));
        BigInteger d = num2.shiftRight(N);
        BigInteger c = num2.subtract(d.shiftLeft(N));
        
        BigInteger ac = karatsuba(a,c);
        BigInteger bd = karatsuba(b,d);
        BigInteger abcd = karatsuba(a.add(b), c.add(d));
        return ac.add(abcd.subtract(ac).subtract(bd).shiftLeft(N)).add(bd.shiftLeft(2*N));
    }
    
    public static void main(String[] args)
    {
        BigInteger bit1, bit2;
        bit1 = new BigInteger("3141592653589793238462643383279502884197169399375105820974944592");
        bit2 = new BigInteger("2718281828459045235360287471352662497757247093699959574966967627");
        BigInteger result= karatsuba(bit1, bit2);
        System.out.println(result);
    }
}
