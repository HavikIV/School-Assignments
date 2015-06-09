// 04102014.cpp : Defines the entry point for the console application.
//Manjinder Singh
//modifiedBubbleSort

#include "stdafx.h"
#include <iostream>
#include <cstdlib>
#include <ctime>

using namespace std;

void bubbleSort(int sortArray[], int aSize);
void printArray(int newArray[], int aSize);
void modifiedBubbleSort(int list[], int length); //i assumed the list is gonna be an int type
int linearSearch(int list[], int size, int item);
int binarySearch(int list[], int size, int item);
void swap(int list[], int first, int second);
void quickSort(int list[], int length);
void recQuickSort(int list[], int first, int last);
int partition(int list[], int first, int last);

int main()
{
	int const arraySize = 100000;
	int number[arraySize];

	srand(time(NULL)); //seed for random number generator
	for (int index = 0; index < arraySize; index++)
		number[index] = rand() % 1000 + 1;

	//printArray(number, arraySize);
	//cout << endl << "1st bubblesort..." << endl;
	//bubbleSort(number, arraySize);
	///printArray(number, arraySize);
	//cout << endl << "2nd BubbleSort..." << endl;
	//modifiedBubbleSort(number, arraySize);
	//printArray(number, arraySize);
	//int index = linearSearch(number, arraySize, 500);
	quickSort(number, arraySize);
	int index = binarySearch(number, arraySize, 500);
	if (index != -1)
		cout << "The Item is at the index " << index << endl;
	else
		cout << "The Item is not in the list." << endl;

	return 0;
}

void bubbleSort(int sortArray[], int aSize)
{
	int swap;
	for (int left = 0; left < aSize - 1; left++)
		for (int right = left +1; right < aSize; right++)
			if (sortArray[left] > sortArray[right])
			{
				swap = sortArray[left];
				sortArray[left] = sortArray[right];
				sortArray[right] = swap;
			}///end swap
}//end bubbleSort

void printArray(int newArray[], int aSize)
{
	int index1 = 0;
	do 
	{
		cout << newArray[index1];
		index1++;
		if (index1 % 15 == 0)
			cout << endl;
		else
			cout << " ";
	}
	while (index1 < aSize);
	cout << endl;
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

int linearSearch(int list[], int size, int item)
{
	for (int index = 0; index < size - 1; index++)
	{
		if (list[index] == item)
			return index;
	}

	return -1;
}

int binarySearch(int list[], int size, int item)
{
	int first = 0;
    int last = size - 1;
    int mid;

    bool found = false;

    while (first <= last && !found)
    {
        mid = (first + last) / 2;

        if (list[mid] == item)
            found = true;
        else if (list[mid] > item)
            last = mid - 1;
        else
            first = mid + 1;
    }

    if (found)
        return mid;
    else 
        return -1;
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
        recQuickSort(list, first, pivotLocation - 1);
        recQuickSort(list, pivotLocation + 1, last);
    }
} //end recQuickSort

int partition(int list[], int first, int last)
{
    int pivot;

    int index, smallIndex;

    swap(list, first, (first + last) / 2);

    pivot = list[first];
    smallIndex = first;

    for (index = first + 1; index <= last; index++)
        if (list[index] < pivot)
        {
            smallIndex++;
            swap(list, smallIndex, index);
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
} //end swap