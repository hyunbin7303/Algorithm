#include<iostream>
#include<string>
#include<sstream>
#include<vector>
#include <algorithm>
#include <math.h>
using namespace std;
void printvector(vector<int> vec)
{
	for (int i = 0; i < vec.size(); i++)
	{
		cout << vec[i];
	}
	//cout << endl;
}
vector<int> school_type_addition(vector<int> vec1, vector<int> vec2, int *base)
{
	vector<int> carry, result;
	reverse(vec1.begin(), vec1.end());
	reverse(vec2.begin(), vec2.end());
	carry.push_back(0);
	for (int i = 0; i < max(vec1.size(), vec2.size()); i++)
	{
		//In the bounders of vector
		if (i < min(vec1.size(), vec2.size()))
		{
			if (vec1[i] + vec2[i] + carry[i] >= *base)
			{
				result.push_back(vec1[i] + vec2[i] - *base + carry[i]);
				carry.push_back(1);
			}
			else
			{
				result.push_back(vec1[i] + vec2[i] + carry[i]);
				carry.push_back(0);
			}
		}
		if (i >= min(vec1.size(), vec2.size()))
		{
			if (vec1.size() < vec2.size())
			{
				if (vec2[i] + carry[i] >= *base)
				{
					result.push_back(vec2[i] - *base + carry[i]);
					carry.push_back(1);
				}
				else
				{
					result.push_back(vec2[i] + carry[i]);
					carry.push_back(0);
				}
			}
			else
			{
				if (vec1[i] + carry[i] >= *base)
				{
					result.push_back(vec1[i] - *base + carry[i]);
					carry.push_back(1);
				}
				else
				{
					result.push_back(vec1[i] + carry[i]);
					carry.push_back(0);
				}
			}
		}
	}
	if (carry.back() != 0)
		result.push_back(carry.back());
	reverse(result.begin(), result.end());
	return result;
}
vector<int> school_type_subtraction(vector<int> vec1, vector<int> vec2, int *base)
{
	vector<int> carry, result;
	reverse(vec1.begin(), vec1.end());
	reverse(vec2.begin(), vec2.end());
	carry.push_back(0);
	for (int i = 0; i < max(vec1.size(), vec2.size()); i++)
	{
		//In the bounders of vector
		if (i < min(vec1.size(), vec2.size()))
		{
			if (vec1[i] - vec2[i] - carry[i] < 0)
			{
				result.push_back(vec1[i] - vec2[i] + *base - carry[i]);
				carry.push_back(1);
			}
			else
			{
				result.push_back(vec1[i] - vec2[i] - carry[i]);
				carry.push_back(0);
			}
		}
		if (i >= min(vec1.size(), vec2.size()))
		{
			if (vec1[i] - carry[i] < 0)
			{
				result.push_back(vec1[i] + *base - carry[i]);
				carry.push_back(1);
			}
			else
			{
				result.push_back(vec1[i] - carry[i]);
				carry.push_back(0);
			}
		}
	}
	reverse(result.begin(), result.end());
	return result;
}
vector<int> school_type_Multiplication(vector<int> vec1, vector<int> vec2, int *base)
{
	vector<int> carry, result, temp;
	reverse(vec1.begin(), vec1.end());
	reverse(vec2.begin(), vec2.end());
	if (vec2.size() > vec1.size())
	{
		vec1.swap(vec2);
	}
	for (int i = 0; i < vec2.size(); i++)
	{
		carry.clear();
		carry.push_back(0);
		for (int j = 0; j < vec1.size(); j++)
		{
			if (vec1[j] * vec2[i] + carry[j] >= *base)
			{
				temp.push_back((vec1[j] * vec2[i] + carry[j]) % *base);
				carry.push_back((vec1[j] * vec2[i] + carry[j] - ((vec1[j] * vec2[i] + carry[j]) % *base)) / *base);
			}
			else
			{
				temp.push_back(vec1[j] * vec2[i] + carry[j]);
				carry.push_back(0);
			}
		}
		if (carry.back() != 0)
			temp.push_back(carry.back());
		for (int k = 0; k < i; k++)
		{
			temp.insert(temp.begin(), 0);
		}
		reverse(temp.begin(), temp.end());
		result = school_type_addition(temp, result, base);
		temp.clear();
	}
	return result;
}
int vector_to_int(vector<int> vec, int *base)
{
	// square root of 2147483647 (size of int)
	if (vec.size() > 46340)
		return -1;
	int intvalue = 0;
	for (int i = 0; i < vec.size(); i++)
	{
		intvalue = intvalue + int(pow(*base, (vec.size() - 1 - i)))*vec[i];
	}
}
vector<int> int_to_vector(int value, int *base)
{
	vector<int> vec;
	for (; value > 0; value /= *base)
		vec.push_back(value % *base);
	reverse(vec.begin(), vec.end());
	return vec;
}
vector<int> Karatsuba_Multiplication(vector<int> vec1, vector<int> vec2, int *base)
{
	vector<int> a1, a0, b1, b0, c0, c1, c2, d;
	int n = max(vec1.size(), vec2.size());
	if (n = 1)
	{
		return school_type_Multiplication(vec1, vec2, base);
	}
	//Separation point
	if (n % 2 == 1)
	{
		n = (n + 1) / 2;
	}
	else
		n = n / 2;
	//Vec1 Separation
	if (vec1.size() <= n)
	{
		a1.push_back(0);
		a0 = vec1;
	}
	else
	{
		for (int i = 0; i < vec1.size() - n; i++)
		{
			a1.push_back(vec1[i]);
			reverse(a1.begin(), a1.end());
		}
		for (int i = vec1.size(); i < n; i++)
		{
			a0.push_back(vec1[i]);
			reverse(a0.begin(), a0.end());
		}
	}
	//Vec2 Separation
	if (vec2.size() <= n)
	{
		b1.push_back(0);
		b0 = vec2;
	}
	else
	{
		for (int i = 0; i < vec2.size() - n; i++)
		{
			b1.push_back(vec2[i]);
			reverse(b1.begin(), b1.end());
		}
		for (int i = vec2.size(); i < n; i++)
		{
			b0.push_back(vec2[i]);
			reverse(b0.begin(), b0.end());
		}
	}
	c0 = school_type_Multiplication(a0, b0, base);
	c1 = school_type_Multiplication(a1, b1, base);
	c2 = school_type_Multiplication(school_type_subtraction(a0, a1, base), school_type_subtraction(b0, b1, base), base);
	//(c1*base^2n)+((c1-c2-c0)*base^(n))+(c0)
	return school_type_addition(school_type_Multiplication(school_type_subtraction(school_type_addition(school_type_addition(school_type_Multiplication(c1, int_to_vector(int(pow(*base, 2 * n)), base), base), c0, base), c1, base), c2, base), int_to_vector(int(pow(*base, n)), base), base), c0, base);
}
int main()
{
	int base, numbers = 0;
	vector<int> digit_1, digit_2;
	string input, temp;
	//Public Version
	/*
	cout << endl;
	cout << "Input Format: Digit1 Digit2 Base." << endl;
	*/
	getline(cin, temp);
	stringstream ss(temp);
	while (ss >> input)
	{
		//I1 into vector
		if (numbers == 0)
		{
			if (input.size() > 100)
			{
				//digits over 100
				cout << "Error. Over 100 digits." << endl;
			}
			for (int i = 0; i < input.size(); i++)
			{
				digit_1.push_back(input[i] - 48);
			}
		}
		//I2 into vector
		if (numbers == 1)
		{
			if (input.size() > 100)
			{
				//digits over 100
				cout << "Error. Over 100 digits." << endl;
			}
			for (int i = 0; i < input.size(); i++)
			{
				digit_2.push_back(input[i] - '0');
			}
		}
		//Base
		if (numbers == 2)
		{
			istringstream buffer(input);
			buffer >> base;
			//Error check
			if (base > 10 || base < 2)
			{
				cout << "Error. Base should be between 2 and 10." << endl;
			}
		}
		//loop progrress
		numbers++;
	}
	if (numbers != 3)
	{
		cout << "Error. You should input 3 digits." << endl;
	}
	printvector(school_type_addition(digit_1, digit_2, &base));
	cout << " ";
	printvector(Karatsuba_Multiplication(digit_1, digit_2, &base));
	//DEBUG
	/*
	cout << endl;
	cout << "Karatsuba_Multiplication:" << endl;
	printvector(Karatsuba_Multiplication(digit_1, digit_2, &base));
	cout << "------------CROSS CHECK------------" << endl;
	cout << "School_Type_Multiplication:" << endl;
	printvector(school_type_Multiplication(digit_1, digit_2, &base));
	*/
	system("pause");
	return 0;
}