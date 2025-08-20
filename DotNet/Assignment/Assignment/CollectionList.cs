using System;
using System.Collections.Generic;

class Employee
{
    private int empNo;
    public int EmpNo
    {
        get { return empNo; }
        set
        {
            if (value <= 0)
            {
                Console.WriteLine("Error: EmpNo must be greater than 0. Setting default value 1.");
                empNo = 1;
            }
            else
                empNo = value;
        }
    }

    private string name;
    public string Name
    {
        get { return name; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                Console.WriteLine("Error: Name cannot be blank. Setting default value 'Unknown'.");
                name = "Unknown";
            }
            else
                name = value;
        }
    }

    private decimal basic;
    public decimal Basic
    {
        get { return basic; }
        set
        {
            if (value < 10000 || value > 100000)
            {
                Console.WriteLine("Error: Basic must be between 10000 and 100000. Setting default value 10000.");
                basic = 10000;
            }
            else
                basic = value;
        }
    }

    private short deptNo;
    public short DeptNo
    {
        get { return deptNo; }
        set
        {
            if (value <= 0)
            {
                Console.WriteLine("Error: DeptNo must be greater than 0. Setting default value 1.");
                deptNo = 1;
            }
            else
                deptNo = value;
        }
    }

    public override decimal NetSalary => Basic * 2; // Just an example formula

    public Employee(int empNo, string name, decimal basic, short deptNo)
    {
        EmpNo = empNo;
        Name = name;
        Basic = basic;
        DeptNo = deptNo;
    }

    public Employee(string name, decimal basic, short deptNo)
    {
        this.name = name;
        this.basic = basic;
        this.deptNo = deptNo;
    }

    public decimal GetNetSalary()
    {
        return Basic + (Basic * 0.2m);
    }

    public override string ToString()
    {
        return $"EmpNo: {EmpNo}, Name: {Name}, Basic: {Basic}, DeptNo: {DeptNo}, Net Salary: {GetNetSalary()}";
    }

    internal void Display()
    {
        throw new NotImplementedException();
    }
}

class Program
{
    static void Main6()
    {
        Employee[] empArray = new Employee[]
        {
            new Employee(1, "Alice", 50000, 1),
            new Employee(2, "Bob", 60000, 2),
            new Employee(3, "Charlie", 55000, 3)
        };

        List<Employee> empList = new List<Employee>(empArray);

        Console.WriteLine("Employee List:");
        foreach (Employee emp in empList)
        {
            Console.WriteLine(emp);
        }

        Console.ReadLine();
    }
}
