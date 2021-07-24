using System;

namespace test29
{
    class SampleClass
    {
        public string Type {get;set;} = "nothing";
        public string Name {get;} = "abc";
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var test = new SampleClass();
            Console.WriteLine(test.Type);   //nothing
            Console.WriteLine(test.Name);   //abc
        }
    }
}
