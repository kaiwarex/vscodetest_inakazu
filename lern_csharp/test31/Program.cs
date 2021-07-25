using System;

namespace test31
{
    //スーパークラス
    class Music
    {
        int type = 0;
        protected string name = "Music";
        //typeフィールドに価を設定するpublicメソッド
        public void SetType(int type)
        {
            this.type = type;
        }
        //フィールドの価を出力する仮想メソッド
        public virtual void PrintName()
        {
            Console.WriteLine(type);
            Console.WriteLine(name);
        }
    }
    //派生クラス
    class Song:Music
    {
        public override void PrintName()
        {
            //this.type = 1;
            this.name = "Song";
            base.PrintName();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Song s = new Song();
            s.SetType(1);
            //s.name = "test";
            s.PrintName();
        }
    }
}
