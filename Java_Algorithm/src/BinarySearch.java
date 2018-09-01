/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author hyunb
 */
public class BinarySearch {

    
    // pre-requisite - Num should be higher than 0.
    private static int binarySearchMethod(int[] arr, int num)
    {
        int low, mid;
        int length = arr.length-1;
        low = 0;
        while(low<=length)
        {
            mid = low + (length-low) / 2;
            if(num < arr[mid]) length = mid-1;
            else if(num > arr[mid]) low = mid+1;
            else return mid;
        }
        return -1; // Means there is no value in the array.
    }
    
    public static void main(String[] args)
    {
        int[] a = {1,2,3,4,5,6,7,8,9,10,11,12,13,14};
        int result = binarySearchMethod(a, 13);
        System.out.println("VALUE IS " + result);
    }
    
}
