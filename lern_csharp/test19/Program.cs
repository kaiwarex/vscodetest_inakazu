using System;

namespace test19
{
    //基本クラス
    class Music
    {
        public int Type = 0;
        public string Name = "Music";
        public void BaseInfo()
        {
            Console.WriteLine("Music");
        }
    }
    //サブクラス
    class Song:Music
    {
        public string Key = "C#";
        public void DrvInfo()
        {
            Console.WriteLine("Song");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Song s = new Song();

            Console.WriteLine(s.Key);
            s.DrvInfo();

            //基本クラスのメンバにアクセスできる
            Console.WriteLine(s.Type);
            s.BaseInfo();

            Music m = new Music();

            Console.WriteLine(m.Type);
            m.BaseInfo();
        }
    }
}
