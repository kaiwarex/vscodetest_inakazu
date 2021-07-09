using System;

namespace test17
{
    class Car
    {
        public string name;
        public static int seats;
        public Car()
        {
            name = "マイカー";
        }
        //静的メソッド
        public static void SetSeat(int n)
        {
            seats = n;
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
            Car.SetSeat(5);

            Car test = new Car();
            test.Display(); //5
            Car test2 = new Car();
            test2.Display(); //5
        }
    }
}
