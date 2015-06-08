#include "stdafx.h"
#include "memberType.h"
#include "personType.h"

using namespace std;

void memberType::printData() const
{
	personType::print(); //print the name of the member
	cout << ", member ID " << memeberID << ", number of books bought " << numberOfBooksBought << ", and the amount spent " << amountSpent << endl;
}

void memberType::setName(string first, string last)
{
	personType::setName(first, last);
}

void memberType::setID(string ID)
{
	memeberID = ID;
}

void memberType::setBooks(int books)
{
	numberOfBooksBought = books;
}

void memberType::setSpent(double spent)
{
	amountSpent = spent;
}

string memberType::getName() const
{
	string first = personType::getFirstName();
	string last = personType::getLastName();
	string name = first + " " + last;
	return name;
}

string memberType::getID() const
{
	return memeberID;
}

int memberType::getBooksBought() const
{
	return numberOfBooksBought;
}

double memberType::getSpent() const
{
	return amountSpent;
}

memberType::memberType()
{
	personType("","");
	memeberID = "";
	numberOfBooksBought = 0;
	amountSpent = 0.0;
}

memberType::memberType(string first, string last, string ID, int booksBought, double spent) : personType(first, last)
{
	memeberID = ID;
	numberOfBooksBought = booksBought;
	amountSpent = spent;
}
