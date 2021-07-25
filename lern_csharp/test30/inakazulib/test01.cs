using System;

namespace test30.inakazulib
{
    // class TestSample01
    // {
    //     //testメソッド
    //     public void DispAuthName()
    //     {
    //         Console.WriteLine("稲員です");
    //     }
    // }

    //基本クラス
    class BaseMusic
    {
        int type = 0;
        protected string name = "BaseMusic";
        //typeフィールドに値を設定するpublicメソッド
        public void SetType(int type)
        {
            this.type = type;
        }
        //フィールドの値を出力する仮想メソッド
        public virtual void PrintName()
        {
            Console.WriteLine(type);
            Console.WriteLine(name);        }      
    }
    //派生クラス
    class SubMusic:BaseMusic
    {
        public override void PrintName()
        {
            //this.type = 1;
            this.name = "SubMusic";
            base.PrintName();
        }
    }

}