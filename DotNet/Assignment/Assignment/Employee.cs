//Employee 2nd program

using System;

class Employee1
{
    private static int counter = 0;

    public string Name { get; private set; }
    public int EmpNo { get; }
    public decimal Basic { get; private set; }
    public short DeptNo { get; private set; }

    public Employee1(string name, decimal basic, short deptNo)
    {
        if (string.IsNullOrWhiteSpace(name))
            Console.WriteLine ("Name cannot be blank.");
        if (basic < 10000 || basic > 100000)
            Console.WriteLine ("Basic salary must be between 10,000 and 100,000.");
        if (deptNo <= 0)
            Console.WriteLine ("DeptNo must be greater than zero.");

        Name = name;
        Basic = basic;
        DeptNo = deptNo;
        EmpNo = ++counter;
    }

    public Employee1(string name, decimal basic) : this(name, basic, 1) { }

    public Employee1(string name) : this(name, 50000, 1) { } 

    public Employee1() : this("Alisha", 50000, 1) { }

    public decimal GetNetSalary()
    {
        decimal tax = Basic * 0.2M; 
        decimal netSalary = Basic - tax;
        return netSalary;
    }
}

class Program3
{
    static void Main1()
    {
        Employee1 o1 = new Employee1();
        Employee1 o2 = new Employee1();
        Employee1 o3 = new Employee1();

        Console.WriteLine(o1.EmpNo);
        Console.WriteLine(o2.EmpNo);
        Console.WriteLine(o3.EmpNo);

        Console.WriteLine(o3.EmpNo);
        Console.WriteLine(o2.EmpNo);
        Console.WriteLine(o1.EmpNo);
    }
}
