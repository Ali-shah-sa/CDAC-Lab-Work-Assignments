using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExceptionHandling1;

namespace ExceptionHandling2
{
    internal class ExceptionHandling2
    {


        static void Main()
        {
            Class1 obj = new Class1();
            try
            {
                int x = Convert.ToInt32(Console.ReadLine());
                obj.P1 = x;
                Console.WriteLine(obj.P1);
                Console.WriteLine("No Exceptions");
            }
            catch (FormatException)
            {
                Console.WriteLine("Format Exception occured");
            }
            catch (NullReferenceException )
            {
                Console.WriteLine("Null Referance Exception");
            }
            catch (InvalidP1Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ApplicationException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (SystemException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

    }

    public class InvalidP1Exception : Exception
    {
        public InvalidP1Exception()
        {
        }

        public InvalidP1Exception(string message) : base(message)
        {
        }
    }

    public class Class1
    {
        private int p1;
        public int P1
        {
            get
            {
                return p1;
            }
            set
            {
                if (value < 100)
                    p1 = value;
                else
                {
                    Console.WriteLine("invalid p1");
                    Exception ex;
                    ex = new Exception();
                    throw ex;

                    throw new Exception();
                    throw new Exception("invalid p1");
                    throw new InvalidP1Exception();
                    throw new InvalidP1Exception("invalid p1");
                }
            }
        }
    }
}
    
