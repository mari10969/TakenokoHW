using System;

namespace HomeWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("私の好きなサッカー選手は？");
            Console.WriteLine("1.香川選手 2.本田選手 3.浅野選手 4.南野選手 ");
            var line=Console.ReadLine();
            if(line=="3")
            {
                Console.WriteLine("正解");
            }
            else
            {
                Console.WriteLine("不正解");
            }
            Console.WriteLine("EnterKeyで終了します。");
            Console.ReadLine();
        }
    }
}
