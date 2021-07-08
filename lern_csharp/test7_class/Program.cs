using System;

namespace test7_class
{
    class Car
    {
        //データ部分
        string name;
        int seats = 4;
        //処理部分
        // static void PrintInfo()
        // {
        //     Console.WriteLine(name);
        //     Console.WriteLine(seats);
        // }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Car mycar = new Car();
            mycar.name = "マンコカー";
            Console.WriteLine(mycar.name);  //マンコカー
            Console.WriteLine(mycar.seats);　//4
        }
    }
}
