//************************************************************************************
// Manjinder Singh
// 
// This is the second programming example in chapter 3 
// that determines the average test score of a student
// this program gets the input from a file called test.txt
// and outputs the results along side the student name and 
// the five test scores used to calculate the average score
// to a file call testavg.out.
//************************************************************************************

#include <iostream>
#include <fstream>
#include <iomanip>
#include <string>

using namespace std;

int main()
{
	//Declare the vairables
	ifstream inFile; //input file stream variable
	ofstream outFile; //output file stream variable

	double test1, test2, test3, test4, test5; //test score variables
	double testAverage; //test score average variable
	string firstName, lastName; //first and last name variables

	//statements to open files 'filestreamvariablename.open("filename")'
	inFile.open("test.txt"); //opens the input file and intailizes the file to the vairable inFile
	outFile.open("testavg.out"); //opens the output file and intailizes the file to the variable outFile

	outFile << fixed << showpoint; //sets the floating-point numbers in a fixed decimal format and the showpoint sets it to show the decimal point and the trailing zeros ex.'2.000'
	outFile << setprecision(2); // sets the decimal precision to 2 decimal places

	cout << "Processing data" << endl;

	inFile >> firstName >> lastName; // gets the students first name 1st and assigns it to the variable firstName then gets the last name and assigns it to the variable lastName
	outFile << "Student Name: " << firstName
		<< " " << lastName << endl; // outputs the students first and last name to the output file

	inFile >> test1 >> test2 >> test3 >> test4 >> test5; //reads the five test scorces from the input file and assigns each score in a different variable (in the order listed)
	outFile << "Test scores: " << setw(6) << test1
		<< setw(6) << test2 << setw(6) << test3 
		<< setw(6) << test4 << setw(6) << test5 << endl; //outputs the test scores to the output file (setw is used to output the value of an expression in a specific number of columns for example setw(6) would be "_____1" the underscore represents empty space

	testAverage = (test1 + test2 + test3 + test4 + test5) / 5.0;

	outFile << "Average test score: " << setw(6) << testAverage << endl; // outputs the average test score to the output file

	//Statements to close the files
	inFile.close();
	outFile.close();

	return 0;
}