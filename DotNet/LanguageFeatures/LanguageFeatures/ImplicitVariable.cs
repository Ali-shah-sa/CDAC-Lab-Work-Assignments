namespace ImplicitVariables
{
    internal class ImplicitVariable
    {
        static void Main1()
        {
            int i = 100;
            var j = 100;

            j = 200;
            Console.WriteLine(j);
            Console.WriteLine(j.GetType());
            // j = "aa";
            var k = "aaa";
            Console.WriteLine(k);



        }
    }
}
