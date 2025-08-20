
namespace Reftype
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            int x, y; //unassigned
            Init(out x, out y);
            Swap(ref x, ref y);
            Print(in x);
            Print(y);
            Console.WriteLine(x);
            Console.WriteLine(y);
        }
        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        
        static void Init(out int a, out int b)
        { 
            a = 100;
            b = 200;
        }
        static void Print(in int x)
        {
         
            //x = 100; //error
            Console.WriteLine(x);

        }
    }
}