// File       : LowerBoundStudy.cpp
// Programmer : Kevin Park
// Date       : 2017/7/13
// Description: I created LowerBoundStudy.cpp file to study how to use lower_bound function correctly.
//              Now I understand that it should be sorted order before it is used.
//              Main functionality is that it returns an iterator pointing 
//              to the frist element in the scope that doesn't compare less than value(third parameter).
//              If all values are less than value, it returns last element in the array. 




#include <iostream>
#include <algorithm>
using namespace std;

int main()
{
	int arr[] = { 80,20,3,4,5,10,1,45,9,95 };
	int *ptr;                     // Pointing particular number that wants to find.
	int sizeOfArray = sizeof(arr) / sizeof(int);
	sort(arr, arr +sizeOfArray);  // It is necessary due to the fact that array should be sorted order. 
	
    // Show all array data.
  for (auto it : arr)
	{
		cout << it << " ";
	}

	cout << endl;

	int findNum;
	cin >> findNum; 
	ptr = lower_bound(arr, arr+sizeOfArray, findNum);
  
  
	if (ptr != (arr + sizeOfArray))
	{
		cout << "ARRAY INDEX : " << ptr - arr << endl;
		cout << "VALUE IS : " << *ptr << endl;

	}
	else  // if it cannot find numbers in the array ( if all numbers are less than value)
	{
		cout << "DATA CANNOT FOUND " << endl;
	}
	return 0;
}
