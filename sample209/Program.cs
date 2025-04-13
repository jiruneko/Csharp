using System;
using System.Collections.Generic;
using System.Text;

namespace Sample209
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1から3の整数を入力:");
            int num = int.Parse(Console.ReadLine());
            if (num == 1)
            {
                Console.WriteLine("one");
            }
            else if (num == 2)
            {
                Console.WriteLine("two");
            }
            else if (num == 3)
            {
                Console.WriteLine("three");
            }
            else
            {
                Console.WriteLine("不適切な値です");
            }
        }
    }
}