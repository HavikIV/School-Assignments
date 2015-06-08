// Author: Manjinder Singh
// This program is to convert gien length in feet and inches to centimeters

#include <iostream> // HEADER FILE

using namespace std;

// NAMED CONSTANTS
const double CENTIMETERS_PER_INCH = 2.54;
const int INCHES_PER_FOOT = 12;

int main()
{
	//DECLARE VARIABLES
	int feet, inches, totalInches;
	double centimeters;

	cout << "Enter the length in feet and inches separated by a space: " //promts the user to input length
		<< endl;
	cin >> feet >> inches; // gets the input
	cout << endl;
	cout << "You entered the length " << feet << " ft and " << inches << " inches ." << endl; //displays the users input before preceding with the program

	totalInches = (feet * INCHES_PER_FOOT) + inches; //converts feet to inches and then adds the inches from the user input to get total inches
	centimeters = totalInches * CENTIMETERS_PER_INCH; //onverts total inches to centimeters

	cout << "The length in centimeters is " << centimeters << "." << endl; //displays the total centimeters
	_sleep(5000); //makes the computer sleep for 5 seconds so i can see the full results

	return 0;
}