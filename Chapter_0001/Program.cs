using System;

namespace Chapter_0001
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("私の好きな食べ物はどれでしょう？");
            Console.WriteLine("1.オムライス 2.たこ焼き 3.春巻き 4.餃子");
            //画面から入力した値を取得
            var line = Console.ReadLine();
            if (line == "1")
            {
                Console.Write("正解");
            }
            else
            {
                Console.WriteLine("不正解");
            }
            Console.WriteLine("Enterキーで終了します");
            Console.ReadLine();
        }

    }
}
