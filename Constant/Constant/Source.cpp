//defined constants: calculate circumference

#include <iostream>
using namespace std;

#define pi 3.14159
#define newline '\n'

int main()
{
	double r=5.0;		//radius
	double circle;

	circle = 2 * pi * r;
	cout << circle;
	cout << newline;

	return 0;
}