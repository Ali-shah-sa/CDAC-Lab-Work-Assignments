using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ConstructorAndInitializers
    {
        static void Main()
        {
            Employee emp = new Employee();
            Console.WriteLine(emp.EmpNo);
            Console.WriteLine(emp.name);


            Employee emp2 = new Employee(10, 20);
            Console.WriteLine(emp2.EmpNo);
            Console.WriteLine(emp2.name);


            Employee emp3= new Employee();
            emp3 = null;
        }

    }



    public class Employee
    {
        public int EmpNo { get; set; }
        public int name { get; set; }    
    }


    public Employee()
        {
            Console.WriteLine("No parameters");

            EmpNo = 1;
            name = 2;
        }

        public Employee(int EmpNo,int name)
        {
            this.EmpNo = EmpNo;
             this.name = name;
        }


        //public Employee(int EmpNo=1,int name=2)
        //{
        //    Console.WriteLine("Parameterized");
        //    this.EmpNo= EmpNo;
        //    this.name = name;   
        //}






    
}