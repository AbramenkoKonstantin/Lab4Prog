using System;
using System.IO;


namespace Lab4Prog
{
    class findFiles
    {
        private string pathToFile;
        private string keyword;

        public findFiles(string pathToFile, string keyword)
        {
            this.pathToFile = pathToFile;
            this.keyword = keyword;
        }

        public string PathToFile
        {
            get
            {
                return pathToFile;
            }
            set
            {
                pathToFile = value;
            }
        }

        public string Keyword
        {
            get
            {
                return keyword;
            }
            set
            {
                keyword = value;
            }
        }
        public void GetInfo()
        {
            DirectoryInfo di = new DirectoryInfo($@"{pathToFile}");

            Console.WriteLine("Поиск файлов удовлетворяющих вашим условиям:");
            foreach (var fi in di.GetFiles($"*{keyword}*.txt", SearchOption.AllDirectories))
            {
                Console.WriteLine(fi.FullName);
            }
        }
        
    }
}
