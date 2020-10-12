
#include <iostream>
#include <new>


class LinkedList
{
private:


	class Node {
	public:
		int value;
		Node* nextNode;
	};

	void valid(int count);
	int HowMany;
	Node* Head = new Node;

public:
	LinkedList();
	int Get(int indexNum);
	void AddValue(int number);
	void DeleteIndex(int number);
	int HowManyElement();
	void ShowAll();

};
