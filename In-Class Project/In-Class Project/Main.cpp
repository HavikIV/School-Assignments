//Program to test the various operations of a stack
//Manjinder Singh
//In-Class Project 4/8/2014
  
#include "stdafx.h"

using namespace std; 
 
int main()
{
	string str1;
	bool palindrome = true;
	queueType<char> myQueue;
	stackType<char> myStack;

	cout << "Please enter a string... ";
	cin >> str1;
	cout << endl;
	
	transform(str1.begin(), str1.end(), str1.begin(), ::tolower);

	cout << "checking... " << str1 << endl;

	for (int i = 0; i < str1.length(); i ++)
	{
		myQueue.addQueue(str1.at(i));
		myStack.push(str1.at(i));
	}

	for (int i = 0; i < str1.length(); i++)
	{
		if (myQueue.front() != myStack.top())
			palindrome = false;
		myQueue.deleteQueue();
		myStack.pop();
	}

	if (myQueue.isEmptyQueue())
		cout << "The string is a palindrome." << endl;
	else
		cout << "The string is not a palindrome." << endl;

	return 0;
}
