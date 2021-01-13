using System;

namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowPoifulList();
        }
        private static void ShowPoifulList()
        {
            var numberList = new Int32[5];
            numberList[0] = 4;
            numberList[1] = 6;
            numberList[2] = 9;
            numberList[3] = 10;
            numberList[4] = 14;

            for(int i =0; i<numberList.Length; i++)
            {
                Console.WriteLine("ポイフルの数は" + numberList[i]);
            }
            Console.ReadLine();
        }
    }
}
