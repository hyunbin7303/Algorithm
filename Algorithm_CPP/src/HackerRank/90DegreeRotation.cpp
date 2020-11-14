#include <algorithm>
#include <iostream>
using namespace std;
#define N 3
void DisplayMatrix(int matrix[N][N])
{
	for (int i = 0; i < N; i++)
	{
		for (int j = 0; j < N; j++)
		{
			cout << matrix[i][j] << " ";
		}
		cout << endl;
	}
}
void Swap(int& num1, int& num2)
{
	int temp = num1;
	num1 = num2;
	num2 = temp;
}

int main()
{
	int last = N - 1;
	int mat[N][N] = {
		{0,1,2}, 
		{3,4,5},
		{6,7,8}
	};
	DisplayMatrix(mat);
	cout << " ------------------------" << endl;

	for (int i = 0; i < last; i++)
	{
		//for (int j = 0; j < i; j++)
		//{
		Swap(mat[0][i], mat[0][last]);
		Swap(mat[0][i], mat[last][last]);
		Swap(mat[0][i], mat[last][0]);
		//}
	}
	DisplayMatrix(mat);
	system("pause");
}