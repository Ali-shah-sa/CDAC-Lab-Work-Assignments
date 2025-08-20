namespace InheritanceExamples
{
    internal class Program
    {
        static void Main1()
        {
            BaseClass o = new BaseClass();
            
            DerivedClass o2 = new DerivedClass();
            
        }
    }

    public class BaseClass : Object
    {
        public int a;
    }
    public class DerivedClass : BaseClass
    {
        public int b;
    }

}

namespace ConstructorsInInheritance
{
    class Program
    {
        static void Main()
        {
            
            DerivedClass o2 = new DerivedClass(123, 456);
        }
    }
    public class BaseClass
    {
        public int i;
        public BaseClass()
        {
            Console.WriteLine("base class no param cons");
            i = 10;
        }
        public BaseClass(int i)
        {
            Console.WriteLine("base class int cons");
            this.i = i;
        }
    }
    public class DerivedClass : BaseClass
    {
        public int j;
        public DerivedClass()
        {
            Console.WriteLine("derived class no param cons");
            j = 20;
        }
        public DerivedClass(int i, int j) : base(i)
        {
            Console.WriteLine("derived class int,int cons");

            this.j = j;
        }
    }
}
