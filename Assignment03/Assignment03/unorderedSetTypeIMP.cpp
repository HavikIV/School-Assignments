//Manjinder Singh
//CMPSC 261-2976, Spring 2014
//Assignment 03
//Page 866, Problem 12

#include <iostream>
#include "unorderedSetType.h"
#include "stdafx.h"

using namespace std;

void unorderedSetType::insertAt(int location, int insertItem)
{
	if (location < 0 || location >= maxSize)
		cout << "The position of the item to be inserted is out of range." << endl;
	else if (length >= maxSize) //list is full
		cout << "Cannot insert in a full list" << endl;
	else
	{
		int found;
		found = seqSearch(insertItem);
		if (found == -1)
		{
			for (int i = length; i > location; i--)
				list[i] = list[i - 1]; //move the elements down
			list[location] = insertItem; //insert the item at the specifed position
			length++;
		}
		else
			cout << "The list already contains the item to be inserted." << endl;
	}
}//end insertAt

void unorderedSetType::insertEnd(int insertItem)
{
	if (length >= maxSize)  //the list is full
        cout << "Cannot insert in a full list." << endl;
    else
    {
		int found = seqSearch(insertItem);
		if (found == -1)
		{
			list[length] = insertItem; //insert the item at the end
			length++; //increment the length
		}
		else
			cout << "The item to be inserted already exists in the list." << endl;
    }
}//end insertEnd

void unorderedSetType::replaceAt(int location, int repItem)
{
    if (location < 0 || location >= length)
        cout << "The location of the item to be "
             << "replaced is out of range." << endl;
    else
	{
		int found = seqSearch(repItem);
		if (found == -1)
			list[location] = repItem;
		else
			cout << "Cannot replace item since it already exists in the list." << endl;
	}
} //end replaceAt

unorderedSetType::unorderedSetType(int size): unorderedArrayListType(size)
{
}  //end constructor