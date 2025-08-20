using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Arrays
    {
        static void Main1()
        {
            int[] arr = new int[5];
            //arr[0] = 0;
            //arr[4] = 40;
            for (int i = 0; i < arr.Length; i++)
            {
               Console.Write("enter value for arr[" + i + "] : ");  //string concatenation
                Console.Write("enter value for arr[{0}] : ", i);  //placeholders
                Console.Write($"enter value for arr[{i}] : ");  //string interpolation

                Console.WriteLine("enter value for arr[0]");
                arr[i] = int.Parse(Console.ReadLine());
                arr[i] = int.Parse(Console.ReadLine()!);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"value for arr[{i}] is {arr[i]} ");
            }
            foreach (int item in arr)
            {
                //item = 0; // item is readonly
                Console.WriteLine(item);
            }
        }
        static void Main2()
        {
            int[] arr = new int[5] { 10, 20, 30, 40, 50 };
            int[] arr2 = { 10, 20, 30, 40 };

            int pos = Array.IndexOf(arr, 30);
            pos = Array.LastIndexOf(arr, 30);
            pos = Array.BinarySearch(arr, 30);
            if (pos < 0)
                //if (pos == -1)
                Console.WriteLine("not found");
            else
                Console.WriteLine("found at " + pos);
            Array.Clear(arr);
            Array.Copy(arr, arr2, arr.Length);
            //Array.ConstrainedCopy()
            Array.Sort(arr);
            Array.Reverse(arr2);


            foreach (int item in arr)
            {
                //item = 0; // item is readonly
                Console.WriteLine(item);
            }
        }





















    }



    public class Employee
    {
        public int EmpNo { get; set; }
        public string Name { get; set; }

    }
}
