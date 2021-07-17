using System;

namespace test22
{
    //基本クラス
    class BaseClass
    {
        //コンストラクタ
        public BaseClass (string s)
        {
            Console.WriteLine(s);
        }
    }

    //派生クラス
    class DerivedClass:BaseClass
    {
        public DerivedClass(string s1,string s2):base(s2)
        {
            Console.WriteLine(s1);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var c = new DerivedClass("Derived","Base");
        }
    }
}
