#include <iostream>
using namespace std;
int main()
{
    int a = 5, b = 10;
    int x = 50, y = 100;
    cout << "Before swapping: x = " << x << ", y = " << y<< endl;
    x = x + y;
    y = x - y;
    x = x - y;
    cout << "After swapping: x = " << x << ", y = " << y << endl << endl;
    return 0;
}