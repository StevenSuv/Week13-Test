using System;
using System.IO;

namespace Ylesanne_5
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine(GetRandomFact());
        }

        public static string GetRandomFact()
        {
            string filePath = @"C:\Users\opilane\samples\test\funFacts.txt";
            string[] funFactsOMG = File.ReadAllLines(filePath);
            Random rnd = new Random();
            int randomIndex = rnd.Next(1, funFactsOMG.Length);
            Console.WriteLine(funFactsOMG[0]);

            return funFactsOMG[randomIndex];
        }
    }
}
