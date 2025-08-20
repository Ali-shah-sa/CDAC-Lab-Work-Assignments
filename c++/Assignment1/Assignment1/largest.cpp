#include<iostream>
using namespace std;

int main()
{
	int a[] = {1662,33,211,599};
	int max = a[0];
	for (int i = 0; i < sizeof(a) / sizeof(a[0]); i++)
	{

		if (a[i] > max)
		{
			max = a[i];
		}
		else
		{
			max = max;
		}
	}
	cout << "Largest number in an array is : " << max;
	return 0;

}