/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package algorithm;

/**
 *
 * @author hyunb
 */
public class MergeSort2 {
    public static void print_arr (int[] arr) {
                for (int i = 0; i < arr.length; i++) {
                        System.out.print(arr[i] + " ");
                }
                System.out.println();
        }


    public static void merge(int[] arrA, int[] arrB, int[] arrC)
    {
        int iA= 0; // First array num
        int iB= 0; // Second array num
        int iC = 0; // Result arr num?
        while(iA < arrA.length)
        {
            if(iB < arrB.length)
            {
                if(arrA[iA] < arrB[iB])
                {
                    arrC[iC] = arrA[iA];
                    iA++;
                }
                else
                {
                    arrC[iC] =arrB[iB];
                    iB++;
                }
                iC++;
            }
            else
            {
                while(iA < arrA.length)
                {
                    arrC[iC] = arrA[iA];
                    iA++;
                    iC++;
                }
            }
        }
        while(iB < arrB.length)
        {
            arrC[iC] = arrB[iB];
            iB++;
            iC++;
        }
    }
    
    public static void MergeSort(int[] arr)
    {
        int n = arr.length;
        if(n==1) return;
        int[] arr_temp1 = new int[n/2];
        int[] arr_temp2 = new int[n- n/2];
        for (int i = 0; i < n/2; i++) {
            
            arr_temp1[i] = arr[i];
        }
        for (int i = 0; i < n - n/2; i++) {
            
            arr_temp2[i] = arr[i + n/2];
        }
        
        System.out.print("Array S1 : ");
        print_arr(arr_temp1);
        System.out.print("Array S2 : ");
        print_arr(arr_temp2);
        
        
        
        MergeSort(arr_temp1);
        MergeSort(arr_temp2);
        
        merge(arr_temp1, arr_temp2, arr);
        System.out.print("Array S : ");
        print_arr(arr);
    }
    
    public static void main(String[] args)
    {
        int []arr = {40,20,10,67,20,30,15};
        System.out.print("Before use merge sort.");
        print_arr(arr);
        MergeSort(arr);
        System.out.print("AFTER use merge sort ");
        print_arr(arr);
    }

}
