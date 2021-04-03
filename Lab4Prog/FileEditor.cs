using System;
using System.IO;
using System.Text;

namespace Lab4Prog
{
    class FileEditor : IOriginator
    {
        private string path;
        public string text;

        public FileEditor()
        {

        }
        public FileEditor(string path)
        {
            this.path = path;
        }

        public FileEditor(string path, string text)
        {
            this.path = path;
            this.text = text;
        }

        public void GetText(string path)
        {
            try
            {
                using (var sr = new StreamReader(path))
                {
                    Console.WriteLine(sr.ReadToEnd());
                }

            }

            catch (IOException e)
            {
                Console.WriteLine("Файл не может быть прочитан: ");
                Console.WriteLine(e.Message);
            }
        }

        public void GetInfo(string text)
        {
            try
            {
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

        public object GetMemento()
        {
            return new Memento { text = this.text, path = this.path };
        }

        public void SetMemento(object memento)
        {
            if (memento is Memento)
            {
                var mem = memento as Memento;
                text = mem.text;
                path = mem.path;
            }
        }
    }
}
