// FootballTickets.cpp : Defines the entry point for the console application.
// Manjinder Singh
// CMPSC 261 2976
// Chapter 3 Programming Exercise 5
//

#include "stdafx.h"
#include <iostream>
#include <fstream>
#include <iomanip>

using namespace std;

int main()
{
	ifstream inFile;
	ofstream outFile;

	inFile.open("E:\\Users\\Havik\\Documents\\Visual Studio 2012\\Projects\\FootballTickets\\Debug\\inData.txt");
	outFile.open("E:\\Users\\Havik\\Documents\\Visual Studio 2012\\Projects\\FootballTickets\\Debug\\outData.txt");

	int ticketPrice, ticketsSold;
	double totalSale;

	cout << "Beginning processing the data..." << endl;

	//for (int count = 0; count < 4; count++)
	while (!inFile.eof()) //a while loop that runs as long as we haven't reached the end of file
	{
		inFile >> ticketPrice;
		inFile >> ticketsSold;

		totalSale = ticketPrice * ticketsSold;

		outFile << fixed << showpoint << setprecision(2);
		outFile << "The total number of sold tickets is " << ticketsSold << " and the total sale is $ " << totalSale << endl;
	}

	cout << "Finished processing the data." << endl;

	inFile.close();
	outFile.close();

	return 0;
}

