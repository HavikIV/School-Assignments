// Main.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "memberType.h"

using namespace std;

int main()
{
    memberType newMember("Boob", "Killer", "738178", 5, 155.21);
    newMember.printData();

	memberType otherMember;
	otherMember.printData();
	otherMember.setName("Manjinder", "Singh");
	otherMember.printData();
	string first = otherMember.getFirstName();
	string name = otherMember.getName();

	cout << first << endl;
	cout << "Line 22 Cout statement " << name << endl;
    return 0;
}