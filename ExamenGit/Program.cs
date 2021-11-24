using System;

namespace ExamenGit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ShowRand();
        }

        static void ShowRand()
        {
            Random rand = new Random();
            Console.WriteLine(rand.Next(0,100));
        }
    }
}
