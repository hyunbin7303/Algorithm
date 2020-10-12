
//https://www.freecodecamp.org/news/these-are-the-best-free-courses-to-learn-data-structures-and-algorithms-in-depth-4d52f0d6b35a/

#include "MyAlgorithm.h"



MyAlgorithm::MyAlgorithm(int max)
{
    if(max>100){}
    else{
    for(int i = 0; i< max; i++)
        arr[i] = i;
    }
}
MyAlgorithm::MyAlgorithm(int setup, int setup2)
{
}
int MyAlgorithm::BinarySearch(int wholeNumber, int findIndex)
{
    int a = wholeNumber;
    int b = findIndex;
    // Take input array, left, right & x

    // Start Loop - while (left greater than or equl to right)
    while(1)
    {
        int left = 0;
        int right = 0;
        // mid = left + (right - left) / 2
        int midIndex = left + (right - left ) /2;
        // if (arr[mid) == x
        if(arr[midIndex] == findIndex)
        {

        }
        // else if( arr less than x ) --> left = m+ 1;
        else if(arr[midIndex] < findIndex)
        {

        }
        // else ---> right = mid -1
        else{
            right = arr[midIndex] -1;
        }

    }
    return a+b;
}



// using Stack and Queue implementation. 
