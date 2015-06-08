#ifndef memberType_H
#define memberType_H

#include "stdafx.h"
#include "personType.h"

using namespace std;

class memberType: public personType
{
public:
    void printData() const;
       //Function to output the first name and last name
       //in the form firstName lastName.

	void setName(string first, string last);
		//Function to set the name

    void setID(string ID);
		//Function to set the Member ID

	void setBooks(int books);
		//Function to set the books bought

	void setSpent(double spent);
		//function to set the amount spent

	string getName() const;
		//Function to return the name

    string getID() const;
      //Function to return the member ID

    int getBooksBought() const;
      //Function to return number of books bought

	double getSpent() const;
		//Function to return the amount spent

	memberType();

    memberType(string first, string last, string ID, int booksBought, double spent);


 private:
    string memeberID;
	int numberOfBooksBought;
	double amountSpent;

};

#endif
