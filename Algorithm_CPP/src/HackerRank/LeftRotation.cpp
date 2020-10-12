// File       : LeftRotation.cpp
// Programmer : Kevin Park
// Date       : 2017/7/10
// Description: I solved leftRotation question in the hackerrank, but it was quite inefficient.
//              Thanks to hackerrank discussion, I found out some solutions how it can be optimized by using some formula.
//              In order to see how much it was productive, I made two cases.
//              Even though it shows same results, test1(my solution) do some unnecessary process while
//              test2(hackerrank idea) doesn't. It was quite helpful for me to understand concepts. 

#include <iostream>
#include <vector>
#include <algorithm>
using namespace std;

// This two global variables are going to use for counting how many left rotate cycle happened. 
int count1 = 0;
int count2 = 0;

// Function : PrintOut 
// Description : This function is used for displaying numbers after left-rotate.
void PrintOut(int sizeNum, std::vector<int> &test)
{
	for (int i = 0; i < sizeNum; i++)
	{
		cout << test[i] << " ";
	}
}

//Function : myWaySolve
//Description : This function is created by me. It is quite inefficient since it has to left rotate as much as
//				user input. If number of left rotation is higher than number of size, it does unnecessary process.
vector<int> myWaySolve(int leftR, int size, vector<int> arr)
{
	for (int i = 0; i < leftR; i++)
	{
		int temp = arr[0];
		for (int j = 0; j < size - 1; j++)
		{
			arr[j] = arr[j + 1];
		}
		arr[size - 1] = temp;
		count1++;

	}
	return arr;
}

int main()
{
	int sizeNum = 0;
	int LeftRoate = 0;
	cin >> sizeNum >> LeftRoate;
	vector<int> arr(sizeNum);
	for (int i = 0; i < sizeNum; i++)
	{
		cin >> arr[i];
	}

	cout << "My First test case 1 ---" << endl;
	vector<int> test1 = myWaySolve(LeftRoate,sizeNum,arr);
	PrintOut(sizeNum, test1);
	
	cout << endl;
	cout << "Get Some Ideas from Hackerrank websites discussion " << endl;
	LeftRoate %= sizeNum; // By using this, we can minimize left Rotate repeatation.
	vector<int> test2(sizeNum);
	for (int i = 0; i < sizeNum; i++)
	{
		test2[(sizeNum - LeftRoate + i) % sizeNum] = arr[i];
		count2++;
	}
	PrintOut(sizeNum, test2);
	cout << endl << endl;
	cout << "Test1 LeftRotation Cycle : " << count1 << endl;
	cout << "Test2 LeftRotation Cycle : " << count2 << endl;


	
	return 0;
}

