//Program to test the various operations on an ordered linked list

#include "stdafx.h"
#include <iostream>
#include "orderedLinkedList.h"
 
using namespace std;
 
int main()
{
    orderedLinkedList<int> list1, list2, newList;        //Line 1
    int num;                                    //Line 2

    cout << "Line 3: list1: Enter numbers ending "
         << "with -999." << endl;               //Line 3
    cin >> num;                                 //Line 4

    while (num != -999)                         //Line 5
    {
        list1.insert(num);                      //Line 6
        cin >> num;                             //Line 7
    }

    cout << endl;                               //Line 8

	cout << "Line 3: list2: Enter numbers ending "
         << "with -999." << endl;               //Line 3
    cin >> num;                                 //Line 4

    while (num != -999)                         //Line 5
    {
        list2.insert(num);                      //Line 6
        cin >> num;                             //Line 7
    }

    cout << endl;

    cout << "Line 9: list1: ";                  //Line 9
    list1.print();                              //Line 10
    cout << endl;                               //Line 11

    cout << "Line 13: list2: ";                 //Line 13
    list2.print();                              //Line 14
    cout << endl;                               //Line 15

	newList.mergeLists(list1, list2);
	cout << "Printing newList." << endl;
	newList.print();
	cout <<endl << "Printing list1." << endl;
	list1.print();
	cout << endl << "Printin list2. " << endl;
	list2.print();
	cout << endl;

    return 0;					
}



