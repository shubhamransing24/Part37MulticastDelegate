using System;

namespace Part37MulticastDelegate
{
    class Program
    {
        public delegate void MultiDelegate();

        static void Main(string[] args)
        {
            MultiDelegate mlt = new MultiDelegate(Hello1);
            mlt += (Hello2);
            mlt += (Hello3);
            mlt();
            
        }
        public static void Hello1()
        {
            Console.WriteLine("Hello1");
        }
        public static void Hello2()
        {
            Console.WriteLine("Hello2");
        }
        public static void Hello3()
        {
            Console.WriteLine("Hello3");
        }
    }
}
