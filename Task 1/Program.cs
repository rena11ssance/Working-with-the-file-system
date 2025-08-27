using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Temp";

            DirectoryInfo directoryInfo = new DirectoryInfo(path);

            if (!directoryInfo.Exists)
            {
                Console.WriteLine("Указанный путь не существует.");
                return;
            }

            DirectoryInfo[] allFolders = directoryInfo.GetDirectories("*", SearchOption.AllDirectories);
            foreach (DirectoryInfo folder in allFolders)
            {
                Console.WriteLine("Папки: {0}.", folder.FullName);
            }


            FileInfo[] allFiles = directoryInfo.GetFiles("*", SearchOption.AllDirectories);
            foreach (FileInfo files in allFiles)
            {
                Console.WriteLine("Файлы: {0}.", files.FullName);
            }

            Console.ReadKey();
        }
    }
}
