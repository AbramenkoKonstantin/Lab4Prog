using System;
using System.IO;


namespace Lab4Prog
{
    class FindFiles
    {
        private string pathToFile;
        private string keyword;

        public FindFiles(string pathToFile, string keyword)
        {
            this.pathToFile = pathToFile;
            this.keyword = keyword;
        }

        public void GetInfo()
        {
            DirectoryInfo di = new DirectoryInfo(pathToFile);

            Console.WriteLine("Поиск файлов удовлетворяющих вашим условиям:");
            foreach (var fi in di.GetFiles($"*{keyword}*.txt", SearchOption.AllDirectories))
            {
                Console.WriteLine(fi.FullName);
            }
        }
        
    }
}
