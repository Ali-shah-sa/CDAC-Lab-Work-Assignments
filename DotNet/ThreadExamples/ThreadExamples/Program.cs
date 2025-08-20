using System;

namespace ThreadSynch
{
    internal class Program
    {
        class MainClass
        {
            static Lock lockObject = new();
            static int i = 0;
            static void Main2()
            {
                Thread t5 = new Thread(new ThreadStart(Func5));
                Thread t1 = new Thread(new ThreadStart(Func1));
                Thread t2 = new Thread(new ThreadStart(Func2));
                Thread t3 = new Thread(new ThreadStart(Func3));
                Thread t4 = new Thread(new ThreadStart(Func4));
                t1.Start();
                t2.Start();
                t3.Start();
                t4.Start();
                t5.Start();

            }

            static void Func1()
            {
                using (lockObject.EnterScope())
                {
                    Console.WriteLine("First lock:" + i);
                    i++;
                    Console.WriteLine("First lock:" + i);
                    i++;
                    Console.WriteLine("First lock:" + i);
                    i++;
                    Console.WriteLine("First lock:" + i);
                    i++;
                    Console.WriteLine("First lock:" + i);
                    i++;
                    Console.WriteLine("First lock:" + i);
                    i++;
                    Console.WriteLine("First lock:" + i);
                    i++;
                    Console.WriteLine("First lock:" + i);
                    i++;
                    Console.WriteLine("First lock:" + i);
                    i++;
                    Console.WriteLine("First lock:" + i);
                    i++;
                    Console.WriteLine("First lock:" + i);
                    i++;
                    Console.WriteLine("First lock:" + i);
                    i++;
                }
            }
            static void Func2()
            {
                using (lockObject.EnterScope())
                {
                    Console.WriteLine("Second func:" + i);
                    i++;
                    Console.WriteLine("Second func:" + i);
                    i++;
                    Console.WriteLine("Second func:" + i);
                    i++;
                    Console.WriteLine("Second func:" + i);
                    i++;
                    Console.WriteLine("Second func:" + i);
                    i++;
                    Console.WriteLine("Second func:" + i);
                    i++;
                    Console.WriteLine("Second func:" + i);
                    i++;
                    Console.WriteLine("Second func:" + i);
                    i++;
                    Console.WriteLine("Second func:" + i);
                    i++;
                    Console.WriteLine("Second func:" + i);
                    i++;
                    Console.WriteLine("Second func:" + i);
                    i++;
                    Console.WriteLine("Second func:" + i);
                    i++;
                }
            }
            static void Func3()
            {
                lock (lockObject)
                {
                    Console.WriteLine("Third func:" + i);
                    i++;
                    Console.WriteLine("Third func:" + i);
                    i++;
                    Console.WriteLine("Third func:" + i);
                    i++;
                    Console.WriteLine("Third func:" + i);
                    i++;
                    Console.WriteLine("Third func:" + i);
                    i++;
                    Console.WriteLine("Third func:" + i);
                    i++;
                    Console.WriteLine("Third func:" + i);
                    i++;
                    Console.WriteLine("Third func:" + i);
                    i++;
                    Console.WriteLine("Third func:" + i);
                    i++;
                    Console.WriteLine("Third func:" + i);
                    i++;
                    Console.WriteLine("Third func:" + i);
                    i++;
                    Console.WriteLine("Third func:" + i);
                    i++;
                }
            }
            static void Func4()
            {
                lockObject.EnterScope();
                {
                    Console.WriteLine("Fourth Func:" + i);
                    i++;
                    Console.WriteLine("Fourth Func:" + i);
                    i++;
                    Console.WriteLine("Fourth Func:" + i);
                    i++;
                    Console.WriteLine("Fourth Func:" + i);
                    i++;
                    Console.WriteLine("Fourth Func:" + i);
                    i++;
                    Console.WriteLine("Fourth Func:" + i);
                    i++;
                    Console.WriteLine("Fourth Func:" + i);
                    i++;
                    Console.WriteLine("Fourth Func:" + i);
                    i++;
                    Console.WriteLine("Fourth Func:" + i);
                    i++;
                    Console.WriteLine("Fourth Func:" + i);
                    i++;
                    Console.WriteLine("Fourth Func:" + i);
                    i++;
                    Console.WriteLine("Fourth Func:" + i);
                    i++;
                    lockObject.Exit();

                }



            }
            static void Func5()
            {
                if (lockObject.TryEnter())
                {
                    Console.WriteLine("Fifth Func:" + i);
                    i++;
                    Console.WriteLine("Fifth Func:" + i);
                    i++;
                    Console.WriteLine("Fifth Func:" + i);
                    i++;
                    Console.WriteLine("Fifth Func:" + i);
                    i++;
                    Console.WriteLine("Fifth Func:" + i);
                    i++;
                    Console.WriteLine("Fifth Func:" + i);
                    i++;
                    Console.WriteLine("Fifth Func:" + i);
                    i++;
                    Console.WriteLine("Fifth Func:" + i);
                    i++;
                    Console.WriteLine("Fifth Func:" + i);
                    i++;
                    Console.WriteLine("Fifth Func:" + i);
                    i++;
                    Console.WriteLine("Fifth Func:" + i);
                    i++;
                    Console.WriteLine("Fifth Func:" + i);
                    i++;

                    LockObject.Exit();
                }
                else
                {
                    Console.WriteLine("Could not enter in 5th");
                }
            }

        }
    }
}
