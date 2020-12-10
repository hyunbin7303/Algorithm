
#ifndef PERSON_H
#define PERSON_H

// A template is a mechanism that allows us to use types as parameters for a class. 
template<class genType, int size = 50>
class Person
{
    genType storage[size];
    private:
        char FirstName[50];
        char LastName[50];
        int Id;

    public:
        Person();
        void swap(genType& element1, genType& element2)
        {
            genType tmp = element1;
            element1 = element2;
            element2 = tmp;
        }
};



#endif