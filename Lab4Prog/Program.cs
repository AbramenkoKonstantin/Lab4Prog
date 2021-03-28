using System;
using System.IO;


namespace Lab4Prog
{
    class Program
    {
        static void Main(string[] args)
        {
        ReturnProg:
            Console.WriteLine("Выберите: \n1) Сериализация\n2) Поиск текстового файла по ключевым словам");
            string change = Console.ReadLine();
            switch (change)
            {
                case "1":
                    FileStream fs = new
                    FileStream("c:\\FullNameSerialize.bin",
                    FileMode.OpenOrCreate, FileAccess.Write);
                    TextFile fnc = new TextFile("Ivan", "Ivanov", "Ivanovich");
                    fnc.Print();
                    fnc.Serialize(fs);
                    fnc = new TextFile("Petr", "Petrov", "Petrovich");
                    fnc.Print();
                    fs = new
                    FileStream("c:\\FullNameSerialize.bin",
                    FileMode.OpenOrCreate, FileAccess.Read);
                    fnc.Deserialize(fs);
                    fnc.Print();
                    break;

                case "2":
                    Console.Write("Введите путь: ");
                    string pathToFile = Console.ReadLine();
                    Console.Write("Введите ключевое слово: ");
                    string keyword = Console.ReadLine();
                    findFiles files = new findFiles(pathToFile, keyword);
                    files.GetInfo();
                    break;
            }
            Console.WriteLine("Повторить?(Да или нет)");
            string returnProg = Console.ReadLine();
            if (returnProg == "Да" || returnProg == "да")
            {
                goto ReturnProg;
            }
            else Console.ReadKey();
        }
    }
}
