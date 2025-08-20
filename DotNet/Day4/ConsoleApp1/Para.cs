namespace ParamsExample
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            Console.WriteLine(Add(10, 20));
            Console.WriteLine(Add(10, 20, 30, 40, 50, 60, 70));

        }
        
        static int Add(params int[] arr)
        {
            int sum = 0;
            foreach (int item in arr)
            {
                sum += item;
            }
            return sum;
        }
    }
}
