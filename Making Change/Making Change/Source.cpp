// Author: Manjinder Singh
// This program is to converting total cents to half-dollars, quaters, dimes, nickels, and pennies

#include <iostream>

using namespace std;

//NAMED CONSTANTS
const int HALFDOLLARS = 50, QUATERS = 25, DIMES = 10, NICKELS = 5, PENNIES = 1;

int main()
{
	//DECLARE VARIABLES
	int cents, halfDollars, quaters, dimes, nickels, pennies;
	
	cout << "Enter the total number of cents: ";
	cin >> cents;
	cout << endl;
	cout << "You entered " << cents << " cents." << endl;

	halfDollars = cents / HALFDOLLARS;
	quaters = (cents % HALFDOLLARS) / QUATERS;
	dimes = ((cents % HALFDOLLARS) % QUATERS) / DIMES;
	nickels = (((cents % HALFDOLLARS) % QUATERS) % DIMES) / NICKELS;
	pennies = ((((cents % HALFDOLLARS) % QUATERS) % DIMES) % NICKELS) / PENNIES;

	cout << "You have " << halfDollars << " half-dollars, " << quaters << " quaters, " << dimes << " dimes, " << nickels << " nickels and, " << pennies << " pennies." << endl;
	_sleep(5000);

	return 0;
}