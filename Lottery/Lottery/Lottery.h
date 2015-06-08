//This file is to design the class Lottery
//Manjinder Singnh
//September 25, 2014

#include <string>

using namespace std;

class Lottery
{
public:
	int makeLottoTicket(int, int);
		//function to make a ticket given the ranges for both regular numbers and the Mega/Power number.
		//the ticket will be stored in a array and the first 5 numbers will be ordered in acsending order
		//will return the array

	void generateTickets(int, string);
		//function to make the amount of tickets requested of the type of tickets wanted
		//will call the makeLottoTicket function withiin a loop and with each interation of the loop the return array will be stored in another array.

	void clearArray();
		//function to clear the array in which the tickets are stored

	void printArray();
		//function to print the tickets to the screen

	void modifiedBubbleSort(int[], int);
		//bubblesort to sort the array, need to sort the fisrt 5 numbers in the array.

	Lottery();
	//default constructor
	//make the arrayOfTickets;

private:
	int* arrayOfTickets;
	int getArry;
};