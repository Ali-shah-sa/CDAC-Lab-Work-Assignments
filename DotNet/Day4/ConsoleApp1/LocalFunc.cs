namespace LocalFunctions
{
    internal class Program
    {
        static void Main8()
        {
            Class1 o = new Class1();
            o.Display();
        }
    }

    public class Class1
    {
        public void Display()
        {
            int i = 100; 
            Console.WriteLine("Display called");
            DoSomething1();
            DoSomething2();
            
            void DoSomething1()
            {
                
                Console.WriteLine(++i);
                Console.WriteLine("Do Something 1");
            }
            static void DoSomething2() 
            {
                Console.WriteLine("Do Something 2");
            }
        }

    }
}
