// modifedBubbleSort.cpp : Defines the entry point for the console application.
//Manjinder Singh
//CMPSC 261-2976, Spring 2014
//Assignment 07
//Page 1302. Problem 16
//I'm using visual studio, and I include all the required header files with the stdafx.h file
//I assumed that the modifiedBubbleSort would be working with integer data type lists.
//I assumed that the three sorts would be working with integer data type lists.
//I decided to use the lined lists for the mergeSort since it was already coded and supplied in the chapter 18 source codes.
//I decided to use two gloabl variables (itemAssignments & itemComparsions) that would be incremented each time something is assigned or compared.

#include "stdafx.h"
#include "unorderedLinkedList.h"

using namespace std;

void modifiedBubbleSort(int list[], int lenght);
void printList(int list[], int size);
void quickSort(int list[], int length);
void recQuickSort(int list[], int first, int last);
int partition(int list[], int first, int last);
void swap(int list[], int first, int second);
void insertionSort(int list[], int length);
int itemAssignments, itemComparsions; //global variables to keep track of the itemsAssignments and itemComparsions in quickSort and insertionSort.

int main()
{
	int const size = 10000;
	int list1[size], list2[size];
	unorderedLinkedList<int> list3;

	srand(time(NULL));
	for (int index = 0; index < size; index++) //for loop to assign numbers to the three lists
	{
		list1[index] = ((rand() % 15 + 1) * 20 + 5) / 2 - 3;
		list2[index] = list1[index];
		list3.insertLast(list1[index]);
	}
	
	cout << "Starting to sort." << endl;
	//printList(list, size);
	//modifiedBubbleSort(list1, size);
	//printList(list, size);
	quickSort(list1, size);
	cout << "number of item assignment in quick sort is " << itemAssignments << endl;
	cout << "Number of item comparsions in quick sort is " << itemComparsions << endl;
	itemAssignments = 0;
	itemComparsions = 0;
	insertionSort(list2, size);
	cout << "number of item assignment in insertion sort is " << itemAssignments << endl;
	cout << "Number of item comparsions in insertion sort is " << itemComparsions << endl;
	list3.setitems(); //intalizes the variables itemAssignments and itemComparsions to 0 in the class
	list3.mergeSort();
	cout << "number of item assignment in merge sort is " << list3.getAssignments() << endl;
	cout << "Number of item comparsions in merge sort is " << list3.getComparsions() << endl;
	//printList(list1, size);
	cout << "done." << endl;
	return 0;
}

void modifiedBubbleSort(int list[], int length)
{
	bool isSorted = false;

	for (int iteration = 1; (iteration < length) && !isSorted; iteration++)
	{
		isSorted = true;

		for (int index = 0; index < length - iteration; index++)
		{
			if (list[index] > list[index + 1])
			{
				int temp = list[index];
				list[index] = list[index + 1];
				list[index + 1] = temp;
				isSorted = false;
			}
		}
	}
}

void printList(int list[], int size)
{
	int index = 0;
	do
	{
		cout << list[index];
		index++;
		if (index % 10 == 0)
			cout << endl;
		else
			cout << " ";
	}
	while (index < size);
	cout << endl;
}

void quickSort(int list[], int length)
{
    recQuickSort(list, 0, length - 1);
} //end quickSort

void recQuickSort(int list[], int first, int last)
{
    int pivotLocation;

    if (first < last)
    {
        pivotLocation = partition(list, first, last);
		itemAssignments += 1;
        recQuickSort(list, first, pivotLocation - 1);
        recQuickSort(list, pivotLocation + 1, last);
    }
	itemComparsions += 1;
} //end recQuickSort

int partition(int list[], int first, int last)
{
    int pivot;

    int index, smallIndex;

    swap(list, first, (first + last) / 2);

    pivot = list[first];
    smallIndex = first;
	itemAssignments += 2;

    for (index = first + 1; index <= last; index++)
	{
        if (list[index] < pivot)
        {
            smallIndex++;
            swap(list, smallIndex, index);
        }
		itemComparsions += 1;
	}

    swap(list, first, smallIndex);

    return smallIndex;
} //end partition

void swap(int list[], int first, int second)
{
    int temp;

    temp = list[first];
    list[first] = list[second];
    list[second] = temp;
	itemAssignments += 3;
} //end swap

void insertionSort(int list[], int length)
{
    for (int firstOutOfOrder = 1; firstOutOfOrder < length;
                                  firstOutOfOrder++)
	{
        if (list[firstOutOfOrder] < list[firstOutOfOrder - 1])
        {
            int temp = list[firstOutOfOrder];
            int location = firstOutOfOrder;
			itemAssignments += 2;

            do
            {
                list[location] = list[location - 1];
				itemAssignments += 1;
                location--;
				itemComparsions += 1;
            } while(location > 0 && list[location - 1] > temp);

            list[location] = temp;
			itemAssignments += 1;
        }
		itemComparsions += 1;
	}
} //end insertionSort