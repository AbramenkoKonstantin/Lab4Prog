using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4Prog
{
    public class Memento
    {
        public string text { get; set; }
        public string path { get; set; }
    }
    public class Caretaker
    {
        private object memento;
        public void SaveState(IOriginator originator)
        {
            memento = originator.GetMemento();
        }

        public void RestoreState(IOriginator originator)
        {
            originator.SetMemento(memento);
        }
    }
    public interface IOriginator
    {
        object GetMemento();
        void SetMemento(object memento);
    }
}
