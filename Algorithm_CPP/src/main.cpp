#include "../inc/shraed_lib.h"
#include "../inc/MyAlgorithm.h"
#include "../inc/Entity.h"
#include "../inc/Box.h"
#include "../inc/Person.h"




template <class T, size_t N = 10>
struct my_array{
    T arr[N];
};

template <typename T = int>
class Foo{

};
 template<class genType>
    void swap(genType& el1, genType& el2) {
    genType tmp = el1; el1 = el2; el2 = tmp;
}

int main()
{
    Foo<> me;//he template arguments must be present but you can leave them empty.


    int a = 20;
    int b = 30;
    Entity e0();
    MyAlgorithm m1;
    // int num = m1.BinarySearch(20,30);
    //  MyAlgorithm test1();
    // int num = test1.BinarySearch(10, 3);
    // strcpy(p1, "KEVIN");
    Box box1(1, 2, 3);
    Box box2{ 2, 3, 4 };
    Box box3; // C2512: no appropriate default constructor available
    Entity("Object 1", 100, 2000);


    Person<int> intObj1; // Use the default size;
    Person<int, 50> intObj2;
    Person<float, 123> floatObj;
    swap(intObj1,intObj2);
    // intObj1.swap(intObj2, floatObj);

    system("pause");
    return 0;
}