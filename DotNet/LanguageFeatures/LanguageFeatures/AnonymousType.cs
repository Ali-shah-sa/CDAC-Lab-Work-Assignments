namespace AnonymousTypes
{
    internal class program1
    {
        public static void Main2()
        {
            var obj = new { a = 1, b = "aaa", c = true };
            var obj2 = new { a = 2, b = "aaa", c = false, d = 1 };
            Console.WriteLine(obj.a);
            Console.WriteLine(obj2.a);
            Console.WriteLine(obj.b);

            Console.WriteLine(obj.GetType());
            Console.WriteLine(obj.GetType());

        }

    }
}