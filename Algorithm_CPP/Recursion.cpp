// File : Recursion.cpp
// Programmer : Kevin Park
// Date       : 2017 / 7 /18
// Description: I made this file to study recursion. I realized that there are many things that I can do by using recursion. (merge, quick sort etc..)
//               It's quite hard to do when I tried to write down merge sort. That is why I am studying separately. 
// Recursion needs base case to exit.
// Memory Stack- In order to keep track of all this function calls, the program use structure called memory stack.
// Recursions tends to use a lot of memory!! -> stack overflow -> crashing computer! 


#include <assert.h>
#include <iostream>
using namespace std;
int factorial(int num)
{
	if (num == 1)
	{
		return 1;
	}
	return num * factorial(num - 1);
}



int factorial_tail(int num, int res)
{
	if (num == 1)
	{
		return res;
	}
	return factorial_tail(num - 1, res * num);

}
int factorial_2(int num)
{
	return factorial_tail(num, 1);
}


int main()
{
	int num;
	cout << ">> Enter the number you want to find factorial : ";
	cin >> num;
	cout << factorial(num) << endl;
	cout << factorial_2(num) << endl;

	if (num == 5)
	{
		assert(factorial_2(num) == 120); // just trying assert... 
	}

	return 0;
}
