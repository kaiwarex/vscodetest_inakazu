using System;

namespace test11
{
    class TestClass
    {
        //aを3倍して表示する
        public void TestFunc(ref int a)
        {
            a *= 3;
            Console.WriteLine(a);
        }
        //inキーワードをつかったメソッド定義
        public void testmethod(in int num,out string s)
        {
            if(num == 46)
            {
                s = "keyaki";
            }
            else
            {
                s = "abc";
            }
        }
        public ref int TestFunc2(ref int a)
        {
            a *= 3;
            return ref a;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            TestClass test = new TestClass();
            int a = 5;
            //int b = 5;
            var n = 46;
            var str = "none";
            test.TestFunc(ref a);//15
            Console.WriteLine(a);//15
            test.testmethod(n,out str);
            Console.WriteLine(str);

            ref int c = ref test.TestFunc2(ref a);
            Console.WriteLine(a);
            Console.WriteLine(c);

            c = 10;
            Console.WriteLine(a);
            Console.WriteLine(c);
        }
    }
}
