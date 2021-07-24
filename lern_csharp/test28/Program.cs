using System;

namespace test28
{
    //基本クラス
    class Music
    {
        int type = 0;
        protected string name = "Music";
        // typeフィールドに値を設定するpublicメソッド
        public int Type
        {
            set
            {
                this.type = value;
            }
            get
            {
                return this.type;
            }
        }
        //フィールドの値を出力する仮想メソッド
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
            s.Type = 1;
            // s.name = "test";
            s.PrintName();
        }
    }
}
