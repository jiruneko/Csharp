using System;

namespace HelloWorld
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int someValue = GetValue();

            if (someValue > 100)
            {
                Console.WriteLine(someValue);
            }
        }

        private static int GetValue()
        {
            return 150; // 例: 150 を返す
        }
    }
}
