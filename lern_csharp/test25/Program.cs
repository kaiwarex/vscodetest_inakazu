using System;

namespace test25
{
    //基本クラス
    class BaseClass
    {
        public int Type = 0;
    }
    class NewClass:BaseClass
    {
        //同じフィールドを定義
        new public int Type =  1;
        //typeフィールドの値の表示
        public void print()
        {
            Console.WriteLine(this.Type);
            Console.WriteLine(base.Type);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            NewClass n = new NewClass();
            n.print();
        }
    }
}
