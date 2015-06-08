// This a practice program to determine
// the sales of tickes and donataions to charity
// Manjinder Singh
// CMPSC 205-3033
// 9/15/13
// Chapter 3 Practice Example 1

//including the required headerfiles
#include <iostream> //header for cout and cin
#include <string> //header for string
#include <iomanip> //header for setfill, and setw manipulators

using namespace std;

int main()
{
	//decalring variables to use later

	string movieName;
	double adultTicketPrice, childTicketPrice, percentDonation, grossAmount, amountDonated, netSaleAmount;
	int noOfAdultTicketsSold, noOfChildTicketsSold;

	//statements to prompt input from the user

	cout << fixed << showpoint << setprecision(2); //shows the numbers to two deciaml points

	cout << "Enter the movie name: "; //prompts the user to enter movie name
	getline(cin, movieName); //uses getline function to get a string as an input
	cout << endl;
	
	cout << "Enter the price of an adult ticket: "; //promts the user to enter adult ticket price
	cin >> adultTicketPrice;
	cout << endl;

	cout << "Enter the price of a child ticket: "; //prompts the user to enter child ticket price
	cin >> childTicketPrice;
	cout << endl;

	cout << "Enter the number of adult tickets sold: "; //prompts the user to enter amount of adult tickets sold
	cin >> noOfAdultTicketsSold;
	cout << endl;

	cout << "Enter the number of child tickets sold: "; //prompts the user to enter amount of child tickets sold
	cin >> noOfChildTicketsSold;
	cout << endl;

	cout << "Enter the percentage of donation: "; //prompts the user to enter the percentage to donate
	cin >> percentDonation;
	cout << endl;

	//statements to do the calcuations
	grossAmount = adultTicketPrice * noOfAdultTicketsSold + childTicketPrice * noOfChildTicketsSold;

	amountDonated = grossAmount * percentDonation / 100;

	netSaleAmount = grossAmount - amountDonated;

	//the final display statements

	cout << "_*_*_*_*_*_*_*_*_*_*_*_*_*_*_*"
		<< "_*_*_*_*_*_*_*_*_*_*_*_*_*" << endl;
	cout << setfill('.') << left << setw(35) << "Movie Name: "
		<< right << " " << movieName << endl;
	cout << left << setw(35) << "Number of Tickets Sold: "
		<< setfill(' ') << right << setw(10)
		<< noOfAdultTicketsSold + noOfChildTicketsSold << endl;
	cout << setfill('.') << left << setw(35) << "Gross Amount: "
		<< setfill(' ') << right << " $" 
		<< setw(8) << grossAmount << endl;
	cout << setfill('.') << left << setw(35)
		<< "Percentage of Gross Amount Donated: "
		<< setfill(' ') << right
		<< setw(9) << percentDonation << '%' << endl;
	cout << setfill('.') << left << setw(35) << "Amount Donated: "
		<< setfill(' ') << right << " $"
		<< setw(8) << amountDonated << endl;
	cout << setfill('.') << left << setw(35) << "Net Sale: "
		<< setfill(' ') << right << " $"
		<< setw(8) << netSaleAmount << endl;

	_sleep(10000);//pauses the program for 10 seconds before closing

	return 0;
}