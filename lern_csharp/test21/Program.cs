using System;

namespace test21
{
    //基本クラス
    class Music
    {
        public Music()
        {
            Console.WriteLine("基本クラスのコンストラクタ");
        }
    }
    //派生クラス
    class Song:Music
    {
        public string Key = "C#";
        public Song()
        {
            Console.WriteLine("派生クラスのコンストラクタ");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Song s = new Song();
        }
    }
}
