//implents the class Lottery

#include "Lottery.h"
#include <iostream>
#include <cstdlib>	//need for rand and srand
#include <ctime>	//need for the time() to truly get a random number otherwise the number will be the same everytime

using namespace std;

int Lottery::makeLottoTicket(int regularNumbers, int sixthNumber)
{
	int ticket[6];
	int sixthNum;
	bool whilecheck;

	for (int i = 0; i < 5; i++)
	{
		whilecheck = true;
		while (whilecheck)
		{
			srand((unsigned)time(0));
			ticket[i] = rand() % regularNumbers + 1; //generate a random number between 1 and the regularNumber
			if (i == 0)
				whilecheck = false;
			else if (ticket[i] != ticket[i - 1]) //makes sure there are no repeat numbers in the array
				whilecheck = false;
		}			
	}

	ticket[5] = rand() % sixthNumber + 1; //generates the Mega/Power Number
	modifiedBubbleSort(ticket, 5);	//sorts the first five numbers of the array.

	return *ticket;
}

void Lottery::modifiedBubbleSort(int list[], int length)
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

void Lottery::generateTickets(int numberOfTickets, string LotteryType)
{
	for (int i = 0; i < numberOfTickets; i++)
	{
		if (LotteryType == "SuperLotto")
			arrayOfTickets[i] = makeLottoTicket(47, 27);
		else if (LotteryType == "MegaMillions")
			arrayOfTickets[i] = makeLottoTicket(75, 15);
		else
			arrayOfTickets[i] = makeLottoTicket(59, 35);
	}
}

void Lottery::clearArray()
{
	for (int i = 0; arrayOfTickets[i] != NULL; i++)
	{
		arrayOfTickets[i] = NULL;
	}
}

void Lottery::printArray()
{
	for (int i = 0; arrayOfTickets[i] != NULL; i++)
	{
		cout << arrayOfTickets[i] << " ";
	}
	cout << endl;
}

Lottery::Lottery()
{
	arrayOfTickets = new int[5];
}
