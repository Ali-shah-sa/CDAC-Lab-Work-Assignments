using System;
using System.Collections.Generic;

class EmployeeList
{
    private static int lastEmpNo = 0;
    private int empNo;
    private string name;
    private decimal salary;

    public int EmpNo => empNo;

    public string Name
    {
        get => name;
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
                name = value;
            else
                Console.WriteLine("Invalid Name");
        }
    }

    public decimal Salary
    {
        get => salary;
        set
        {
            if (value > 0)
                salary = value;
            else
                Console.WriteLine("Invalid Salary");
        }
    }

    public EmployeeList(string name, decimal salary)
    {
        empNo = ++lastEmpNo;
        Name = name;
        Salary = salary;
    }

    public void Display()
    {
        Console.WriteLine($"EmpNo: {EmpNo}, Name: {Name}, Salary: {Salary}");
    }
}

class Program8
{
    static void Main()
    {
        // Step 1: Create a List of EmployeeList
        List<EmployeeList> employee = new List<EmployeeList>
        {
            new EmployeeList("Alice", 30000),
            new EmployeeList("Bob", 45000),
            new EmployeeList("Charlie", 40000)
        };

        // Step 2: Convert List to Array
        EmployeeList[] employeeArray = employee.ToArray();  

        // Step 3: Display all array elements
        Console.WriteLine("Employee Array:");
        foreach (var emp in employeeArray)
        {
            emp.Display();
        }
    }
}
