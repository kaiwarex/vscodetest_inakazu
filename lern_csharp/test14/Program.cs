using System;

namespace test14
{
    class Car
    {
        //フィールド
        public string name = "マイカー";
        public int seats;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car test = new Car();
            Car test2 = new Car();

            test2.name = "サブ";

            Console.WriteLine("Hello World!");
            Console.WriteLine(test.name);
            Console.WriteLine(test2.name);
        }
    }
}
