using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClasses
{
    internal class PartialClasses
    {
        public partial class MyClass
        {
            public int i;

        }

        public partial class MyClass
        {
            public int j;

        }   
        public class Program
        {
            public static void Main3()
            {
                MyClass myClass = new MyClass();
                myClass.i = 2;  
                myClass.j = 22;
                Console.WriteLine(myClass.i);
                Console.WriteLine(myClass.j);


            }
        }



    }
}
