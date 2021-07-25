using System;

namespace test32
{
    class SampleClass
    {
        //自動で内部的なstring型のフィールドが生成される
        public string Type{get;set;}
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var test = new SampleClass();

            test.Type = "A";
            Console.WriteLine(test.Type);
        }
    }
}
