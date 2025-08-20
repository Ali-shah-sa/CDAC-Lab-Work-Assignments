using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Interface1
    {
        
        static void Main1(string[] args)
        {
            Class1 obj = new Class1();
            obj.Show();
            //method 1 
            obj.Insert();
            obj.Update();
            obj.Delete();

            //method 2
            IDbFunctions oIDb;
            oIDb = obj;
            oIDb.Insert();
            oIDb.Update();
            oIDb.Delete();

            //method 3
            ((IDbFunctions)obj).Insert();
            ((IDbFunctions)obj).Delete();
            ((IDbFunctions)obj).Update();

            //method 4
            (obj as IDbFunctions).Insert();
            (obj as IDbFunctions).Update();
            (obj as IDbFunctions).Delete();



        }
    }
    public interface IDbFunctions
    {
        void Insert();
        void Update();
        void Delete();
    }
    public class Class1 : IDbFunctions
    {
        public void Delete()
        {
            Console.WriteLine("Delete");
        }

        public void Insert()
        {
            Console.WriteLine("Insert");
        }
        public void Update()
        {
            Console.WriteLine("Update");
        }
        public void Show()
        {
            Console.WriteLine("Show");
        }


    }



}

