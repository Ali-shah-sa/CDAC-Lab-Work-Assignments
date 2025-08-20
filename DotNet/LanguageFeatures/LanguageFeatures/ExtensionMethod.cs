using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionMethod;

static void Main1()
{
    int a = 100;
    a = a.Add(10);
    a.Display();
    a.ExtMethodForBaseClass();
    string s = "aaa";
    s.show();
    s.ExtMethodForBaseClass();

}


static void Main2()
{
    int a = 100;
    a = a.Add(10);
    a.Display();
    a = MyExtClass.Add(a, 10);
    MyExtClass.Display(a);
    string s = "aaaa";
    s.show();
    MyExtClass.show(s);


}
static void Main3()
{ 
}



namespace ExtensionMethod
{
    class Class1
    {
        public int a;
        public int b;
    }
    public static class MyExtClass
    {
        public static void Display(this int i)
        {
            Console.WriteLine(i);
        }
        public static void show(this string s)
        {
            Console.WriteLine(s);
        }
        public static int Add(this int i,int j)
        {
            return i + j;
        }

        public static void ExtMethodForBaseClass(this object o)
        {
            Console.WriteLine(o);
        }
        public static int Subtract(this IMathOperation objIMath,int a,int b)
        {
            return a - b;
        }



    }


    public interface IMathOperation
    {
        int Add(int i,int j);
        int multiply(int a, int b);
       // int divide(int a,int b);
       // int divideBy(int a,int b);

    }
    public class ClsMaths : IMathOperations
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Multiply(int a, int b)
        {
            return a * b;
        }
    }

}
