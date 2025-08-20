
namespace Example4
{
    class Program
    {
        static void Main1()
        {
            //Task<int> t1 = new Task<int>(new Func<int>(Func1));
            Task<int> t1 = new Task<int>(Func1);
            t1.Start();

            Task<int> t2 = new Task<int>(Func2, "passed value");
            t2.Start();

            Console.WriteLine("finish other code");

            //get the return value
            //if(!t1.IsCompleted)
            //{
            //    t1.Wait();
            //}
            Console.WriteLine(t1.Result); //waiting call
            Console.WriteLine(t2.Result); //waiting call

            Console.ReadLine();
        }
        static void Main2()
        {
            Task<int> t1 = Task.Factory.StartNew<int>(Func1);
            Task<int> t2 = Task.Run<int>(Func1);

            Console.WriteLine(t1.Result);
            Console.WriteLine(t2.Result);

            Task<int> t3 = Task.Factory.StartNew<int>(Func2, "passed value"); ;
            Console.WriteLine(t3.Result);



        }

        static int Func1()
        {
            int i;
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("first Func called {0}", i);
            }
            return i;
        }
        static int Func2(object obj)
        {
            int i;
            for (i = 0; i < 20; i++)
            {
                Console.WriteLine("second Func called {0},{1}", i, obj.ToString());
            }
            return i;
        }
    }
}