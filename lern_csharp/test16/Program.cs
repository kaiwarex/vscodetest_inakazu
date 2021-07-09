using System;

namespace test16
{
    class Car
    {
        public string name; //インスタンスメンバ
        public static int seats;　//静的メンバ
        public Car()
        {
            name = "マイカー";
        }
        public void Display()
        {
            Console.WriteLine(seats);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Car.seats = 5;
            //インスタンス生成
            Car test = new Car();
            test.Display();
            //別のインスタンスでも静的フィールドの値は同じになる
            Car test2 = new Car();
            test2.Display();    //5
        }
    }
}
