// SwimmingPoolAssignment.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <iomanip>
#include "swimmingPool.h"

using namespace std;


int main()
{
	swimmingPool newPool(60, 30, 12, 12, 10, 15, 0);
	swimmingPool otherPool(60, 30, 3, 12, 105, 100, 0);
	
	cout << fixed << showpoint << setprecision(2);

	double water = newPool.getWaterAmount();
	newPool.addWater(newPool.getFillTimeNeeded(water));
	newPool.print();

	newPool.drainWater(15);
	newPool.print();

	double timeFill = newPool.getFillTimeNeeded(water);
	cout << timeFill << " Minutes." << endl;
	newPool.addWater(timeFill);
	newPool.print();

	double timeDrain = newPool.getDrainTimeNeeded();
	cout << timeDrain << " Minutes." << endl;
	newPool.drainWater(timeDrain);
	newPool.print();
	cout << endl;

	cout << "otherPool..." << endl;
	double water1 = otherPool.getWaterAmount();
	cout << "water needed for otherPool " << water1 << endl;
	otherPool.addWater(otherPool.getFillTimeNeeded(water1));
	otherPool.print();

	otherPool.drainWater(15);
	otherPool.print();

	double timeFill1 = otherPool.getFillTimeNeeded(water1);
	cout << timeFill1 << " Minutes." << endl;
	otherPool.addWater(timeFill1);
	otherPool.print();

	double timeDrain1 = otherPool.getDrainTimeNeeded();
	cout << timeDrain1 << " Minutes." << endl;
	otherPool.drainWater(timeDrain1);
	otherPool.print();

	return 0;
}

