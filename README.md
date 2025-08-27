# Работа с файловой системой

Задача. Выберите любую папку на своем компьютере, имеющую вложенные директории. Выведите на консоль ее содержимое и содержимое всех подкаталогов.

Решение: 
```
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

```
___
Задача. Программно создайте текстовый файл и запишите в него 10 случайных чисел. Затем программно откройте созданный файл, рассчитайте сумму чисел в нем, ответ выведите на консоль.

Решение:
```
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

```
___
Задача. Вручную подготовьте текстовый файл с фрагментом текста. Напишите программу, которая выводит статистику по файлу - количество символов, строк и слов в тексте.

Решение:
```
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
        }
    }
}

```
