#include "LinkedList.h"


void LinkedList::valid(int count)
{
	if (count >= LinkedList::HowMany) {
		throw "VALIDATION ERROR . CHECK INDEX NUMBER. ";
	}

}

// Default Constructor 
LinkedList::LinkedList()
{
	Head->nextNode = NULL;
	HowMany = 0;
}

int LinkedList::Get(int indexNum)
{

	try {
		valid(indexNum);
	}
	catch (const char* message) {
		std::cout << message << std::endl;
		return -1;
	}
	Node* temp = Head;
	for (int i = 0; i <= indexNum; i++) {
		temp = temp->nextNode;
	}
	return temp->value;
}

void LinkedList::AddValue(int number)
{
	Node* newNode = new Node;
	newNode->value = number;
	newNode->nextNode = NULL;
	if (Head->nextNode == NULL) {
		Head->nextNode = newNode;
	
	}
	else {
		Node* temp = Head; 
		while (temp->nextNode != NULL) {
			temp = temp->nextNode;
		}
		temp->nextNode = newNode;
	}
	HowMany++;
}

void LinkedList::DeleteIndex(int Index)
{
	
	try {
		valid(Index);
	}
	catch (const char* message) {
		std::cout << message << std::endl;
		return;
	}
	Node* temp = Head;
	Node* remove = Head;
	
	for (int i = 0; i < Index; i++) {
		temp = temp->nextNode;
		remove = remove->nextNode;
	}
	remove = remove->nextNode;
	temp->nextNode = remove->nextNode;
	remove->nextNode = NULL;
	delete remove;
	HowMany--;
}

int LinkedList::HowManyElement()
{
	return HowMany;
}

void LinkedList::ShowAll()
{
	Node* LL = Head->nextNode;
	while (LL) {
		std::cout << LL->value << std::endl;
		LL = LL->nextNode;
	}
	std::cout << std::endl;
}
