#include <iostream>
#include <math.h>
#include <algorithm>
#include <string>
using namespace std;

// making two numbers to the same length
int EqualLength(string& str1, string& str2)
{
	int lengthStr1 = str1.length();
	int lengthStr2 = str2.length();
	if (lengthStr1 > lengthStr2)
	{
		for (int i = 0; i < lengthStr1 - lengthStr2; i++)
		{
			str2 = '0' + str2;
		} 
	}
	else if (lengthStr1 < lengthStr2)
	{
		for (int i = 0; i < lengthStr2 - lengthStr1; i++)
		{
			str1 = '0' + str1;
		}
		return lengthStr2;
	}
	return lengthStr1;

}


string addBitsString(string first, string second)
{
	string res;
	int length = EqualLength(first, second);
	int carry = 0;
	for (int i = length-1; i >= 0; i--)
	{
		int firstBit = first.at(i) - '0';
		int secondBit = second.at(i) - '0';

		int sum = (firstBit ^ secondBit ^ carry) + '0';
		res = (char)sum + res;

		// boolean expression 
		carry = (firstBit & secondBit) | (secondBit & carry) | (firstBit& carry);
		if (carry)
		{
			res = '1' + res;
		}
		return res;
	}

}

int multiplySingleBit(string a, string b)
{
	return (a[0] - '0')* (b[0] - '0');
}

long int multiply(string X, string Y)
{
	int n = EqualLength(X, Y);

	// Base cases
	if (n == 0) return 0;
	if (n == 1) return multiplySingleBit(X, Y);

	int fh = n / 2;   // First half of string, floor(n/2)
	int sh = (n - fh); // Second half of string, ceil(n/2)

					   // Find the first half and second half of first string.
					   // Refer http://goo.gl/lLmgn for substr method
	string Xl = X.substr(0, fh);
	string Xr = X.substr(fh, sh);

	// Find the first half and second half of second string
	string Yl = Y.substr(0, fh);
	string Yr = Y.substr(fh, sh);

	// Recursively calculate the three products of inputs of size n/2
	long int P1 = multiply(Xl, Yl);
	long int P2 = multiply(Xr, Yr);
	long int P3 = multiply(addBitsString(Xl, Xr), addBitsString(Yl, Yr));

	// Combine the three products to get the final result.
	return P1 * (1 << (2 * sh)) + (P3 - P1 - P2)*(1 << sh) + P2;
}

// Driver program to test aboev functions
int main()
{
	printf("%ld\n", multiply("1100", "1010"));
	printf("%ld\n", multiply("110", "1010"));
	printf("%ld\n", multiply("11", "1010"));
	printf("%ld\n", multiply("1", "1010"));
	printf("%ld\n", multiply("0", "1010"));
	printf("%ld\n", multiply("111", "111"));
	printf("%ld\n", multiply("11", "11"));
	system("pause");

}
//
//int main()
//{
//	string num = "2567111";
//	string num1 = "33333";
//	
//	cout << EqualLength(num, num1) << endl;
//	cout << num << endl;
//	cout << num1 << endl;
//}