//Manjinder Singh
//Making function that  accepts string of a 16-bit binary integer and then output the decmial value of it.

#include <iostream>
#include <string>

using namespace std;

int binarytoInteger(string binaryInteger);

int main()
{
	string binaryInteger;
	cout << "Enter a 16-bit integer to convert to decimal: ";
	cin >> binaryInteger;
	cout << endl << "The decmial number is " << binarytoInteger(binaryInteger) << "." << endl;
}

int binarytoInteger(string binaryInteger)
{
	int num = 0;

	for (int i = 0; binaryInteger[i] >= '0' && binaryInteger[i] <= '1'; i++)
	{
		num = num * 2 + binaryInteger[i] - '0';
	}
	return num;
}