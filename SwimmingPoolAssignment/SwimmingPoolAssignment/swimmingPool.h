//header file for swimmingPool class
// Manjinder Singh
// CMPSC 261-2976, Spring 2014
// Assignment 02
// Page 706, Problem
//I'm gonna assume the pool has shallow and deep ends
//I'm also gonna assume that the pools needs to be fill to the brim

class swimmingPool
{
public:
	double getWaterAmount();
		//function to get the amount of water needed to fill the pool
	
	double getFillTimeNeeded(double);
		//function to determine the amount of time needed to fill pool

	double getDrainTimeNeeded();
		//function to determine the amount of time needed to drain pool

	void addWater(double);
		//function to add water to the pool

	void drainWater(double);
		//function to drain water from the pool

	void print() const;

	swimmingPool();
		//default constructor
		//sets the pool size to 30'x20' with a shallow end depth be 3' and deep end depth be 12', empty, fill rate = 25 gpm, drain rate 25 gpm, water capacity = 54000 gallons

	swimmingPool(int, int, double, double, double, double, double);
		//constructor for using user input to initialize the variables

private:
	int length, width;
	double rateFill, rateDrain, waterInPool, shallowEnd, deepEnd;
};