using System;

namespace test26
{
    //基本クラス
    class Music
    {
        public virtual void BaseInfo()
        {
            Console.WriteLine("Music");
        }
    }
    //派生クラス
    class Music2:Music
    {
        public override void BaseInfo()
        {
            Console.WriteLine("Song");
        }
    }
    //派生クラス
    // class Music２:Music
    // {
    //     new public void BaseInfo()
    //     {
    //         Console.WriteLine("Music2");
    //     }
    // }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Song s = new Song();
            s.BaseInfo();

            Music2 m2 = new Music2();
            m2.BaseInfo();

            Music m = new Music();
            m.BaseInfo();
        }
    }
}
