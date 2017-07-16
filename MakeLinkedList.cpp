// File          : MakeLinkedList.cpp
// Programmer    : Kevin Park
// Date          : 2017 / 7  / 15
// Description   : I made linkedlist to practice it. 
//                 It is not doubly linked list, so there is no tail. 

#include <iostream>
#include <new>
class Node
{
	friend class List; // List class can access to private value in the Node class.

private:
	Node *next;
	int data;

public:
	Node() {} ;
	Node(int value);
	Node(int value, Node* next);
	~Node() {};

	//Getters
	int getData(void) { return data; }
	Node* getNext(void) { return next; }
};


class List
{

private:
	Node *Head;


public:
	List() { Head = NULL; };
	List(Node* insertNode)
	{
		Head = NULL;

	}
	List(int data);
	~List() {};


	void addNode	(Node **Head, int number);
	void deleteNode	(Node** Head, int value);
	void printout(Node *Head);
};

Node::Node(int value)
{
	data = value;
	next = NULL;

}

List::List(int data) // Constructor 
{
	Head = NULL;

}

void List::addNode(Node **Head, int number)
{
	Node *Temp = NULL;
	Node *TempNext = NULL;
	Node *newNode = new Node(number);
	newNode->next = NULL;
	if (newNode == NULL)
	{
		std::cout << "Error! No more memory ! \n" << std::endl;
		return;
	}

	if (*Head == NULL)
	{
		*Head = newNode;
	}
	else if (number < (*Head)->data)
	{
		newNode->next = *Head;
		(*Head) = newNode;
	}
	else
	{
		Temp = *Head;
		TempNext = Temp->next;

		while (TempNext != NULL)
		{
			if (TempNext->data > newNode->data)
			{
				break;
			}
			Temp = TempNext;
			TempNext = TempNext->next;
		}
		newNode->next = TempNext;
		Temp->next = newNode;
	}
}


void List::deleteNode(Node** Head, int value)
{
	if (*Head == NULL)
	{
		std::cout << "THERE IS NOTHING " << std::endl;
	}
	else 
	{
		Node* cur = *Head;
		Node* befCur = NULL;
		for (Node* ptr = *Head; ptr != NULL; ptr = ptr->next)
		{
			befCur = cur; 
			cur = ptr;
			if (cur->data == value)
			{
				if (befCur == *Head && cur == *Head)
				{
					*Head = cur->next;
				}
				else
				{
					befCur->next = cur->next;
				}
				delete cur;
				return;
			}
		}
	}
}



void List::printout(Node *Head)
{
	if (Head == NULL)
	{
		std::cout << "This LinkedList is empty! " << std::endl;
		return;
	}
	std::cout << "<<LINKED LIST " << std::endl;
	while (Head != NULL)
	{
		std::cout << Head->data << std::endl;
		Head = Head->next;
	}
}


int main()
{
	Node* A = NULL;
	List* LinkedList = NULL;
	LinkedList->addNode(&A, 30);
	LinkedList->addNode(&A, 40);
	LinkedList->addNode(&A, 50);
	LinkedList->addNode(&A, 60);
	LinkedList->addNode(&A, 25);
	LinkedList->addNode(&A, 42);
	LinkedList->printout(A);


	std::cout << "After Deletion ===" << std::endl;
	LinkedList->deleteNode(&A, 50);
	LinkedList->printout(A);

	return 0;
}
