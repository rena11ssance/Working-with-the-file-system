using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Temp\3Task.txt";

            int charCount = 0;
            int lineCount = 0;
            int wordCount = 0;

            using (StreamReader sr = new StreamReader(path))
            {
                string line = "";
                while ((line = sr.ReadLine()) != null)
                {
                    lineCount++;
                    charCount += line.Length;

                    string[] words = line.Split();
                    wordCount += words.Length;
                }
                
                Console.WriteLine("Количество символов: {0}.", charCount);
                Console.WriteLine("Количество слов: {0}.", wordCount);
                Console.WriteLine("Количество строк: {0}.", lineCount);
            }

            Console.ReadKey();
        }
    }
}
