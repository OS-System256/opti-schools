using System;
using System.IO;
using System.Xml.Linq;

namespace opti_schools.a1
{
    public class a1
    {
        public void Opti()
        {
            object a;
            string a0;
            Console.Write("есть изменение в расписании? [y/n] ");
            a = Console.ReadLine();
            a0 = Convert.ToString(a);
            if (a0 == "y")
            {
                Console.Write("Первый урок: ");
                a = Console.ReadLine();
                a0 = @".\1.txt";
                using (StreamWriter txt = new StreamWriter(a0))
                {
                    txt.Write(a);
                }
                Console.Write("Второй урок: ");
                a = Console.ReadLine();
                a0 = @".\2.txt";
                using (StreamWriter txt = new StreamWriter(a0))
                {
                    txt.Write(a);
                }
                Console.Write("Третий урок: ");
                a = Console.ReadLine();
                a0 = @".\3.txt";
                using (StreamWriter txt = new StreamWriter(a0))
                {
                    txt.Write(a);
                }
                Console.Write("Четвёртый урок: ");
                a = Console.ReadLine();
                a0 = @".\4.txt";
                using (StreamWriter txt = new StreamWriter(a0))
                {
                    txt.Write(a);
                }
                Console.Write("Пятый урок: ");
                a = Console.ReadLine();
                a0 = @".\5.txt";
                using (StreamWriter txt = new StreamWriter(a0))
                {
                    txt.Write(a);
                }
                Console.Write("Шестой урок: ");
                a = Console.ReadLine();
                a0 = @".\6.txt";
                using (StreamWriter txt = new StreamWriter(a0))
                {
                    txt.Write(a);
                }
                Console.Write("Седьмой урок: ");
                a = Console.ReadLine();
                a0 = @".\7.txt";
                using (StreamWriter txt = new StreamWriter(a0))
                {
                    txt.Write(a);
                }
                new Work().домашка();
            }
            if (a0 == "n")
            {
                new Program().Main0();
            }
            else
            {
                new Program().Main0();
            }
        }
    }    
}



