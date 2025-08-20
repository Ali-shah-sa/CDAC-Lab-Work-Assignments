using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadExamples
{
    internal class Task2//Task.Factory.StartNew
    {
        class Program
        {
            static void Main1()
            {
                Task t1 = Task.Run(Func1);
                Task t2 = Task.Factory.StartNew(Func2);
                Console.ReadLine();
            }
            static void Func1()
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("First func called from [0],[1]", Thread.CurrentThread.ManagedThreadId);
                }
            }
            static void Func2()
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Second Func Called from [0],[1]", Thread.CurrentThread.ManagedThreadId);
                }
            }


        }

    }
}