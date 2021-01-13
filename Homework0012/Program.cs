using System;

namespace Homework0012
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("計算方法を選んでください。");
                Console.WriteLine("1.足し算 2.引き算　3.掛け算　4.割り算");

                var line = Console.ReadLine();

                Console.WriteLine("数字を入力してください。");
                var number1 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("もう一つの数字を入力してください。");
                var number2 = Int32.Parse(Console.ReadLine());

                if (line == "1")
                {
                    var result = number1 + number2;
                    Console.WriteLine("結果は");
                    Console.WriteLine(result);
                }

                if (line == "2")
                {
                    var result = number1 - number2;
                    Console.WriteLine("結果は");
                    Console.WriteLine(result);
                }

                if (line == "3")
                {
                    var result = number1 * number2;
                    Console.WriteLine("結果は");
                    Console.WriteLine(result);
                }

                if (line == "4")
                {
                    var result = number1 / number2;
                    Console.WriteLine("結果は");
                    Console.WriteLine(result);
                }
                Console.WriteLine("もう一度計算する");
                Console.WriteLine("1.Yes 2.No");
                var yesno =Console.ReadLine();
                if (yesno == "2")
                {
                    break;
                }
            }
            Console.WriteLine("EnterKeyで終了。");
            Console.ReadLine();

        }
    
    }
}