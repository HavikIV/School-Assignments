#include "Lottery.h"
#include <iostream>
#include <windows.h>

using namespace std;

int main()
{
	Lottery lotto;
	cout << "Hello.. Starting the program...." << endl;
	lotto.generateTickets(5, "SuperLotto");
	lotto.printArray();
	Sleep(5000);

	return 0;
}