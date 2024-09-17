using System;
namespace fds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            bool b = true;
            for (int i = 0; i < str.Length / 2; i++)
            {
                if (str[i] != str[str.Length - i - 1]) { b = false; }
            }
            Console.WriteLine(b);
            Console.ReadKey();
        }
    }
}