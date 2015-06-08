// BatchMaker.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <fstream>

using namespace std;


int main()
{
	ofstream batchFile;
	batchFile.open("MainQuests.txt");
	for (int count = 0; count < 11; count++)
	{
		for (int stage = 10; stage < 351; stage++)
		{
			switch (count)
			{
			case 0: batchFile << "setstage MQ202 "; break;
			case 1: batchFile << "setstage MQ203 "; break;
			case 2: batchFile << "setstage MQ204 "; break;
			case 3: batchFile << "setstage MQ205 "; break;
			case 4: batchFile << "setstage MQ206 "; break;
			case 5: batchFile << "setstage MQ301 "; break;
			case 6: batchFile << "setstage MQ302 "; break;
			case 7: batchFile << "setstage MQPaarthurnax "; break;
			case 8: batchFile << "setstage MQ303 "; break;
			case 9: batchFile << "setstage MQ304 "; break;
			case 10: batchFile << "setstage MQ305 "; break;
			default: break;
			}
			batchFile << " " << stage << endl;
		}
	}
	batchFile.close();
	return 0;
}

