using System;
using System.IO;
using System.Text;

namespace Lab4Prog
{
    class FileEditor
    {
        private string path;
        public string Text { get; set; }
        public FileEditor(string path)
        {
            this.path = path;
        }

        public void GetInfo()
        {
            try
            {
                using (var sr = new StreamReader(path))
                {
                    Console.WriteLine(sr.ReadToEnd());
                }

                Console.Write("Введите то, что хотите добавить в файл:");
                string text = Console.ReadLine();

                using (StreamWriter outputFile = new StreamWriter(path, true))
                {
                    outputFile.WriteLine(text);
                }
            }

            catch (IOException e)
            {
                Console.WriteLine("Файл не может быть прочитан: ");
                Console.WriteLine(e.Message);
            }
        }
    }
}
