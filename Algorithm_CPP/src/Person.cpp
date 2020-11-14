#include "Person.h"


template<class genType, int size>
Person<genType,size>::Person() 
{
    printf("Person Object Created\n");
    strcpy(FirstName, "");
    strcpy(LastName, "");
    int Id = 0;
}