// File Input and Output Exercise.cpp : Defines the entry point for the console application.
// This is an exercise program to practice reading and writing to files
// Manjinder Singh

#include "stdafx.h"
#include <iostream>
#include <fstream>
#include <string>
#include <iomanip>

using namespace std;

const double PI = 3.1416;

int main()
{
	//Declare variables
	ifstream inFile;
	ofstream outFile;
	double length , width, areaRectangle, radius, areaCircle, interestRate, bankBalance, parameter, circumference, endMonthBalance;
	int age;
	string firstName, lastName;
	char letter;

	//Open input and output files
	inFile.open("inData.txt");
	outFile.open("outData.txt");

	outFile << fixed << showpoint << setprecision(2);

	//reads the length and width to calculate area and parameter and then output it
	inFile >> length >> width;
	areaRectangle = length * width;
	parameter = 2 * (length + width);
	outFile << "Rectangle:" << endl;
	outFile << "Length = " << length << ", width = " << width << ", area = " << areaRectangle << ", parameter = " << parameter << endl << endl;

	//reads the radius to calculate area and cirumference and then output it 
	inFile >> radius;
	areaCircle = PI * (radius * radius);
	circumference = PI * (radius * 2);
	outFile << "Circle:" << endl;
	outFile << "Radius: " << radius << ", area = " << areaCircle << ", circumference = " << circumference << endl << endl;

	//reads first and last name plus the age and then outputs them
	inFile >> firstName >> lastName >> age;
	outFile << "Name: " << firstName << " " << lastName << ", age: " << age << endl;

	//reads the bank balance and interest rate to calculate the end of month balance and then outputs it
	inFile >> bankBalance >> interestRate;
	endMonthBalance = bankBalance + (bankBalance * ((interestRate / 12) / 100));
	outFile << "Beginning Balance = " << bankBalance << ", interest rate = " << interestRate << endl;
	outFile << "Balance at the end of the month = " << endMonthBalance << endl;

	//reads the letter and then outputs the next letter in the ASCII set
	inFile >> letter;
	outFile << "The character that comes after the letter " << letter << " in the ASCII set is " << char(letter + 1) << endl;

	//closes the input and output files
	inFile.close();
	outFile.close();

	return 0;
}

