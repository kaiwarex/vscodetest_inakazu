using System;

namespace test39
{
    class TestArray
    {
        //privateなので外部からはアクセス出来ない
        int[] array = new int[3];
        //インデクサの定義
        public int this[int index]
        {
            set
            {
                array[index] = value;
            }
            get
            {
                return array[index];
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var t = new TestArray();

            //配列のように代入出来る
            t[0] = 5;
            t[1] = 10;
            t[2] = 15;

            //配列のように参照できる
            Console.WriteLine(t[1]);    //出力値10
        }
    }
}
