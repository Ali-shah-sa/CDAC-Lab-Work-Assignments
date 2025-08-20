#include<iostream>
using namespace std;

int main()
{
	int n,num, digit, rev = 0;

	cout << " Enter a number: ";
	cin >> num;
	n = num;
	do
	{
		digit = num % 10;
		rev = (rev * 10) + digit;
		num = num / 10;
		
	} while (num != 0);
		cout << "the reverse of the number is " << rev ;
	
		if (n == rev and n > 0)
		{

			cout << "number is a palindrome";
		}
		else
		{
			cout << " number is not a plaindropme";
		}
	return 0;
	

}