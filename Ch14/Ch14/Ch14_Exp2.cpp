// Checking division by zero.


#include <stdexcept>
#include "stdafx.h"
  
using namespace std;

int main() 
{
    int dividend, divisor, quotient;                //Line 1

    cout << "Line 2: Enter the dividend: ";         //Line 2
    cin >> dividend;                                //Line 3
    cout << endl;                                   //Line 4

    cout << "Line 5: Enter the divisor: ";          //Line 5
    cin >> divisor;                                 //Line 6
    cout << endl;                                   //Line 7
	try
	{
        quotient = dividend / divisor;              //Line 9
        cout << "Line 10: Quotient = " << quotient 
             << endl;                               //Line 10
    }
	catch (runtime_error re)
	{
		cout << "Line 12: Cannot divide by zero." << endl;  //Line 12
	}

    return 0;                                       //Line 13
}

