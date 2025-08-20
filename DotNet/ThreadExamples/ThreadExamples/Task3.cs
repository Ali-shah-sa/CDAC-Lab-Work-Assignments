using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadExamples
{
    internal class Task3
    { 
        static void Main1()
        {
            //Task t1 = new Task(new Action<object>(Func1), "passed data");
            Task t1 = new Task(Func1, "passed data");
            t1.Start();

            Task t2 = Task.Factory.StartNew(Func2, "passed data");

            //Task t3 = Task.Run()
            //Task.Run - cannot be used with parameters. 
            //use anonymous methods instead to access variables declared in calling code
            string s = "ccc";
            Task.Run(delegate () { Console.WriteLine(s); });
            Task.Run(() => { Console.WriteLine(s); });
            Console.ReadLine();
        }
        static void Func1(object obj)
        {
            for(int i=0;i<10;i++)
            {
                Console.WriteLine("1st func call[0],[1]",i,obj.ToString() );

            }
        }

        static void Func2(object obj)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("2st func call[0],[1]", i, obj.ToString());

            }
        }

    }
}
