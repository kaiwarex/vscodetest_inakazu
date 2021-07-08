using System;

namespace test5
{
    class Program
    {
        static void do_loop()
        {
            Console.WriteLine("doループ");
            int i = 10;
            do
            {
                Console.WriteLine(++i);
            }
            while(i < 5);
        }
        static void Main(string[] args)
        {
            do_loop();
            Console.WriteLine("Hello World!");
            int i = 0;
            while(i < 3)
            {
                Console.WriteLine(i++);
            }
        }
    }
}
