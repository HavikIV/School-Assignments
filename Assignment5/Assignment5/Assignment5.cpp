/** Manjinder Singh
*  Assingment5
*  CMPSC 205-3033
*  Due Date November 15 2013
*/

#include "stdafx.h"
#include <iostream>
#include <Windows.h>
#include <cstring>
#include <string.h>
#include <iomanip>


using namespace std;

//function prototypes
int tallyVotes(int refernceArray[5]);
void echoFunction(char first[], char second[], char third[], char fourth[], char fifth[], int refernceArray[], int tally);
int determineWinner(int refernceArray[5]);


int main()
{
	char firstCandidate[20];
	char secondCandidate[20];
	char thirdCandidate[20];
	char fourthCandidate[20];
	char fifthCandidate[20];
	int list_of_number_of_votes[5];
	int temp = 0;

	cout << "This program is to help determine who is the winner of the local election given the five candidates and the number of votes each received." << endl;
	//get the inputs
	for (int candidates = 0; candidates < 5; candidates++)
		{
			cout << "Please enter the last name of the candidate: ";
			if (candidates == 0)
				cin >> firstCandidate;
			else if (candidates == 1)
				cin >> secondCandidate;
			else if (candidates == 2)
				cin >> thirdCandidate;
			else if (candidates == 3)
				cin >> fourthCandidate;
			else if (candidates == 4)
				cin >> fifthCandidate;
			cout << endl;
			cout << "Please enter the number of votes the candidate recieved: ";
			cin >> temp;
			cout << endl;
			list_of_number_of_votes[candidates] = temp;
		}

	//get the total amount of votes
	int tally = tallyVotes(list_of_number_of_votes);

	//echo the inputs
	echoFunction(firstCandidate, secondCandidate, thirdCandidate, fourthCandidate, fifthCandidate, list_of_number_of_votes, tally);
	cout << setw(20) << left << "Total" << setw(25) << left << tally << endl;

	//find the winner
	temp = determineWinner(list_of_number_of_votes);

	//display the winner
	if (temp == 0)
				cout << "The winner of the election is " << firstCandidate << ".";
			else if (temp == 1)
				cout << "The winner of the election is " << secondCandidate << ".";
			else if (temp == 2)
				cout << "The winner of the election is " << thirdCandidate << ".";
			else if (temp == 3)
				cout << "The winner of the election is " << fourthCandidate << ".";
			else if (temp == 4)
				cout << "The winner of the election is " << fifthCandidate << "."; 

	Sleep(10000);

	return 0;
}

int tallyVotes(int refernceArray[5])
{
	int totalVotes = 0;
	for (int i = 0; i < 5; i++)
		totalVotes = totalVotes + refernceArray[i];

	return totalVotes;
}

int determineWinner(int refernceArray[5])
{
	int temp = 0;
	for (int i = 0; i < 5; i++)
	{
		if (refernceArray[temp] < refernceArray[i])
			temp = i;
	}

	return temp;
}

void echoFunction(char first[], char second[], char third[], char fourth[], char fifth[], int refernceArray[], int tally)
{
	cout << setw(20) << left << "Candidate" << setw(20) << left << "Votes Received" << setw(20) << left << "% of Total Votes" << endl;
	cout << fixed << showpoint << setprecision(2);
	for (int temp = 0; temp < 5; temp++)
		{
			if (temp == 0)
				cout << setw(20) << left << first << setw(25) << left << refernceArray[temp] << setw(25) << left <<  (static_cast <double> (refernceArray[temp]) / tally) * 100 << endl;
			else if (temp == 1)
				cout << setw(20) << left << second << setw(25) << left << refernceArray[temp] << setw(25) << left <<  (static_cast <double> (refernceArray[temp]) / tally) * 100 << endl;
			else if (temp == 2)
				cout << setw(20) << left << third << setw(25) << left << refernceArray[temp] << setw(25) << left <<  (static_cast <double> (refernceArray[temp]) / tally) * 100 << endl;
			else if (temp == 3)
				cout << setw(20) << left << fourth << setw(25) << left << refernceArray[temp] << setw(25) << left <<  (static_cast <double> (refernceArray[temp]) / tally) * 100 << endl;
			else if (temp == 4)
				cout << setw(20) << left << fifth << setw(25) << left << refernceArray[temp] << setw(25) << left <<  (static_cast <double> (refernceArray[temp]) / tally) * 100 << endl;
		}
}