// Manjinder Singh
// CSCI-273 Assembly Language
// Book Excerises
// Just some funstions to recieve some string inputs and convert them to integers and also functions to convert form integer to string.

#include <iostream>
#include <string>
#include <math.h>

using namespace std;

int binaryToInteger(string binary);
int hexToInteger(string hex);
string integerToBinary(int number);
string integerToHex(int number);

int main()
{
	cout << "Testing:" << endl;
	cout << "0101010011110000b in decimal is: " << binaryToInteger("0101010011110000") << endl;
	cout << "1b456f09h in decimal is: " << hexToInteger("1b456f09") << endl;
	cout << "175d in binary is: " << integerToBinary(175) << endl;
	cout << "123456d in hexadecimal is: " << integerToHex(123456) << endl;

	return 0;
}

int binaryToInteger(string binary)
{
	int num = 0;

	for (int i = 0; binary[i] >= '0' && binary[i] <= '1'; i++)
	{
		num = num * 2 + binary[i] - '0';
	}
	return num;
} //end binaryToInteger function

int hexToInteger(string hex)
{
	int num = 0;
	int tempNum = 0;
	
	for (int i = 0; i < hex.length(); i++)
	{
		switch (hex[i])
		{
		case 'a':
		{
			tempNum = 10;
			break;
		}
		case 'b':
		{
			tempNum = 11;
			break;
		}
		case 'c':
		{
			tempNum = 12;
			break;
		}
		case'd':
		{
			tempNum = 13;
			break;
		}
		case 'e':
		{
			tempNum = 14;
			break;
		}
		case 'f':
		{
			tempNum = 15;
			break;
		}
		default:
		{
			tempNum = static_cast<int>(hex[i]) - 48;
			break;
		}
		} // end switch case
		num = num + (tempNum * pow(16, (hex.length() - 1 - i)));
	} // end for loop
	return num;
} //end hexToInteger function

string integerToBinary(int number)
{
	string binaryString = "";

	while (number != 0)
	{
		binaryString = binaryString + to_string(number % 2);
		number = number / 2;
	} //end while loop
	string returnBinaryString = "";
	for (int i = binaryString.length() - 1; i >= 0; i--) // for loop to store binaryString in reverse order in returnBinaryString
	{
		returnBinaryString = returnBinaryString + binaryString[i];
	}
	return returnBinaryString;
} //end integerToBinary function

string integerToHex(int number)
{
	string hexString = "";
	int tempModuls = 0;
	while (number != 0)
	{
		tempModuls = number % 16;
		if (tempModuls < 10)
		{
			hexString = hexString + to_string(tempModuls);
		}
		else // if the modulus is 10 or higher
		{
			switch (tempModuls) // switch case to represent 10-15 with A-F for hexadecimal numbers
			{
			case 10:
			{
				hexString = hexString + "A";
				break;
			}
			case 11:
			{
				hexString = hexString + "B";
				break;
			}
			case 12:
			{
				hexString = hexString + "C";
				break;
			}
			case 13:
			{
				hexString = hexString + "D";
				break;
			}
			case 14:
			{
				hexString = hexString + "E";
				break;
			}
			case 15:
			{
				hexString = hexString + "F";
				break;
			}
			} //end switch case
		} //end if...else...
		number = number / 16;
	} //end while loop

	string returnHexString = "";
	for (int i = hexString.length() - 1; i >= 0; i--) //for loop to store the hexString in reverse order in returnHexString
	{
		returnHexString = returnHexString + hexString[i];
	} //end for loop
	return returnHexString;
} //end integerToHex function