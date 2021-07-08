using System;

namespace test10_class
{
    class TestClass
    {
        public int CalcAdd2(int a,int b,int c)
        {
            return a + b + c;
        }
        //省略可能なパラメーターをもつメソッド
        public void PrintName(int no,string name = "no name")
        {
            Console.WriteLine(no + "→" + name);
        }
        //int型の可変パラメーターを合計する
        public int SumAll(params int[] numary)
        {
            int sum = 0;
            //numaryの要素をforeachで取り出して合計する
            foreach(int n in numary)
            {
                sum += n;
            }
            return sum;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            TestClass test = new TestClass();

            //パラメーターの混在
            int a = test.CalcAdd2(3,c:4,b:2);
            Console.WriteLine(a);   //9
            test.PrintName(10);
            Console.WriteLine(test.SumAll(1,2));
            Console.WriteLine(test.SumAll(5,10,15));
            Console.WriteLine(test.SumAll());
        }
    }
}
