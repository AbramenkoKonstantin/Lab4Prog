using System;
using System.IO;
using System.Xml.Serialization;

namespace Lab4Prog
{
    class TextFile
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string MiddleName { get; set; }
        public TextFile(string name, string surname, string middle)
        {
            Name = name; Surname = surname; MiddleName = middle;
        }
        public void Serialize(FileStream fs)
        {
            XmlSerializer bf = new XmlSerializer(this.GetType());
            bf.Serialize(fs, this);
            fs.Flush();
            fs.Close();
        }
        public void Deserialize(FileStream fs)
        {
            XmlSerializer bf = new XmlSerializer(this.GetType());
            TextFile deserialized = (TextFile)bf.Deserialize(fs);
            Name = deserialized.Name;
            Surname = deserialized.Surname;
            MiddleName = deserialized.MiddleName;
            fs.Close();
        }
        public void Print()
        {
            Console.WriteLine("Name={0} Surname={1} Middle={2}", Name, Surname, MiddleName);
        }
    }
}
