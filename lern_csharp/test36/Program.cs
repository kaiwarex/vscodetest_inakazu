using System;

namespace test36
{
    class SampleClass
    {
        //フィールド
        public int v1 = 10;
        private int v2;
        //既定のコンストラクタ
        public SampleClass()
        {
            Console.WriteLine(this.v1);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var test = new SampleClass{v1 = 20};
            Console.WriteLine(test.v1); 
        }
    }
}
