#ifndef ENTITY_H
#define ENTITY_H
#include <iostream>
#include <stdio.h>


using String = std::string;
class Entity  
{
    private:
        String m_Name;

    public:
        Entity(): m_Name("Unknown") {}
        Entity(const String& name) : m_Name(name) {}
        const String& GetName() const { return m_Name;}
};
#endif