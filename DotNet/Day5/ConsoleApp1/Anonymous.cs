using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousMethods

{
    internal class Anonymous
    {

        static void Main2()
        {
            int i = 100;
            Action o = delegate ()
            {
                Console.WriteLine(++i);
                Console.WriteLine("Anon Method are Called");
            };
            o();

            Func<int, int, int> o2=delegate(int x,int y)
            {
                return x;
            };
            Console.WriteLine(o2(10,20));

            Predicate<int> o3 = delegate (int x)
            {
                if (x % 2 == 0)
                    return true;
                else
                    return false;
            };
            Console.WriteLine(o3(20));
        }











    }
}
