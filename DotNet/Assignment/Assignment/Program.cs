using System;

namespace Assignment
{
    internal class Program
    {
        static void Main5(string[] args)
        {
            Employee o1 = new Employee(1, "Amol", 123465, 10);
            Employee o2 = new Employee(1, "Amol", 123465);
            Employee o3 = new Employee(1, "Amol");
            Employee o4 = new Employee(1);
            Employee o5 = new Employee();

            Console.WriteLine(o1);
            Console.WriteLine(o2);
            Console.WriteLine(o3);
            Console.WriteLine(o4);
            Console.WriteLine(o5);

            Console.ReadLine();
        }
    }

     class Employee
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

        public  decimal Basic { get; set; }

        public short DeptNo
        {
            get { return deptNo; }
            set
            {
                if (value > 0)
                    deptNo = value;
                else
                    Console.WriteLine("Invalid EmpNo");
            }
        }


        public Employee() : this(1, "Alisha", 80000, 1) { }

        public Employee(int empNo) : this(empNo, "Alisha", 80000, 1) { }

        public Employee(int empNo, string name) : this(empNo, name, 80000, 1) { }

        public Employee(int empNo, string name, decimal basic) : this(empNo, name, basic, 1) { }

        public Employee(int empNo, string name, decimal basic, short deptNo)
        {
            EmpNo = empNo;
            Name = name;
            Basic = basic;
            DeptNo = deptNo;
        }

        public decimal GetNetSalary()
        {
            return Basic + (Basic * 0.2M);
        }

        public override string ToString()
        {
            return $"EmpNo: {EmpNo}, Name: {Name}, Basic: {Basic}, DeptNo: {DeptNo}, Net Salary: {GetNetSalary()}";
        }
    }
}
