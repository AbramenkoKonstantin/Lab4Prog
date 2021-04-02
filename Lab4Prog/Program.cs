using System;
using System.IO;
using System.Text;


namespace Lab4Prog
{
    public class Program
    {
        static void Main(string[] args)
        {
        ReturnProg:
            Console.WriteLine("Выберите: \n1) Сериализация\n2) Поиск текстового файла по ключевым словам\n3) Отредактировать файл ");
            string change = Console.ReadLine();
            switch (change)
            {
                case "1":
                    Console.WriteLine("Binary: ");
                    FileStream fsB = new FileStream("d:\\FullNameSerialize.bin", FileMode.OpenOrCreate, FileAccess.Write);
                    Binary fncB = new Binary("Ivan", "Ivanov", "Ivanovich");
                    fncB.Print();
                    fncB.Serialize(fsB);
                    fncB = new Binary("Petr", "Petrov", "Petrovich");
                    fncB.Print(); 
                    fsB = new FileStream("d:\\FullNameSerialize.bin", FileMode.OpenOrCreate, FileAccess.Read);
                    fncB.Deserialize(fsB);
                    fncB.Print();
                    Console.WriteLine("");
                    Console.WriteLine("Xml: ");
                    FileStream fsX = new FileStream("d:\\FullNameSerialize.xml", FileMode.OpenOrCreate, FileAccess.Write);
                    Xml fncX = new Xml("Ivan", "Ivanov", "Ivanovich");
                    fncX.Print();
                    fncX.Serialize(fsX);
                    fncX = new Xml("Petr", "Petrov", "Petrovich");
                    fncX.Print();
                    fsX = new FileStream("d:\\FullNameSerialize.xml", FileMode.OpenOrCreate, FileAccess.Read);
                    fncX.Deserialize(fsX);
                    fncX.Print();
                    break;

                case "2":
                    Console.Write("Введите путь: ");
                    string pathToFile = Console.ReadLine();
                    Console.Write("Введите ключевое слово: ");
                    string keyword = Console.ReadLine();
                    FindFiles files = new FindFiles(pathToFile, keyword);
                    files.GetInfo();
                    break;

                case "3":
                    Console.WriteLine("Введите путь: ");
                    string path = Console.ReadLine();
                    FileEditor editor = new FileEditor(path);
                    editor.GetInfo();
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
