using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ThreadFunc
    {
        static void Main0()
        {

            //Thread t1 = new Thread(new ThreadStart(Func1));
            Thread t1 = new Thread(Func1);
            t1.Start();

            Thread t2 = new Thread(Func2);
            t2.Start();
            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine(i);
            }

        }

            static void Main2()
            {
                Thread t1 = new Thread(Func1);
                t1.IsBackground = true;
                t1.Start();

                Thread t2 = new Thread(Func2);
                t2.IsBackground = true;
                t2.Start();

                for (int i = 0; i < 1; i++)
                {
                    Console.WriteLine("Main:" + i);
                }

            }


            static void Main3()
            {
                Thread t1= new Thread(Func1);
                t1.Start();

                Thread t2= new Thread(Func2);
                t2.Start();
                for(int i=0;i<1;i++)
                {
                    Console.WriteLine("Main:"+i);
                }

                t1.Join();
                Console.WriteLine("this code should run only after func1 is over");
            }

            static void Main4()
            {
                Thread t1=new Thread(Func1);
                t1.Priority = ThreadPriority.Highest;
                t1.Start();


                Thread t2=new Thread(Func2);
                t2.Priority = ThreadPriority.Lowest;
                t2.Start();
                for(int i=0;i<1000;i++)
                {
                    Console.WriteLine("Main:"+i);
                }


            }

        static void Main5()
        {
            Thread t1=new Thread(Func1);
            //if(t1.ThreadState==ThreadState.)
                t1.Start();
           // t1.Abort();
            //t1.Suspend();  working in older version
            //t1.Resume();

            Thread t2 = new Thread(new ThreadStart(Func2));
            t2.Start();
            for(int i=0;i<10;i++)
            {
                Console.WriteLine("MAin:"+i);
                Thread.Sleep(1000);
            }



        }



        static void Main()
        {
            AutoResetEvent wh = new AutoResetEvent(false);
            Thread t1 = new Thread(delegate ()
            {
                for (int i = 0; i < 200; i++)
                {
                    Console.WriteLine("f1:" + i);
                    if (i % 50 == 0)
                    {
                        Console.WriteLine("waiting");
                        wh.WaitOne();
                    }
                }


            });
            t1.Start();
            Thread.Sleep(5000);
            Console.WriteLine("resume1");
            wh.Set();
            Thread.Sleep(5000);
            Console.WriteLine("resume2");
            wh.Set();

            Thread.Sleep(5000);
            Console.WriteLine("resume3");
            wh.Set();
        }

            static void Func1()
            {
                //Console.WriteLine("f" + Thread.CurrentThread.ManagedThreadId);
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("First : " + i);
                    //Thread.Sleep(1000);

                }
            }
            static void Func2()
            {
                //Console.WriteLine("s" +Thread.CurrentThread.ManagedThreadId);

                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Second : " + i);
                    //Thread.Sleep(1000);
                }
            }
        }
    }



