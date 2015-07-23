#include <iostream>

using namespace std;

int larger(int num1, int num2);
int largest(int, int, int);
void print();

int main()
{
    cout << "The largest number is " << larger(45, 12) << endl;
    cout << "The largest number is " << largest(45, 84, 3) << endl;
    print();
    return 0;
}

int larger(int num1, int num2)
{
    if (num1 > num2)
        return num1;
    else
        return num2;
}//end larger

int largest(int num1, int num2, int num3)
{
    return (larger(num1, larger(num2, num3)));
}

void print()
{
    cout << "This is a print function.";
}
