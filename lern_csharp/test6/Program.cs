using System;

namespace test6
{
    class Program
    {
        //continue検証用メソッド
        static void Continue()
        {
            for(int i = 0;true;i++)
            {
                if(i < 8)
                {
                    //カウンター変数を更新してループの先頭に戻る
                    continue;
                }
                else if(i == 10)
                {
                    Console.WriteLine("カウンターが10になったんでbreakしますわ");
                    break;
                }
                Console.WriteLine(i);
            }
        }
        //break文献商用メソッド
        static void Break()
        {
            for(int i = 0;true;i++)
            {
                if(i == 3)
                {
                    Console.WriteLine("3なのでbreakしますわ");
                    break;
                }
                Console.WriteLine(i);
            }
        }
        //foreachループ検証用メソッド
        static void Foreach()
        {
            string[] j = {"グー","チョキ","パー"};

            //配列のデータを一つずつ取得できるっすよ
            foreach(string str in j)
            {
                Console.WriteLine(str);
            }
        }
        //doループ検証用メソッド
        static void Do_loop()
        {
            int i = 10;
            do
            {
                Console.WriteLine(++i);
            }
            while(i < 5);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Do_loop();
            Foreach();
            Break();
            Continue();
        }
    }
}
