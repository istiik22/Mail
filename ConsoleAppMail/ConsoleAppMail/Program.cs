using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMail
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //создаем новое письмо
            //пишем в письме нужную нам информацию
            Console.WriteLine("Введите письмо:");
            string let = Console.ReadLine();
            Letter a = new Letter(let);

            //при надобности, добавляем
            Console.WriteLine("Хотите что-либо добавить?(Введите да/нет)");
            string control = Console.ReadLine();
            if(control == "да")
            {
                Dopolnenie();
                Console.WriteLine("Хотите отправить файл? (Введите да / нет)");
                string res = Console.ReadLine();
                Otprav(res);
            }
            else
            {
                Console.WriteLine("Хотите отправить файл? (Введите да / нет)");
                //запрос на отправление файла
                string res = Console.ReadLine();
                Otprav(res);
                
            }

            void Otprav(string res)
            {                               
                if (res == "да")
                {
                    //Кидаем письмо в файл в папку
                    Console.WriteLine("Введите адрес почты:");
                    string mail = Console.ReadLine();
                    Otrpavka otrpavka = new Otrpavka(mail);
                    otrpavka.NameOtpravka(mail, a.ToString());
                }
                else
                {
                    //запрос на удаление файла
                    Console.WriteLine("Удалить письмо? (Введите да / нет)");
                    if (res == "да")
                    {
                        a.DeleteLetter();
                    }
                    else
                    {
                        Dopolnenie();
                    }
                }
            }

            //записивыет дополнение в наше письмо
            void Dopolnenie()
            {
                Console.WriteLine("Введите дополнение к письму");
                string dopletter = Console.ReadLine();
                a.AddLetter(dopletter);
            }
        }
    }
}
