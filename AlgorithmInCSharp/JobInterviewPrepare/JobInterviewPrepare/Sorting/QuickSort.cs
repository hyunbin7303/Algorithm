using System;
using System.Collections.Generic;
using System.Text;

namespace JobInterviewPrepare.Sorting
{
    // Code from GeeksforGeek.
    //https://www.geeksforgeeks.org/quick-sort/
    public class QuickSort
    {
        public void quickSort(int[] arr, int low, int high)
        {
            if(low<high)
            {
                int partitionIndex = partition(arr, low, high);
                quickSort(arr, low, partitionIndex - 1);
                quickSort(arr, partitionIndex + 1, high);
            }

        }

        // Partition algorithm
        // we start from the left most element and keep track of index of smaller or equal to elements as i.
        
        // Takes last element as pivot, places the pivot element at its correct position in sorted array,
        // and places all smaller (smaller than pivot) to left of pivot and
        // all greater elements to right of pivot.
        public int partition(int[] arr,int low, int high)
        {
            int pivot = arr[high];
            int i = (low - 1);
            for(int j = low; j< high; j++)
            {
                if(arr[j] < pivot)
                {
                    i++;
                    // swap arr[i] and arr[j]
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            int temp1 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp1;
            return i + 1;
        }




    }
}
