#include <cmath>
#include <cstdio>
#include <vector>
#include <iostream>
#include <algorithm>
#include <assert.h>
using namespace std;



namespace HackerRankQuestions
{
    namespace Recursion{
        // Memory Stack- In order to keep track of all this function calls, the program use structure called memory stack.
        // Recursions tends to use a lot of memory!! -> stack overflow -> crashing computer! 
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
        void CallRecursionTest()
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
        }
    }




}