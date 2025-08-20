using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

//namespace PartialClasses
//{
//    public partial class Class1
//    {
//        public int k;
//    }
//}

namespace PartialMethods
{ 
    internal class PartialClassMethod
    {
        public class MainClass
        {
            public static void Main4()
            {
                Class1 o = new Class1();

                Console.WriteLine(o.Check());
                Console.ReadLine();
            }    

        }


        public partial class Class1
        {
            public bool isValid = true;
            partial void Validate();
            public bool Check()
            {
                return isValid;
            }
        }

        //public partial class Class1
        //{
        //    public bool IsEven=true;
        //partial void Validate(a%2==0);

        //    public bool Check();

        //    {
        //        return isValid;
        //    }






        //}
    }


    }

