
package algorithm;
public class MergeSort {    
    
    private int[] array;
    private int[] tempMerge;
    private int length;
    
    public void Sort(int arr[])
    {
        this.array =arr;
        this.length = arr.length;
        this.tempMerge = new int[length];
        MergeSort(0, length-1);
    }
    private void MergeSort(int low, int high)
    {
        if(low < high)
        {
            int mid = low+(high -low) / 2;
            MergeSort(low, mid);
            MergeSort(mid + 1, high);
            mergeParts(low, mid, high);
        }
    }
    private void mergeParts(int low, int mid, int high)
    {
        for (int i = low; i <= high; i++)
        {
            tempMerge[i] = array[i];
        }
        int i = low;
        int j = mid +1;
        int k = low;
        while(i<=mid && j <= high)
        {
            if(tempMerge[i] <= tempMerge[j])
            {
                array[k] = tempMerge[i];
                i++;
            }
            else
            {
                array[k] = tempMerge[j];
                j++;
            }
            k++;
        }
        while(i <= mid)
        {
            array[k] = tempMerge[i];
            k++;
            i++;
        }
    }
    
    
    static void DisplayArr(int arr[])
    {
        int n = arr.length;
        for (int i = 0; i < n; i++) {
            System.out.print(arr[i] + " ");
        }
        System.out.println();
    }
    public static void main(String[] args)
    {
        // total 12 
       int arr[] = {10,9,5,4,3,2,1,20,25,32,33,22};    
       System.out.println("Merge Sort Algorithm");
       MergeSort ms = new MergeSort();
       ms.Sort(arr);
       for(int i : arr)
       {
           System.out.println(i);
       }
    }
}
