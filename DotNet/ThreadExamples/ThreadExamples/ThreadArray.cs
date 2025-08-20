using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadExamples
{
    internal class ThreadArray
    {
        static void Main()
        {

        }





        static void Func1(object obj)
        {
            object[] PArr = (object[])obj;
            int[] ints = (int[])PArr[0];
            string[] strs = (string[])PArr[1];

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Func1 - Count: {i}, Ints: {ints[0]}, {ints[1]}, Strings: {string.Join(", ", strs)}");
            }
        }

        static void Func2(object obj)
        {
            object[] PArr = (object[])obj;
            int[] ints = (int[])PArr[0];
            string[] strs = (string[])PArr[1];

            Console.WriteLine("Func2:");
            Console.WriteLine("Ints: " + string.Join(", ", ints));
            Console.WriteLine("Strings: " + string.Join(", ", strs));
        }
    }
}

