using System;

namespace Homework5
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowPoifulList("ポイフル");
        }
        private static void ShowPoifulList(String name)
        {
            var numberList = GetNumberList_Pattern2();
            for (int i = 0; i < numberList.Length; i++)
            {
                Console.WriteLine(name + "の数は" + numberList[i] + "です。");
            }
            Console.ReadLine();
        }
        private static String ReturnText()
        {
            return "Mari";
        }
        private static Int32 [] GetNumberList_Pattern1()
        {
            var numberList = new Int32[3];
            numberList[0] = 1;
            numberList[1] = 4;
            numberList[2] = 5;
            return numberList;
        }
        private static Int32[] GetNumberList_Pattern2()
        {
            var numberList = new Int32[5];
            numberList[0] = 3;
            numberList[1] = 7;
            numberList[2] = 11;
            numberList[3] = 17;
            numberList[4] = 19;
            return numberList;
        }
            
    }
}
