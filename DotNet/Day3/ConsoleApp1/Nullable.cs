
namespace Nullable
{
    internal class Program
    {
        static void Main1()
        {
            int? i;
            i = 10;
            //i = null;

            int j;
            if (i != null)
                j = (int)i;
            else
                j = 0;

            if (i.HasValue)
                j = i.Value;
            else
                j = 0;

            j = i.GetValueOrDefault();
            j = i.GetValueOrDefault(100);

            j = i ?? 0; 

            Console.WriteLine(j);
        }
        static void Main()
        {
            string? s;
            s = Console.ReadLine();
        }
    }
}