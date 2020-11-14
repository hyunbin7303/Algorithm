// File : MaximumSumHourGlass
// Programmer : Kevin Park (Hyunbin) 
// Date       : 2017 / 6 / 28 
// Description: Actually, this file was algorithm question of HackerRank,
//              but I modified a lot. In the Hackerank question, only thing i have to do was
//              Calculating maximum hourglass in the settled number(row and column),
//              but in this program, user is able to input row and column and input numbers.



#include <new>
#include <iostream>
using namespace std;
#define ERROR -1;


// Function : SumHourGlass
// Purpose : This function is used for calculating maximum Hourglass 
//           from input 2 dimension array. 
// Return : Maximum integer of Hourglass in the array. 
int SumHourGlass(int **arr, int ROW, int COL)
{
	if (ROW < 3 || COL < 3)
	{
		return ERROR;
	}

	int real_ROW = ROW - 2;
	int real_COL = COL - 2;

	int sum = 0;
	int MaxOfSum = -200;

	for (int i = 0; i < real_ROW; i++)
	{
		for (int j = 0; j < real_COL; j++)
		{
			sum = arr[i][j] + arr[i][j + 1] + arr[i][j + 2]
				+ arr[i + 1][j + 1] +
				arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2];
			if (sum > MaxOfSum)
			{
				MaxOfSum = sum;
			}

		}

	}
	return MaxOfSum;
}


// Function : make2D 
// Purpose : Creating 2 dimension array. 
int** make2D(int inputROW, int inputCOL)
{
	int **Array = new int*[inputROW];
	for (int i = 0; i < inputROW; i++)
	{
		Array[i] = new int[inputCOL];
	}
	return Array;
}


// Function : PrintOutArray
// Purpose  : This function is used for showing input array from user. 
void PrintOutArray(int **Array, int ROW, int COL)
{
	for (int i = 0; i < ROW; i++)
	{
		for (int j = 0; j < COL; j++)
		{
			cout << Array[i][j] << " ";
		}
		cout << endl;
	}
}

int main()
{
	
	int Input_COL, Input_ROW;
	cout << "ENTER ROW AND COL : ";
	cin >> Input_ROW >> Input_COL;
	int **Array_2D = NULL;

	Array_2D = make2D(Input_ROW, Input_COL);

	// Put number in the 2D Array 
	cout << "ENTER EACH ELEMENT " << endl;
	for (int i = 0; i < Input_ROW; i++)
	{
		for (int j = 0; j < Input_COL; j++)
		{
			cin >> Array_2D[i][j];
		}
	} // DONE

	// Used for showing all information of Array.
	cout << "Just wanted to check whether information stored properly... " << endl;
	PrintOutArray(Array_2D, Input_ROW, Input_COL);
	int sum = SumHourGlass(Array_2D, Input_ROW, Input_COL);
	cout << "SUM OF HOURGLASS : " << sum << ", Congrats! " << endl;

	//deleteArray(Array_2D, Input_ROW, Input_COL);
	for (int j = 0; j < Input_COL; j++)
	{
		delete[] Array_2D[j];
	}
	delete[] Array_2D;
	return 0;
}


