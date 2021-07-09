using System;

namespace test13
{
    class Car
    {
        //データメンバ
        public string name;
        public int seats;
        //コンストラクタ
        public Car()
        {
            seats = 4;
        }
        //string型のパラメーターを受け取るコンストラクタ
        public Car(string str)
        {
            seats = 4;
            name = str;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Car test = new Car();
            Console.WriteLine(test.name);
            Car test2 = new Car("マイカー");
            Console.WriteLine(test2.name);
        }
    }
}
