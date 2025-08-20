namespace Inhaeritance

{
    internal class Program
    {
        static void Maing5()
        {

            Employee emp = new Manager("Frank", 25000, 3, "Scrum Master");
            emp.Insert();
            emp.Update();
            emp.Delete();
            emp.Display();
            Console.WriteLine("Net Salary (Employee->Manager): " + emp.GetNetSalary());
            Console.WriteLine();    
            Manager m = new Manager("David", 30000, 2, "Delivery Manager");
            m.Insert();
            m.Update();
            m.Delete();
            m.Display();
            Console.WriteLine("Net Salary (Manager): " + m.GetNetSalary());
                
            CEO ceo = new CEO("Emily", 70000, 1);
            ceo.Insert();
            ceo.Update();
            ceo.Delete();
            ceo.Display();
            Console.WriteLine("Net Salary (CEO): " + ceo.GetNetSalary());

            Console.WriteLine();

            IDbFunctions oIDb;

            oIDb = new Manager("Alice", 20000, 2, "Team Lead");
            oIDb.Insert();
            oIDb.Update();
            oIDb.Delete();
            oIDb.Display();

            oIDb = new GeneralManager("Bob", 40000, 3, "General Manager", "Car, Bonus");
            oIDb.Insert();
            oIDb.Update();
            oIDb.Delete();
            oIDb.Display();

            oIDb = new CEO("Charlie", 60000, 1);
            oIDb.Insert();
            oIDb.Update();
            oIDb.Delete();
            oIDb.Display();
        }
    }

    public interface IDbFunctions
    {
        void Insert();
        void Update();
        void Delete();
        void Display();
    }

    public abstract class Employee : IDbFunctions
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
                    Console.WriteLine("Invalid EmpNo");
            }
        }

        public abstract decimal GetNetSalary();

        public  void Insert()
        {
            Console.WriteLine("Employee Insert");
        }

        public void Update()
        {
            Console.WriteLine("Employee Update");
        }

        public void Delete()
        {
            Console.WriteLine("Employee Delete");
        }

        public void Display()
        {
            Console.WriteLine("Employee Display");
        }

        public Employee(string Name = "default", decimal Basic = 10000, short DeptNo = 1)
        {
            this.EmpNo = ++lastEmpNo;
            this.Name = Name;
            this.Basic = Basic;
            this.DeptNo = DeptNo;
        }
    }

    public class Manager : Employee, IDbFunctions
    {
        public Manager(string Name = "default", decimal Basic = 10000, short DeptNo = 1, string Designation = "Desig")
            : base(Name, Basic, DeptNo)
        {
            this.Designation = Designation;
        }

        public new void Insert()
        {
            Console.WriteLine("Mgr Insert");
        }

        public new void Update()
        {
            Console.WriteLine("Mgr Update");
        }

        public new void Delete()
        {
            Console.WriteLine("Mgr Delete");
        }

        public new void Display()
        {
            Console.WriteLine("Mgr Display");
        }

        public string Designation { get; set; }

        public override decimal Basic
        {
            get { return basic; }
            set
            {
                if (value >= 10000 && value <= 50000)
                    this.basic = value;
                else
                    Console.WriteLine("invalid");
            }
        }

        public override decimal GetNetSalary()
        {
            return Basic * 2;
        }
    }

    public class GeneralManager : Manager, IDbFunctions
    {
        public string Perks { get; set; }

        public GeneralManager(string Name = "default", decimal Basic = 30000, short DeptNo = 1, string Designation = "GM", string Perks = "None")
            : base(Name, Basic, DeptNo, Designation)
        {
            this.Perks = Perks;
        }

        public override decimal Basic
        {
            get { return basic; }
            set
            {
                if (value >= 30000 && value <= 80000)
                    this.basic = value;
                else
                    Console.WriteLine("Invalid Basic for GeneralManager");
            }
        }

        public override decimal GetNetSalary()
        {
            return Basic * 2.5m;
        }

        public new void Insert()
        {
            Console.WriteLine("GeneralManager Insert");
        }

        public new void Update()
        {
            Console.WriteLine("GeneralManager Update");
        }

        public new void Delete()
        {
            Console.WriteLine("GeneralManager Delete");
        }

        public new void Display()
        {
            Console.WriteLine("GeneralManager Display");
        }
    }

    public class CEO : Employee, IDbFunctions
    {
        public CEO(string Name = "default", decimal Basic = 50000, short DeptNo = 1)
            : base(Name, Basic, DeptNo)
        {
        }

        public override decimal Basic
        {
            get { return basic; }
            set
            {
                if (value >= 50000)
                    this.basic = value;
                else
                    Console.WriteLine("Invalid Basic for CEO");
            }
        }

        public sealed override decimal GetNetSalary()
        {
            return Basic * 3;
        }

        public new void Insert()
        {
            Console.WriteLine("CEO Insert");
        }

        public new  void Update()
        {
            Console.WriteLine("CEO Update");
        }

        public new void Delete()
        {
            Console.WriteLine("CEO Delete");
        }

        public new void Display()
        {
            Console.WriteLine("CEO Display");
        }
    }
}
