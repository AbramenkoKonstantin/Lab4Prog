using System;
using System.IO;


namespace Lab4Prog
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите путь: ");
            string pathToFile = Console.ReadLine();
            Console.Write("Введите ключевое слово: ");
            string keyword = Console.ReadLine();
            findFiles files = new findFiles(pathToFile, keyword) ;
            files.GetInfo();
        }
    }
}
