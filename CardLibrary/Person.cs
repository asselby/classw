using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardLibrary
{
    class Person
    {
        private string name;
        private string surname;
        private string historyOfIllness;

        public void SetName(string name)
        {
            Console.WriteLine("Введите имя: ");
            name = Console.ReadLine(); 
        }

        public void GetName(string name)
     }
}
