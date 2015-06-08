/* Manjinder Singh
*  Characters in a Line program
*  CMPSC 205-3033
*  Due Date October 18 2013
*  This program is to calculate the amount of characters in a line and the number of lines on a page given the size.
*/

#include "stdafx.h"
#include <iostream>
#include <Windows.h>

using namespace std;

int main()
{
	//declaring variables
	double paperLength, paperWidth, leftMargin, rightMargin, topMargin, bottomMargin, lineSize;
	int pointSize, number_of_characters_in_a_line, number_of_lines;
	char spacing;

	//prompt the user for input
	cout << "This programm is to calculate the number of characters in a line and the number of lines given the paper size in inches."<< endl;
	cout << "Please enter the length of the paper: ";
	cin >> paperLength;
	cout << endl;
	cout << "Please enter the width of the paper: ";
	cin >> paperWidth;
	cout << endl;
	cout << "Please enter the top margin of the paper: ";
	cin >> topMargin;
	cout << endl;
	cout << "Please enter the left margin of the paper: ";
	cin >> leftMargin;
	cout << endl;
	cout << "Please enter the right margin of the paper: ";
	cin >> rightMargin;
	cout << endl;
	cout << "Please enter the bottom margin of the paper: ";
	cin >> bottomMargin;
	cout << endl;
	cout << "Please enter the point size: ";
	cin >> pointSize;
	cout << endl;
	cout << "Would you like the paper to be single or double spaced (s or d): ";
	cin >> spacing;
	cout << endl;

	//echo the user input
	cout << "You entered the paper size " << paperLength << "\" x " << paperWidth << "\", and the point size " << pointSize << "." << endl;
	cout << "You entered the margins to be at " << topMargin << "\" top, " << leftMargin << "\" left, " << rightMargin << "\" right, and " << bottomMargin << "\" bottom." << endl;

	//calculate
	lineSize = paperWidth - (leftMargin + rightMargin);
	if (spacing == 'd')
		pointSize = pointSize * 2;
	number_of_lines = (72 / (paperLength - (topMargin + bottomMargin))) * (72 / pointSize);
	number_of_characters_in_a_line = (72 / lineSize) * (72 / pointSize);

	//display the results
	cout << "The total number of characters per line is: " << number_of_characters_in_a_line << " characters." << endl;
	cout << "The total number of lines that can be printed on the paper is: " << number_of_lines << " lines." << endl;

	Sleep(10000);

	return 0;
}