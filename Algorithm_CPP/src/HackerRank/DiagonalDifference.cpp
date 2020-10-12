#include <cmath>
#include <cstdio>
#include <vector>
#include <iostream>
#include <algorithm>
using namespace std;


//Function    : mySolution
//Description : This function is solution of this question which is created by me. 
//              First of all, it creates vector two dimensional array and asks all numbers.
//              After that, it finds particular numbers and calculates it. 

int mySolution(int size)
{

	vector< vector<int> > a(size, vector<int>(size));
	for (int a_i = 0; a_i < size; a_i++) {
		for (int a_j = 0; a_j < size; a_j++) {
			cin >> a[a_i][a_j];
		}
	}
	int sum1 = 0;
	for (int i = 0; i<size; i++)
	{
		sum1 += a[i][i];
	}
	int sum2 = 0;
	for (int i = 0, j = size- 1; i<size, j >= 0; i++, j--)
	{
		sum2 += a[i][j];
	}
	return abs(sum2 - sum1);
}


// Function    : hackerRankSolution
// Description : I found out this solution in the hackerrank discussion.
//               It looks nice because it doesn't have to create array, which is more efficient. 
//                
int hackerRankSolution(int size)
{
	int across=0, re_across=0;
	for (int i = 0; i < size; i++)
	{
		for (int j = 0; j < size; j++)
		{
			int input;
			cin >> input;
			if (i == j)
			{
				across += input;
			}
      
      // it finds second diagonal numbers and add all of it.
			if ((i + j) == size - 1)
			{
				re_across += input;
			}
		}
	}
	return abs(across - re_across); // Return absolute value.
}


int main() {
	int n; // Size of matrix
	int test1, test2;
	
  cin >> n;
	
	test1 = mySolution(n); // My solution function. 
	cout << test1 << endl;
	
	test2 = hackerRankSolution(n); // Hackerrank Idea
	cout << test2 << endl;
	return 0;
}
