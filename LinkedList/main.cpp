

#include "LinkedList.h"

int main() {

	LinkedList LL;

	LL.AddValue(40);
	LL.AddValue(50);
	LL.AddValue(60);
	LL.AddValue(70);
	LL.AddValue(80);
	
	for (int i = 0; i < LL.HowManyElement(); i++) {
		std::cout << LL.Get(i) << std::endl;
	}
	std::cout << std::endl;
	LL.DeleteIndex(3);


	LL.ShowAll();



	return 0; 
}
