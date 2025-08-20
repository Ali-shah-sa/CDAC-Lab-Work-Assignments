using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskCancellation
{
    internal class ValueTupleExapmle
    {
        static void Main()
        {
            ValueTuple<int,int> vt0= new(10,20);
            (int, int) vt1 = (1, 2);

            var vt2 = (1, 2);
            Console.WriteLine(vt2.Item1);
            Console.WriteLine(vt2.Item2);
            (int lastYear, int currentYear) namedValueTuple = (2021, 2022);
            Console.WriteLine(namedValueTuple.lastYear);
            Console.WriteLine(namedValueTuple.currentYear);
            var rightHandNamedValueTuple = (language: "C#", tool: "Laptop", occupation: "Developer");
            Console.WriteLine(rightHandNamedValueTuple.language);

            var valueTuple = ("my", "name", "is", "john", "doe", "and", "I", "am", 1000, "years", "old", true);

















        }

        public static string TakeInAValueTuple((int legCount,bool isBlue)organism)
        {
            var hasAtLeastFourLegs = organism.legCount >= 4;
            var isBlue = organism.isBlue;
            return$"hasAtLeastFourLegs:{
                hasAtLeastFourLegs}and isBlue:{ isBlue}";

        }
        public static (bool isDay, string greeting) ReturnAValueTuple()
        {
            if (DateTime.Now.Hour < 12)
                return (isDay: true, greeting: "Good Morning");
            return (isDay: false, greeting: "Good Evening");

        }







    }
}
