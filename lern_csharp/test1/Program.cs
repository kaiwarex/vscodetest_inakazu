using System;

namespace test1
{
    class Program
    {
        static void greeting()
        {
            Console.WriteLine("hello!!guys!!");
        }

        static void Main(string[] args)
        {
            int x = 5;
            if(x < 10)
            {
                x *= 10;
            }
            Console.WriteLine(x);
            greeting();
        }
    }
}
