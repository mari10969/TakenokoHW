using System;

namespace Homework4
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("私の好きな色は？");
                Console.WriteLine("1.ピンク 2.黒 3.黄色 4.青");
                var line = Console.ReadLine();
                if (line == "2")
                {
                    Console.WriteLine("Correct!!");
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect");
                }

            }
            Console.WriteLine("EnterKeyで終了します。");
            Console.ReadLine();
           

        }
    }
}
