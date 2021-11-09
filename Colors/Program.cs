using System;
using System.IO;

namespace Colors
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your favorite color:");
            string userSign = Console.ReadLine();
            Console.WriteLine(GetColors(userSign));
        }
        public static string[] ReadColors()
        {
            string filePath = @"C:\Users\admin\samples\personality.txt";
            string[] dataFromFile = File.ReadAllLines(filePath);
            return dataFromFile;
        }

        public static string GetColors(string userInput)
        {
            string[] colors = ReadColors();
            string favColors = "";

            foreach (string element in colors)
            {
                if (element.Contains(userInput))
                {
                    favColors = element;
                }
            }

            return favColors;
        }
    }
}
