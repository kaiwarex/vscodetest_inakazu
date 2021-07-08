using System;

namespace test8_class
{
    class Car
    {
        //フィールド
        public string name;
        public int seats = 4;
    }
    class TestClass00
    {
        //値を返さないパラメータのないメソッド
        public void PrintOne()
        {
            Console.WriteLine("1");
        }
        public int MyMethod00()
        {
            return 10;
        }
        public int MyMethod01(int a)
        {
            if(a < 3)
            {   
                Console.WriteLine("aが3未満なので、メソッドを終了します");
                return a;
            }
            //aが3以上なら実行される
            return a;
        }
        //2つのパラメータを受けとってint型の値を返す
        public int CalcAdd(int a,int b)
        {
            return a + b;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            TestClass00 test00 = new TestClass00();
            test00.PrintOne();  //1
            test00.MyMethod00();    //10
            if(test00.MyMethod00() == 10){
                Console.WriteLine("メソッドの戻り値は10だよ");
            }
            Console.WriteLine(test00.MyMethod01(10));
            int p = 4;
            Console.WriteLine(test00.CalcAdd(3,p));
            //--------------------
            Car mycar = new Car();
            //比較用インスタンス
            Car mycar1 = new Car();
            Car mycar2 = new Car();
            //インスタンスの代入
            Car mycar3 = mycar2;

            //インスタンスを比較する
            Console.WriteLine(mycar1 == mycar2); //False

            //nameにセット
            mycar1.name = "チンコ";
            mycar2.name = "オメコ";
            mycar3.name = "ウンコ";

            mycar.name = "マンコカー";
            Console.WriteLine("Hello World!");
            Console.WriteLine(mycar.name);
            Console.WriteLine(mycar.seats);
            Console.WriteLine(mycar1.name);
            Console.WriteLine(mycar2.name);
            Console.WriteLine("-------------");
            Console.WriteLine(mycar2.name);
            Console.WriteLine(mycar3.name);

            //インスタンスを比較する
            if(mycar2 == mycar3){
                Console.WriteLine("同じアドレスだよ");
            }else{
                Console.WriteLine("違うアドレスだよ");
            }
        }
    }
}
