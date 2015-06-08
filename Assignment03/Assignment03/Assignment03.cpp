// Assignment03.cpp : Defines the entry point for the console application.
//Manjinder Singh
//CMPSC 261-2976, Spring 2014
//Assignment 03
//Page 866, Problem 12
//
#include <iostream>
#include "unorderedSetType.h"
#include "stdafx.h"

using namespace std;


int main()
{
	unorderedSetType intList(25);

	int number;

	cout << "Enter 8 integers: ";

	for (int count = 0; count < 8; count++)
	{
		cin >> number;
		intList.insertEnd(number);
	}

	cout << endl;
	cout << "intList: ";
	intList.print();
	cout << endl;

    cout << "Inserting an item..." << endl;
	intList.insertAt(0, 6);

    cout << "Replacing an item..." << endl;
	intList.replaceAt(3, 4);

	cout << "Inserting an item..." << endl;
	intList.insertAt(0, 15);

	cout << "intList: ";
	intList.print();


	return 0;
}
