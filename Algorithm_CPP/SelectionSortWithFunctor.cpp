

#include <algorithm>
#include <iostream>

void selectionSort(int *array, int size, bool(*comparison)(int, int))
{
	for (int start = 0; start < size; start++)
	{
		int bestIndex = start;
		for (int current = start + 1; current < size; current++)
		{
			if (comparison(array[bestIndex], array[current]))
			{
				bestIndex = current; 
			}
		}
		std::swap(array[start], array[bestIndex]);
	}
}



bool ascending(int x, int y)
{
	return x > y;
}

bool descending(int x, int y)
{
	return x < y;
}

bool evenFirst(int x, int y)
{
	if ((x % 2 == 0) && !(y % 2) == 0)
	{
		return false;
	}
	if ((x % 2 == 0) && (y % 2) == 0)
	{
		return true;
	}
	return ascending(x, y);
}

void printArray(int *array, int size)
{
	for (int index = 0; index < size; index++)
	{
		std::cout << array[index] << " ";

	}
	std::cout << '\n';
}



int main(void)
{
	int array[9] = { 5,4,2,10,4,5,6,7,1 };
	selectionSort(array, 9, descending);
	printArray(array, 9);
	selectionSort(array, 9, ascending);
	printArray(array, 9);

	int ar2[5] = { 2,5,3,4,1 };
	selectionSort(ar2, 5, evenFirst);
	printArray(ar2, 5);
	
	return 0;
}


