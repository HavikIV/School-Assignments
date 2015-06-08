// Assingment4.cpp : Defines the entry point for the console application.
/** Manjinder Singh
*  Assingment4
*  CMPSC 205-3033
*  Due Date November 8 2013
*  This program is to calculate the amount of characters in a line and the number of lines on a page given the size.
*/

#include "stdafx.h"
#include <iostream>
#include <iomanip>

using namespace std;

const double PI = 3.1419;
//function prototypes so i don't have to make these fuctions before the main function
double rectangle(double l, double w);
double circle(double r);
double cylinder(double bR, double h);

int main()
{
	double radius;
	double height;
	int choice;
	double length, width;

	cout << fixed << showpoint << setprecision(2) << endl;
	cout << "This program can calculate the area of a rectangle, the area of a circle, and the area of a cylinder." << endl;
	cout << "To run the program enter: " << endl;
	cout << "1: To find the area of a rectangle." << endl;
	cout << "2: To find the area of a circle." << endl;
	cout << "3: To find the area of a cylinder." << endl;
	cout << "-1: To terminate the program." << endl;
	cin >> choice;
	cout << endl;

	while (choice != -1)
	{
		switch (choice)
		{
		case 1:
			cout << "Enter the length of the rectangle: ";
			cin >> length;
			cout << endl;
			cout << "Enter the width of the rectangel: ";
			cin >> width;
			cout << endl;

			cout << "Area = " << rectangle(length, width) << endl << endl;
			break;

		case 2:
			cout << "Enter the radius of the circle: ";
			cin >> radius;
			cout << endl;

			cout << "Area = " << circle(radius) << endl << endl;
			break;

		case 3:
			cout << "Enter the radius of the base of the cylinder: ";
			cin >> radius;
			cout << endl;
			cout << "Enter the height of the cylinder: ";
			cin >> height;
			cout << endl;

			cout << "Area = " << cylinder(radius, height) << endl << endl;
			break;

		default:
			cout << "Invalid choice!" << endl << endl;
			break;
		}
		cout << "This program can calculate the area of a rectangle, the area of a circle, and the area of a cylinder." << endl;
		cout << "To run the program enter: " << endl;
		cout << "1: To find the area of a rectangle." << endl;
		cout << "2: To find the area of a circle." << endl;
		cout << "3: To find the area of a cylinder." << endl;
		cout << "-1: To terminate the program." << endl;
		cin >> choice;
		cout << endl;
	}

	return 0;
}

double rectangle(double l, double w)
{
	return l * w;
}

double circle(double r)
{
	return PI * r * r;
}

double cylinder(double bR, double h)
{
	return ((2 * PI) * bR * bR) + ((2 * PI) * bR * h);
}

