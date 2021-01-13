using System;

namespace Homework8
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowTakenokoList();
        }
        private static void ShowTakenokoList()
        {
            var numberlist = new Int32[4];
            numberlist[0] = 1;
            numberlist[1] = 3;
            numberlist[2] = 6;
            numberlist[3] = 10;

            for( int i = 0; i <numberlist.Length; i++)
            {
                Console.WriteLine("たけのこの数は" + numberlist[i]);
            }
            Console.ReadLine();
        }
    }
}
