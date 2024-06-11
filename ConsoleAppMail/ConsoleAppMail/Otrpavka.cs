using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleAppMail
{
    internal class Otrpavka
    {
        //сохраняет письмо в файл в папку Mail
        string name;
        public Otrpavka(string name)
        {
            this.name = name;
        }
        //создание файла с именем почты и текстом письма, которое хотим отправить
        public void NameOtpravka(string name,string text)
        {
            System.IO.File.WriteAllText($"Mail\\{name}.txt", text);
        }
    }
}
