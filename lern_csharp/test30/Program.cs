using System;
using test30.inakazulib;

namespace test30
{
    //基本クラス
    class Music
    {
        //仮想メソッド→抽象メソッドみたいな感じ
        public virtual void BaseInfo()
        {
            Console.WriteLine("Music");   
        }
    }
    //派生クラス
    class Song:Music
    {
        public override void BaseInfo()
        {
            Console.WriteLine("Song");
        }
    }
    //派生クラス
    class Music2:Music
    {
        new public void BaseInfo()
        {
            Console.WriteLine("Music2");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Song s = new Song();
            s.BaseInfo();   //Song

            Music2 m2 = new Music2();
            m2.BaseInfo();  //Music2

            Music m = new Music();
            m.BaseInfo();//Music

            // TestSample01 ts01 = new TestSample01();
            // ts01.DispAuthName();

            BaseMusic bm = new BaseMusic();
            bm.PrintName();

            SubMusic sm = new SubMusic();
            sm.PrintName();
        }
    }
}
