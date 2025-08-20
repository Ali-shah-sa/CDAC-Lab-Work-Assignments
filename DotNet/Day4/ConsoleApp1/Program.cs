using System;
using System.Collections;

namespace Collections
{
    internal class Program
    {
        static void Main1()
        {
            ArrayList obj = new ArrayList();
            obj.Add(10);
            obj.Add("Alisha");
            obj.Add(true);
            obj.Add(1.2345);
            obj.Add(22.999);
            obj.Insert(0, "Inserted");

            ArrayList obj2 = new ArrayList();
            obj2.Add(10);
            obj2.Add(30);

            obj.AddRange(obj2);
            obj.InsertRange(0, obj2);
            obj.Remove("Alisha");
            obj.RemoveAt(0);
            //obj.RemoveAt(1);
            obj.RemoveRange(0, 3);
            //obj.Clear();

            //   Console.WriteLine(obj.Count);




            ArrayList obj3 = (ArrayList)obj.Clone();
            bool isFound = obj.Contains("Alisha");

            object[] arr = new object[obj.Count];
            obj.CopyTo(arr);

            object[] arr2 = obj.ToArray()!;

            ArrayList obj4 = obj.GetRange(0, 3);



            ArrayList obj5 = new ArrayList();
            obj5.Add(100);
            obj5.Add(200);
            obj5.Add(300);

            obj.SetRange(0, obj5);
            Console.WriteLine(obj.Count);
            foreach (object item in obj)
            {
                Console.WriteLine(item);
            }
        }

        static void Main2()
        {
            ArrayList objArrList = new ArrayList();
            Console.WriteLine($"Count={objArrList.Count}, Capacity={objArrList.Capacity}");//Count=0, Capacity=0

            objArrList.Add("a");
            Console.WriteLine($"Count={objArrList.Count}, Capacity={objArrList.Capacity}");//Count = 1, Capacity = 4

            objArrList.Add("a");
            Console.WriteLine($"Count={objArrList.Count}, Capacity={objArrList.Capacity}");//Count = 2, Capacity = 4

            objArrList.Add("a");
            Console.WriteLine($"Count={objArrList.Count}, Capacity={objArrList.Capacity}");//Count = 3, Capacity = 4


            objArrList.Add("a");
            Console.WriteLine($"Count={objArrList.Count},Capacity={objArrList.Capacity}");//Count = 4,Capacity = 4

            objArrList.Add("a");
            Console.WriteLine($"Count={objArrList.Count},Capacity={objArrList.Capacity}");

            objArrList.TrimToSize();
            Console.WriteLine($"After Trim Count={objArrList.Count},Capacity={objArrList.Count}");






        }

        static void Main3()
        {
            Hashtable objDictionary = new Hashtable();

            //   SortedList objDictionary = new SortedList();
            objDictionary.Add(10, "Alisha");
            objDictionary.Add(20, "Sweety");
            objDictionary.Add(80, "Shweta");
            objDictionary.Add(40, "Shruti");
            objDictionary.Add(50, "Alis");
            objDictionary.Add(60, "Nupur");


            objDictionary[10] = "ChangedValue";
            objDictionary[10] = "NewValue";

            objDictionary.Remove(10);
            // objDictionary.RemoveAt(0);//Hashtable Does not contain def for RemoveAt
            objDictionary.Contains(20);
            objDictionary.ContainsKey(2);
            objDictionary.ContainsValue(40);
            //objDictionary.GetByIndex(Index);//Hashtable Does not contain def for GetByIndex
            //objDictionary.GetKey(Index);

            // IList keys = objDictionary.GetKeyList();
            //IList values = objDictionary.GetValueList();


            // objDictionary.IndexOfKey();
            //objDictionary.IndexOfValue();





        }


        static void Main4()
        {
            Stack s = new Stack();
            s.Push("pa");
            Console.WriteLine(s.Peek());
            Console.WriteLine(s.Pop());

            Queue q = new Queue();
            q.Enqueue(10);
            Console.WriteLine(q.Peek());
            Console.WriteLine(q.Dequeue());

        }

        static void Main5()
        {
            List<int> lst1 = new List<int>();
            lst1.Add(10);
            foreach (int item in lst1)
            {

            }
            List<Employee> lst2 = new List<Employee>();
            lst2.Add(new Employee { EmpNo = 1, Name = "a" });
            lst2.Add(new Employee { EmpNo = 2, Name = "b" });
            lst2.Add(new Employee { EmpNo = 3, Name = "c" });

            foreach (Employee item in lst2)
            {
                Console.WriteLine(item.EmpNo);
                Console.WriteLine(item.Name);
            }

        }



        static void Main6()
        {
            SortedList<int, string> s1 = new SortedList<int, string>();
            s1.Add(10, "Vikram");
            s1.Add(20, "Shweta");
            s1.Add(30, "Harsh");

            foreach (KeyValuePair<int, string> item in s1)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
            }

            SortedList<int, Employee> s2 = new SortedList<int, Employee>();
            s2.Add(1, new Employee { EmpNo = 1, Name = "a" });
            s2.Add(2, new Employee { EmpNo = 2, Name = "b" });
            s2.Add(3, new Employee { EmpNo = 3, Name = "c" });

            foreach (KeyValuePair<int, Employee> item in s2)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value.Name);
            }

        }
    }












    public class Employee
    {
        public int EmpNo { get; set; }//Auto Property
        public string? Name { get; set; }//Auto Property

    }
}