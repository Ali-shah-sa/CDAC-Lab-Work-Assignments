using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Interfaces2
{
    internal class Program
    {
        static void Main2()
        {
            Class1 obj = new Class1();
            obj.Show();
            //method 1 
            obj.Insert();
            obj.Update();
            obj.Open();
            obj.Close();
            //obj.Delete();


            //method 2
            IFileFunctions oIFile;
            oIFile = obj;
            oIFile.Open();
            oIFile.Close();
            oIFile.Delete();

            (obj as IDbFunctions).Delete();
            (obj as IFileFunctions).Delete();

        }
    }
    public interface IDbFunctions
    {
        void Insert();
        void Update();
        void Delete();
    }
    public interface IFileFunctions
    {
        void Open();
        void Close();
        void Delete();
    }
    public class Class1 : IDbFunctions, IFileFunctions
    {
        void IDbFunctions.Delete()
        {
            Console.WriteLine("Idb.Delete from class1");
        }
        public void Insert()
        {
            Console.WriteLine("Idb.Insert from class1");
        }
        public void Update()
        {
            Console.WriteLine("Idb.Update from class1");
        }
        public void Show()
        {
            Console.WriteLine("Show");
        }

        //void IFileFunctions.Open()
        //{
        //    Console.WriteLine("IFile.Open from class1");
        //}
        //void IFileFunctions.Close()
        //{
        //    Console.WriteLine("IFile.Close from class1");
        //}
        void IFileFunctions.Delete()
        {
            Console.WriteLine("IFile.Delete from class1");
        }
        public void Open()
        {
            Console.WriteLine("IFile.Open from class1");
        }

        public void Close()
        {

            Console.WriteLine("IFile.Close from class1");

        }

    }
}


