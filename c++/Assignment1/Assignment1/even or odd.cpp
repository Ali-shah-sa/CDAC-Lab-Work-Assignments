#include<iostream>
using namespace std;
int main()
{	
	int n;
	cout << "Enter a number ";
	cin >> n;
	if (n % 2 == 0)
		cout << n << " it is a even number: ";
	else
		cout << n << " it is an odd number";
	return 0;
}
