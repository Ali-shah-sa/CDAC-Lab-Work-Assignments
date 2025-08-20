using System;
using System.Security.Cryptography.X509Certificates;

abstract class EmployeeArray
{
    string name;
    int empNo;
    protected decimal basic;
    short deptNo;
    static int lastEmpNo = 0;

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

    public int EmpNo
    {
        get { return empNo; }
        private set
        {
            if (value > 0)
                empNo = value;
            else
                Console.WriteLine("Invalid EmpNo");
        }
    }

    public abstract decimal Basic { get; set; }

    public short DeptNo
    {
        get { return deptNo; }
        set
        {
            if (value > 0)
                deptNo = value;
            else
                Console.WriteLine("Invalid DeptNo");
        }
    }

    public Employee(string name = "default", decimal basic = 10000, short deptNo = 1)
    {
        this.EmpNo = ++lastEmpNo;
        this.Name = name;
        this.Basic = basic;
        this.DeptNo = deptNo;
    }

    public abstract decimal GetNetSalary();

    public virtual void Display()
    {
        Console.WriteLine($"EmpNo: {EmpNo}, Name: {Name}, Basic: {Basic}, DeptNo: {DeptNo}, Net Salary: {GetNetSalary()}");
    }
}

class Manager : Employee
{
    public Manager(string name = "default", decimal basic = 10000, short deptNo = 1)
        : base(name, basic, deptNo)
    {
    }

    public override decimal Basic{
        get { return Basic; }
        set
        {
            if (value >= 10000 && value <= 50000)
                Basic = value;
            else
                Console.WriteLine("Basic must be between 10000 and 50000.");
        }
    }
}

class Program22
{
    static void Main()
    {
        Console.Write("Enter number of employees: ");
        int n = int.Parse(Console.ReadLine()!);

        Employee[] employees = new Employee[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"\nEnter details for Employee {i + 1}:");

            Console.Write("Enter Name: ");
            string name = Console.ReadLine()!;

            Console.Write("Enter Basic Salary: ");
            decimal basic = decimal.Parse(Console.ReadLine()!);

            Console.Write("Enter Dept No: ");
            short deptNo = short.Parse(Console.ReadLine()!);

            employees[i] = new Manager(name, basic, deptNo);
        }

        // Display Employee with Highest Net Salary
        Employee highest = employees[0];
        foreach (var emp in employees)
        {
            if (emp.GetNetSalary() > highest.GetNetSalary())
                highest = emp;
        }

        Console.WriteLine("\nEmployee with highest salary:");
        highest.Display();

        // Search Employee by EmpNo
        Console.Write("\nEnter EmpNo to search: ");
        int searchNo = int.Parse(Console.ReadLine()!);
        bool found = false;

        foreach (var emp in employees)
        {
            if (emp.EmpNo == searchNo)
            {
                Console.WriteLine("\nEmployee Found:");
                emp.Display();
                found = true;
                break;
            }
        }

        if (!found)
            Console.WriteLine("Employee not found.");
    }
}
