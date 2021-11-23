using System;
using System.IO;

namespace Week13_Test
{
    class Program
    {
        static void Main(string[] args)
        {

            string rootDirectory = $@"C:\Users\opilane\samples";

            Console.WriteLine("Enter the folder's name:");
            string userFolder = Console.ReadLine();

            string newDirectoryFullPath = @$"{rootDirectory}\{userFolder}";
            bool directoryExists = Directory.Exists(newDirectoryFullPath);

            if (directoryExists)
            {
                Console.WriteLine($"{userFolder} already exists in Samples.");
                char userInput = Convert.ToChar(Console.ReadLine().ToLower());

            }
            else
            {
                Directory.CreateDirectory(newDirectoryFullPath);
                Console.WriteLine($"{userFolder} does not exist. {userFolder} has been created");

            }
        }
    }
}
