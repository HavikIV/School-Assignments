//Program to test the various operations of a stack
  

#include "myStack.h"
#include "stdafx.h"

using namespace std; 
 
int main()
{
	stackType<int> stack1;
	stackType<int> stack2;
	int newItem;

	cout << "Example 18-1 shows how a stack is used." << endl;
	for (int count = 0; count < 5; count++)
	{
		cin >> newItem;
		stack1.push(newItem);
	}
	cout << "stack1 top is " << stack1.top() << endl;
	stack1.reverseStack(stack2);
	cout << "stack2 top is " << stack2.top() << endl;
	cout << "stack1 top is " << stack1.top() << endl;

	return 0;
}
