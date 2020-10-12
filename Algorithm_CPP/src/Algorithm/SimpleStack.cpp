#include <iostream>
#include <string>
using namespace std;

template <typename T>
class Stack
{
	struct Node
	{
		T anything;
		Node* nextNode;
		Node(T something, Node* next)
		{
			anything = something;
			nextNode = next;
		}

	};
private:
	int howMany;
	Node* pointing;
public:

	Stack() : howMany(0), pointing(NULL) {};
	~Stack()
	{}
	void Push(T something)
	{
		howMany++;
		Node* newNode = new Node(something, pointing);
		pointing = newNode;
		
	}
	void Pop()
	{
		Node* top = pointing;
		if (top == NULL)
		{
			cout << "STACK IS EMPTY " << endl;
			return;
		}
		howMany--;
		Node* node = pointing;
		T anything = pointing->anything;
		pointing = pointing->nextNode;

		delete node;
	
	}


};


int main()
{
	Stack<string> stack;
	stack.Push("AAAAA");
	stack.Push("BBBBBB");
	stack.Push("CCC");
	stack.Push("DDDD");
	stack.Pop();
	stack.Pop();

	return 0;
}
