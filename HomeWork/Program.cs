using System;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("私が飼っているペット");
            Console.WriteLine("1.犬 2.魚 3.猫 4.鳥 ");
            var line = Console.ReadLine();
            if (line == "3")
            {
                Console.WriteLine("Coreect :)");
            }
            else
            {
                Console.WriteLine("Incorrect :(");
            }
            Console.WriteLine("ENTERkeyで終了");
            Console.ReadLine();
        }
    }
}
