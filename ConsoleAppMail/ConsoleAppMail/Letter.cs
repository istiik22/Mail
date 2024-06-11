using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMail
{
    internal class Letter
    {
        //отвечает за содержимое письма
        string letter;
        public Letter(string letter)
        {
            this.letter = letter;
        }
        //добавление в письмо
        public void AddLetter(string let1)
        {
            letter+=let1 + "\n";
        }
        //удаление письма
        public void DeleteLetter()
        {
            letter = "";
        }
    }
}
