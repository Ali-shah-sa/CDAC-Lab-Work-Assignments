using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadExamples
{
    internal class Program
    {

        static int i = 0;
        static object lockObject = new object();
        
        static void Main1()
        {
            Thread t1 = new Thread(FuncLock);
            t1.Start();

            Thread t2 = new Thread(FuncMonitor);
            t2.Start();
        }
        static void FuncLock()
        {
            lock (lockObject)
            {
                i++;
                Console.WriteLine("First FuncLock:" + i);
                i++;
                Console.WriteLine("First FuncLock:" + i);
                i++;
                Console.WriteLine("First FuncLock:" + i);
                i++;
                Console.WriteLine("First FuncLock:" + i);
                i++;
                Console.WriteLine("First FuncLock:" + i);

                Console.WriteLine("--------------------");


                Console.WriteLine("First FuncLock:" + i);
                i++;
                Console.WriteLine("First FuncLock:" + i);
                i++;
                Console.WriteLine("First FuncLock:" + i);
                i++;
                Console.WriteLine("First FuncLock:" + i);
                i++;
                Console.WriteLine("First FuncLock:" + i);
                i++;
                Console.WriteLine("First FuncLock:" + i);
                i++;
                Console.WriteLine("First FuncLock:" + i);
                i++;
                Console.WriteLine("First FuncLock:" + i);
                i++;
                Console.WriteLine("First FuncLock:" + i);
                i++;
                Console.WriteLine("First FuncLock:" + i);
                i++;
                Console.WriteLine("First FuncLock:" + i);
                i++;
                Console.WriteLine("First FuncLock:" + i);
                i++;
                Console.WriteLine("First FuncLock:" + i);
                i++;
                Console.WriteLine("First FuncLock:" + i);
                i++;
                Console.WriteLine("First FuncLock:" + i);
                i++;
                Console.WriteLine("First FuncLock:" + i);
                i++;
                Console.WriteLine("First FuncLock:" + i);
                i++;
                Console.WriteLine("First FuncLock:" + i);
                i++;
                Console.WriteLine("First FuncLock:" + i);
                i++;
                Console.WriteLine("First FuncLock:" + i);
                i++;
                Console.WriteLine("First FuncLock:" + i);
                i++;
                Console.WriteLine("First FuncLock:" + i);
                i++;
                Console.WriteLine("First FuncLock:" + i);
                i++;
                Console.WriteLine("First FuncLock:" + i);
                i++;
                Console.WriteLine("First FuncLock:" + i);
                i++;
                Console.WriteLine("------------");
            }
        }
        static void FuncMonitor()
        {
            Monitor.Enter(lockObject);
            {
                i++;
                Console.WriteLine("Second Monitor:"+i.ToString());
                i++;
                Console.WriteLine("Second Monitor:" + i.ToString());
                 i++;
                Console.WriteLine("Second Monitor:"+i.ToString());
                i++;
                Console.WriteLine("Second Monitor:" + i.ToString());
                i++;
                Console.WriteLine("Second Monitor:" + i.ToString());
                i++;
                Console.WriteLine("Second Monitor:" + i.ToString());
                i++;
                Console.WriteLine("Second Monitor:" + i.ToString());
                i++;
                Console.WriteLine("Second Monitor:" + i.ToString());
                i++;
                Console.WriteLine("Second Monitor:" + i.ToString());
                i++;
                Console.WriteLine("Second Monitor:" + i.ToString());
                i++;
                Console.WriteLine("Second Monitor:" + i.ToString());
                i++;
                Console.WriteLine("Second Monitor:" + i.ToString());
                i++;
                Console.WriteLine("Second Monitor:" + i.ToString());
                i++;
                Console.WriteLine("Second Monitor:" + i.ToString());
                i++;
                Console.WriteLine("Second Monitor:" + i.ToString());
                i++;
                Console.WriteLine("Second Monitor:" + i.ToString());
                i++;
                Console.WriteLine("Second Monitor:" + i.ToString());
                i++;
                Console.WriteLine("Second Monitor:" + i.ToString());
                i++;
                Console.WriteLine("Second Monitor:" + i.ToString());
                i++;
                Console.WriteLine("Second Monitor:" + i.ToString());
                i++;
                Console.WriteLine("Second Monitor:" + i.ToString());
                i++;
                Console.WriteLine("Second Monitor:" + i.ToString());
                i++;
                Console.WriteLine("Second Monitor:" + i.ToString());
                i++;
                Console.WriteLine("Second Monitor:" + i.ToString());
                i++;
                Console.WriteLine("Second Monitor:" + i.ToString());
                i++;
                Console.WriteLine("Second Monitor:" + i.ToString());
                i++;
                Console.WriteLine("Second Monitor:" + i.ToString());
                i++;
                Console.WriteLine("Second Monitor:" + i.ToString());


                Monitor.Exit(lockObject);
            }


        }






    }


}
