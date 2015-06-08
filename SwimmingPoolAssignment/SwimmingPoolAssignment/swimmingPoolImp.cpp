//Implementation file for the swimming pool class
// Manjinder Singh
// CMPSC 261-2976, Spring 2014
// Assignment 02
// Page 706, Problem

#include "stdafx.h"
#include "swimmingPool.h"
#include <iostream>

using namespace std;

double swimmingPool::getWaterAmount()
{
	double waterNeeded = (length * width * ((shallowEnd + deepEnd)/2)) * 7.5;
	return waterNeeded;
}

double swimmingPool::getFillTimeNeeded(double waterNeeded)
{
	double fillTimeNeeded = (waterNeeded - waterInPool) / rateFill;
	return fillTimeNeeded;
}

double swimmingPool::getDrainTimeNeeded()
{
	double drainTimeNeeded = waterInPool / rateDrain;
	return drainTimeNeeded;
}

void swimmingPool::print() const
{
	cout << "The amount of water in the pool is " << waterInPool << " gallons." << endl;
}

void swimmingPool::addWater(double time)
{
	waterInPool = waterInPool + (rateFill * time);
}

void swimmingPool::drainWater(double time)
{
	waterInPool = waterInPool - (rateDrain * time);
}

swimmingPool::swimmingPool()
{
	length = 30;
	width = 20;
	shallowEnd = 3;
	deepEnd = 12;
	rateFill = 25;
	rateDrain = 25;
	waterInPool = 0;
}

swimmingPool::swimmingPool(int len, int wid, double shallow, double deep, double fill, double drain, double inPool)
{
	length = len;
	width = wid;
	shallowEnd = shallow;
	deepEnd = deep;
	rateFill = fill;
	rateDrain = drain;
	waterInPool = inPool;
}