using System;

namespace test18
{
    class Car
    {
        public string name;
        public static int seats;
        public Car()
        {
            name = "マンコカー";
            Console.WriteLine(name);
        }

        //静的コンストラクタ
        static Car()
        {
            seats = 4;
            Console.WriteLine(seats);
        }

        //静的メソッド
        public static void SetSeat(int n)
        {
            seats = n; //静的メンバに代入           
        }

        public void Display(){
            Console.WriteLine(seats);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Car test = new Car();
            Car.SetSeat(5);
            Car test2 = new Car();
            test2.Display();
        }
    }
}
