#ifndef ENTITY_H
#define ENTITY_H
#include <iostream>
#include <stdio.h>


using String = std::string;
class Entity  
{
    private:
        String m_Name;
    protected:
        char dataMember1[20];
        int dataMember2;
        double dataMember3;
    public:
        Entity(): m_Name("Unknown") {}
        Entity(const String& name) : m_Name(name) {}
        Entity(char *s = "", int i = 0, double d = 1){
            strcpy(dataMember1, s);
            dataMember2 = i;
            dataMember3 = d;
        }



        const String& GetName() const { return m_Name;}


};

// template<class genType>
// class genClass{
//     genType storage[50];
// }

#endif