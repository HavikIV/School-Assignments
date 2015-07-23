#include <iostream>
#include <iomanip>
#include <string>
#include <fstream>

using namespace std;

int main()
{
    ifstream inputFile;
    ofstream outFile;

    string firstName, lastName;
    double salary, salInc;

    cout << "Processing the data..." << endl;

    inputFile.open("C:\\Users\\HellRasier\\Documents\\CodeBlocks\\Employee\\bin\\Debug\\Ch3_Ex7Data.txt");
    outFile.open("C:\\Users\\HellRasier\\Documents\\CodeBlocks\\Employee\\bin\\Debug\\Ch3_Ex7Output.dat");

    for (int line = 0; line < 3; line++)
    {
        inputFile >> firstName;
        inputFile >> lastName;
        inputFile >> salary;
        inputFile >> salInc;

        outFile << firstName << " " << lastName << setprecision(2) << " " << (salary + (salary * (salInc / 100))) << endl;
        cout << firstName << " " << lastName << setprecision(2) << " " << (salary + (salary * (salInc / 100))) << endl;
    }

    inputFile.close();
    outFile.close();

    cout << "Finished processing..." << endl;

    return 0;
}
