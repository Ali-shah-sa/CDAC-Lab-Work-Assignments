namespace ConsoleApp1
{
    internal class Program
    {
        static void oldMain()
        {
            class1 obj = new class1();
            obj.Seti(100);
            Console.WriteLine(obj.Geti());
        }
        static void Main11()
        {
            class2 obj = new class2();
            obj.I = 99;//set
            Console.WriteLine(obj.I);//get



            obj.P1 = "ALisha";
            Console.WriteLine(obj.P1);

            Console.WriteLine(obj.P2);
            
            obj.P3 = "aaa";
            Console.WriteLine(obj.P3);


            obj.P4 = "bbb";
            Console.WriteLine(obj.P4);

            obj.P5 = "cccc";
            Console.WriteLine(obj.P5);


        }
    }
    public class class1
    {
        private int i;
        public void Seti(int value)
        {
            if (i <= value)
                i = value;
            else
            
                Console.WriteLine("Invalid value");
            
        }
        public int Geti(){ return i; }
    }
    public class class2
    {
        private int i;
        //property
        public int I
        {
            set
            {
                if(value<=100)
                    i=value;
                else
                    Console.WriteLine("Invalid value");
            }
            get { return i; }   
        }

        private string p1 = "default";
        public string P1
        {
            set
            {
                if (value != "")
                    p1 = value;
                else
                    Console.WriteLine("Can not be blank");

            }
            get { return p1; }
        }
        //read only
        private string p2= "def";
        public string P2
        {
            get { return p2; }  
        }

        private string p3 = "Default";
        public string P3
        {
            set
            {
                p3 = value;
            }
            get { return p3; }

        }
        public string P4;

        public string P5 { get; set; }


    }






}
