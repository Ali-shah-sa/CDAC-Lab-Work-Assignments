using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadExamples
{
    internal class TaskExample
    {
        static void Main3()
        {
           // Task t1 =new Task(new Action(Func1));
            Task t1 = new Task(Func1);
            Task t2 = new Task(Func2);
            t1.Start();
            t2.Start();
            Console.ReadLine();
        }
    static void Func1()
        {
            for(int i=0;i<10;i++)
            {
                Console.WriteLine("First:" + i);
            }
        }
        static void Func2()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("second Func called from {0},{1}",
                                    Thread.CurrentThread.ManagedThreadId, i);
            }

        }    
    }
}
