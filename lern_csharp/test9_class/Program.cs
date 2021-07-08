using System;

namespace test9_class
{
    class Car
    {
        //データ部分
        public string name;
        public int seats = 4;
    }
    class TestClass
    {
        public int CalcAdd2(int a,int b,int c)
        {
            //パラメーターのa,b,c
            return a + b + c;
        }
    }
    class Program
    {
        static void HikakuAddress()
        {
            //比較用インスタンス
            Car m1 = new Car();
            Car m2 = new Car();
            Car m3 = m2;

            if(m1 == m2)
            {
                Console.WriteLine("この2つのインスタンスは同じ物である");
            }
            else
            {
                Console.WriteLine("この2つのインスタンスは異なる物である");
            }

            if(m3 == m2)
            {
                Console.WriteLine("この2つのインスタンスは同じ物である");
            }
            else
            {
                Console.WriteLine("この2つのインスタンスは異なる物である");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Car mycar = new Car();
            mycar.name = "ティムポカー";
            Console.WriteLine(mycar.name);
            Console.WriteLine(mycar.seats);
            HikakuAddress();
        }
    }
}
