/* given length in incehes, this program outputs the equivalent
length in feet and remaining inches */

#include <iostream>

using namespace std;

int main()
{
	int inches;

	cout << "Enter total inches and press Enter: "; // prompt the user to enter total inches

	cin >> inches; //store the value entered by the user into the variable inches

	cout << endl;

	cout << inches << " inch(es) = "; //output the value of inches and the equal sign

	cout << inches / 12 << " feet (foot) and "; //outputs maximum number of feet(foot)

	cout << inches % 12 << " incn(es)" << endl; // output remaining inches

	return 0;

}