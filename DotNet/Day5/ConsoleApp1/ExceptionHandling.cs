using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ExceptionHandling1
{
    internal class ExceptionHandling
    {
        static void Main0()
        {
            Class1? obj = new Class1();
            obj = null;
            int x = Convert.ToInt32(Console.ReadLine());
            obj.P1 = 100 / x;
            Console.WriteLine(obj.P1);
        }
        static void Main1(string[] args) 
        {
            Class1 obj = new Class1();
            try
            {
                int x = Convert.ToInt32(Console.ReadLine());
                obj.P1 = 100 / x;
                Console.WriteLine(obj.P1);
                Console.WriteLine("No Exception");
            }
            catch
            {
                Console.WriteLine("Exception Occured");

            }
            Console.WriteLine("code after try");

        }
        static void Main1()
        {

            Class1 obj = new Class1();
            try
            {
               obj = null;
                int x = Convert.ToInt32(Console.ReadLine());
                obj.P1 = 100 / x;
                Console.WriteLine(obj.P1);
                Console.WriteLine("NO Exceptions");
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("Division By Zero Exeption Occured");
            }
            catch(NullReferenceException)
            {
                Console.WriteLine("Null Referance Exception Occured");
            }
            catch(FormatException)
            {
                Console.WriteLine("Format Exception Occured");
            }
            Console.WriteLine("Code after try");
        }
        static void Main3()
        {

            Class1 obj = new Class1();
            try
            {
                obj = null;
                int x = Convert.ToInt32(Console.ReadLine());
                obj.P1 = 100 / x;
                Console.WriteLine(obj.P1);
                Console.WriteLine("NO Exceptions");
            }
            // catch(SystemException ex)
             catch (FormatException)
            {
                Console.WriteLine("Format Exception occured");
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("NRException Occured");
            }

            catch (ArithmeticException)
            {
                Console.WriteLine("Arithmatic Exception Occured");
            }

            //catch (DivideByZeroException)
            //{
            //  Console.WriteLine("DBExeption Occured");
            //}

            catch (SystemException) 
            {
                Console.WriteLine("DBException occurred");
            }


            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("code after try");

        }

        static void Main5()
        {
            Class1 obj = new Class1();
            try
            {
                //obj = null;
                int x = Convert.ToInt32(Console.ReadLine());
                obj.P1 = 100 / x;
                Console.WriteLine(obj.P1);
                Console.WriteLine("No Exceptions");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("FormatException occurred");
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("NRException occurred");
            }


            catch (DivideByZeroException)
            {
                Console.WriteLine("DBExeption Occured");
            }

            catch (ArithmeticException )
            {
                Console.WriteLine("ArithmeticException occured");
            }
            catch (SystemException ) 
            {
                Console.WriteLine("DBException occurred");
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
            
            finally
            {
                Console.WriteLine("finally");

            }
            Console.WriteLine("after try");
        }


        static void Main8()// nested try block
        {
            Class1 obj = new Class1();
            try
            {
                //obj = null;
                int x = Convert.ToInt32(Console.ReadLine());
                obj.P1 = 100 / x;
                Console.WriteLine(obj.P1);
                Console.WriteLine("No Exceptions");
            }

            catch (FormatException ex)
            {
                try
                {
                    Console.WriteLine("FormatException occurred. Enter only numbers");
                    int x = Convert.ToInt32(Console.ReadLine());
                    obj.P1 = 100 / x;
                    Console.WriteLine(obj.P1);
                    Console.WriteLine("inner try - no exceptions");

                }
                catch
                {
                    Console.WriteLine("nested try catch example");
                }
                finally
                {
                    Console.WriteLine("nested try finally example");
                }
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("NRException occurred");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("DBException occurred");
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("outer finally");

            }
            Console.ReadLine();
        }


    }




    public class Class1
        {
        internal int InvalidP1;
        private int p1;
            public int P1
            {
                get { return p1; }
                set
                {
                    p1 = value;
                }
            }
        }




    }
