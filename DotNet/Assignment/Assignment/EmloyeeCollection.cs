using System;
using System.Collections.Generic;

class EmployeeCollection
{
    private static int lastEmpNo = 0;
    private int empNo;
    private string name;
    private decimal salary;

    public int EmpNo
    {
        get { return empNo; }
    }

    public string Name
    {
        get { return name; }
        set
        {
            if (value != "")
                name = value;
            else
                Console.WriteLine("Invalid Name");
        }
    }

    public decimal Salary
    {
        get { return salary; }
        set
        {
            if (value > 0)
                salary = value;
            else
                Console.WriteLine("Invalid Salary");
        }
    }

    public EmployeeCollection(string name, decimal salary)
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

class Program7
{
    static void Main()
    {
        List<Employee> employees = new List<Employee>();
        string choice;

        do
        {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Salary: ");
            decimal salary = decimal.Parse(Console.ReadLine());

            employees.Add(new EmployeeCollection(name, salary));

            Console.Write("Do you want to add another employee? (yes/no): ");
            choice = Console.ReadLine()!.ToLower();
        } while (choice == "yes");

        // Display employee with highest salary
        if (employees.Count > 0)
        {
            Employee highest = employees[0];
            foreach (var emp in employees)
            {
                if (emp.NetSalary > highest.NetSalary)
                    highest = emp;
            }

            Console.WriteLine("\nEmployee with the highest salary:");
            highest.Display();
        }

        // Search by EmpNo
        Console.Write("\nEnter EmpNo to search: ");
        int searchNo = int.Parse(Console.ReadLine());
        bool found = false;

        foreach (var emp in employees)
        {
            if (emp.EmpNo == searchNo)
            {
                Console.WriteLine("Employee found:");
                emp.Display();
                found = true;
                break;
            }
        }

        if (!found)
            Console.WriteLine("Employee not found.");

        // Display Nth employee
        Console.Write("\nEnter position (N) to display the Nth employee: ");
        int n = int.Parse(Console.ReadLine()!);

        if (n >= 1 && n <= employees.Count)
        {
            Console.WriteLine($"Employee at position {n}:");
            employees[n - 1].Display();
        }
        else
        {
            Console.WriteLine("Invalid position.");
        }
    }
}
