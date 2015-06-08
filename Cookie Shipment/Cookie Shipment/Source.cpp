/* Manjinder Singh
*  Cookie Shipment program
*  CMPSC 205-3033
*  Due Date October 9 2013
*  This program is to calculate the required amount of boxes and containers need to make shipments of cookies
*/

#include <iostream>

using namespace std;

int main()
{
	//declaring variables
	int cookieAmount = 0;
	int cookiesInBox = 0;
	int boxesInContainer = 0;
	int cookieBoxes, cookieContainers;

	//ask for input from the user
	cout << "Please enter the total amount of cookies: ";
	cin >> cookieAmount; 
	cout << endl;
	while (0 >= cookiesInBox || cookiesInBox > 24)
	{
		cout << "How many cookies to a box? (max is 24): ";
		cin >> cookiesInBox;
		cout << endl;
		if (0 >= cookiesInBox || cookiesInBox > 24)
			cout << "You entered a number either less than 0 or more than 24." << endl;
	}
	while (0 >= boxesInContainer || boxesInContainer > 75)
	{
		cout << "How many boxes to a container? (max is 75): ";
		cin >> boxesInContainer;
		cout << endl;
		if (0 >= boxesInContainer || boxesInContainer > 75)
			cout << "You entered a number either less than 0 or more than 75." << endl;
	}

	//calculate the cookie boxes and containers
	cookieBoxes = cookieAmount / cookiesInBox;
	cookieContainers = cookieBoxes / boxesInContainer;

	//displays the results
	cout << "We are going to ship " << cookieBoxes - (cookieBoxes % boxesInContainer) << " box(es) of cookies in " << cookieContainers << " container(s)." << endl;
	cout << "The total amount of leftover cookies not in boxes is " << (cookieAmount % cookiesInBox) << "." << endl;
	cout << "The total amount of leftover boxes is " << (cookieBoxes % boxesInContainer) << "." << endl;
	cout << "The total amount of cookies not shipped is " << (cookieAmount % cookiesInBox) + ((cookieBoxes % boxesInContainer) * cookiesInBox) << "." << endl;
	return 0;
} //exit main