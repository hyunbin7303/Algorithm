// File         : SparseArray.cpp
// Programmer   : Kevin Park
// Date         : 2017/ 7 /17
// Description  : I solved this question but i realized that there are way more efficient way than mine. 
//               I can use map container or unordered_multiset container to optimize it. 

#include <map>
#include <iostream>
#include <vector>
#include <string>
#include <cctype>
#include <unordered_set>
using namespace std;

void MyWaySolution(int SIZE);
int findInsideVec(vector<string> InputString, string word);
void HackerRankIdea(int SIZE);
void FromBlog(int SIZE);

int main()
{
	int size;
	cin >> size;
	//MyWaySolution(size);
	//HackerRankIdea(size);
	FromBlog(size);
	return 0;
}

// Function : MyWaySolution
// Description : I made this solution by using vector containers. 
//               First of all, I put all information in the vector container, and then start to find by using 
//               findInsideVec function which is used for finding same strings in the container. 
void MyWaySolution(int SIZE)
{
	vector<string> userString;
	string word;
	for (int i = 0; i < SIZE; i++)
	{
		cin >> word;
		userString.push_back(word);
	}

	int findHowMany;
	cin >> SIZE;
	for (int i = 0; i < SIZE; i++)
	{
		cin >> word;
		findHowMany = findInsideVec(userString, word);
		cout << findHowMany << endl;
	}
}

// Function : findInsideVec 
// Description : This function is used for finding the same strings in the vector container.
//                If there are the same strings, it increses 1. This function is only used for my solution to return 
//                how many strings are matched. 
int findInsideVec(vector<string> InputString, string word)
{
	int num = 0;
	for (int i = 0; i < InputString.size(); i++)
	{
		if (word == InputString[i])
		{
			num++;
		}
	}
	return num;
}


// Function : HackerRankIdea
// Description : I found this way in the hackerank discussion. 
//               This functions seems very useful since it didn't have to use extra functions.
           
void HackerRankIdea(int SIZE)
{
	int q, i;
	string str;
	unordered_multiset<string> s;
	for (i = 0; i < SIZE; ++i) {
		cin >> str;
		s.insert(str);
	}
	cin >> q;
	for (i = 0; i < q; ++i) {
		cin >> str;
		cout << s.count(str) << '\n';
	}

}

// Function : FromBlog 
// Description : I found this solution from "https://prosenc.blogspot.ca" this blog.
// I guess this one is the most efficient among 3 solutions. 
void FromBlog(int SIZE)
{
	map<string, int>m;
	int n, q;
	string str;

	for (int i = 0; i < SIZE; i++) {
		cin >> str;
		m[str]++;
	}
	cin >> q;
	for (int i = 0; i < q; i++) {
		cin >> str;
		cout << m[str] << endl;
	}
}
