#include "../inc/shraed_lib.h"
#include "../inc/Person.h"
#include "../inc/MyAlgorithm.h"
#include "../inc/Entity.h"
#include "../inc/FileManager.h"

#include <vector>

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

    fstream afile;
    afile.open("fileName.txt", ios::out | ios:: in);

    FileManager fm{};
    fm.readFromFile(afile);
    // Stored to the objects?.....Entity object?
    Entity e1("Object 1", 100, 2000);
    Entity e2("Object 2", 100, 2000);
    Entity e3("Object 3", 100, 2000);
    Entity e4("Object 4", 100, 2000);


    std::vector<Entity> e_list;
    e_list.insert(e_list.begin(), e1);
    e_list.insert(e_list.begin(), e2);
    e_list.insert(e_list.begin(), e3);
    e_list.insert(e_list.begin(), e4);
    std::cout << "The size of Entities :" << e_list.size() <<std::endl;
    //Call Algorithm class. 
    MyAlgorithm m1{};
    m1.BinarySearch(3, 3);
    double spaceComResult = m1.SpaceComplexity();
    double timeComResult = m1.TimeComplexity();

    Foo<> me;//he template arguments must be present but you can leave them empty.
    // Person<int> intObj1(); // Use the default size;
    // Person<int, 50> intObj2();
    // Person<float, 123> floatObj();
    system("pause");
    return 0;
}