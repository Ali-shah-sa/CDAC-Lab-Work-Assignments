//Lambda
using Lambda;
namespace Lambda

{
    internal class Program
    {
        static void Main1()
        {

            //Func<int, int> o1 = MakeDouble;
            //Console.WriteLine(o1(10));

            //Func<int, int> o2 = delegate (int a)
            //{
            //    return a * 2;
            //};
            //Console.WriteLine(o2(10));

            //Func<int, int>  03 = a => a * 2;
            Func<int, int> o4 = (a) => a * 2;
            Console.WriteLine(o4(10));


            Func<string> o5 = () => DateTime.Now.ToLongTimeString();
            Console.WriteLine(o5());

            Func<int, int, int> o6 = (a, b) => a + b;
            Console.WriteLine(o6(2, 3));





            Predicate<int> o7 = a =>
            {
                if (a % 2 == 0)
                    return true;
                else
                    return false;
            };
            Console.WriteLine(o7(100));


            Predicate<int> o8 = a => a % 2 == 0;
            Console.WriteLine(o8(20));


            Action o9 = () => Console.WriteLine("display called");
                o9();


            Predicate<Employee> o10 = emp => emp.Basic > 10000;
            Employee obj = new Employee { Basic = 20000 };
            Console.WriteLine(o10(obj));



        }








        static int Add(int a, int b)
        {
            return a + b;

        }
        static bool IsEven(int a)
        {
            return a % 2 == 0;

        }

        static void display()
        {
            Console.WriteLine("Display Called");
        }


        static bool IsBasicGreaterThan10000(Employee emp)
        {
            if (emp.Basic > 0)
            {
                return true;
            }
            return false;

        }
        static int MakeDouble(int a)
        {
            return a * 2;
        }
        static string GetTime()
        {
            return DateTime.Now.ToLongTimeString();
        }







    }
    public class Employee
    {
        public int EmpNo { get; set; }
        public decimal Basic { get; set; }

    }
}
