#ifndef MYALGORITHM_H
#define MYALGORITHM_H

#include <stdio.h>
#include <iostream>


namespace Algo{

};


class MyAlgorithm
{
    public:
        MyAlgorithm(){};
        MyAlgorithm(int max);
        MyAlgorithm(int max, int setup2);
        int BinarySearch(int wholeNumber, int findIndex);

        double SpaceComplexity(){return 0.0f;}
        double TimeComplexity(){return 0.0f;};

    private:
        int arr[100];
        int *foo;

};
#endif


// Implementing Hash Table again.
// I forgot how to do that.




// Copy Constructor - it initializes an object by copying the member values from an object of the same type.
// Move Constructor - It is a special memeber function that moves ownership of an exisiting object's data to a new variable without copying the original data.
//https://docs.microsoft.com/en-us/cpp/cpp/constructors-cpp?view=vs-2019
