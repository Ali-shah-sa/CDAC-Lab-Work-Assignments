#include<iostream>

using namespace std;

class BankAcc
{
private:
    int accountNumber;
    double bal;

public:
    BankAcc()
    {
        bal = 100000;
        accountNumber = 123456;
    }

    void deposit(double amount)
    {
        bal += amount;
        cout << "Deposit Successful: " << bal << endl;
    }

    void withdraw(double amount)
    {
        if (amount <= bal)
        {
            bal -= amount;
            cout << "Withdraw Successful: " << bal << endl;
        }
        else
        {
            cout << "Insufficient balance!" << endl;
        }
    }

    void dispbalance()
    {
        cout << "Current balance: " << bal << endl;
    }
};

int main()
{
    BankAcc bank;
    bank.dispbalance();
    bank.deposit(3200);
    bank.dispbalance();
    bank.withdraw(200);
    bank.dispbalance();

    return 0;
}
