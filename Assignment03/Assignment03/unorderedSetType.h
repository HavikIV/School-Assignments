//Manjinder Singh
//CMPSC 261-2976, Spring 2014
//Assignment 03
//Page 866, Problem 12

#ifndef H_unorderedSetType
#define H_unorderedSetType
 
#include "unorderedArrayListType.h"
#include "stdafx.h"

class unorderedSetType: public unorderedArrayListType
{
public:
    void insertAt(int location, int insertItem);
    void insertEnd(int insertItem);
    void replaceAt(int location, int repItem);
    

    unorderedSetType(int size = 100);
      //Constructor
}; 


#endif