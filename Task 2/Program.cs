using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Temp\Random.txt";
            string directoryPath = Path.GetDirectoryName(path);
            Random random = new Random();

            if (!Directory.Exists(directoryPath))
                Directory.CreateDirectory(directoryPath);

            using (StreamWriter sw = new StreamWriter(path, false))
                {
                    for (int i = 0; i < 10; i++)
                    {
                        sw.WriteLine(random.Next(0, 10));
                    }
                }

            int sumResult = 0;
            using (StreamReader sr = new StreamReader(path))
            {
                for (int i = 0; i < 10; i++)
                {
                    int sum = Convert.ToInt32(sr.ReadLine());
                    sumResult += sum;
                }
                Console.WriteLine(sumResult);
            }
            Console.ReadKey();
        }
    }
}
