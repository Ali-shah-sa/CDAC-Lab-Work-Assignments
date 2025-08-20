#include <iostream>
#include<string>
using namespace std;
class Employee
{
private:
	string name;
	int employeeid;
	double salary;
public:
	void setEmployee(string employee_name, int empid, double empsalary)
	{
		name = employee_name;
		employeeid = empid;
		salary = empsalary;
	}
	void dispalydetails()
	{
		cout << "Employee details" << endl;
		cout << "Name:" << name << endl;
		cout << "employee id:" << employeeid << endl;
		cout << "employee salary:" << salary;
	}

};
int main()
{
	Employee emp;
	string name;
	int id;
	double salary;

	

	emp.setEmployee("rajesh", 12345, 50000);
	emp.dispalydetails();

	return 0;

	



};