using System;
using System.IO;

namespace opti_schools
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("ВНИМАНИЕ! Перед использованием этой прогаммы прочитайте информацию о даной программе на репозитории GitHab от автора даной программы, а именно от OS-System256, в разделе wiki или по ссылке: https://github.com/OS-System256/opti-schools/wiki \n");
            new Program().Main0();
        }
        public void Main0()
        {
            object start_menu_object;
            string start_menu_string;
            Console.Write("::Выберите действие: \n  1)Ввывод ШДЗ на следующий день \n  2)Ввод ШДЗ \n  3)Изменить постоягое расписание \n  q)Выход \nнажмите Enter для выбора по умолчанию (по умолчанию 1): ");
            start_menu_object = Console.ReadLine();
            start_menu_string = Convert.ToString(start_menu_object);
            if (start_menu_string == "1")
            {
                new a1.a1().Opti();
            }
            if (start_menu_string == "" )
            {
                new a1.a1().Opti();
            }
            if (start_menu_string == "2")
            {
                new Work().домашка();
            }
            if (start_menu_string == "3")
            {
                string a;
                string fly;
                string fill;
                string a0 = "понедельник";
                a0 = "превый";
                Console.Write("Введите " + a0 + " предмет из расписания (из 20 предметов): ");
                a = Console.ReadLine();
                fill = @"$HOME\AppData\Local\opti-schools\1.txt";
                using (StreamWriter txt = new StreamWriter(fill))
                {
                    txt.Write(a);
                }
                a0 = "второй";
                Console.Write("Введите " + a0 + " предмет из расписания (из 20 предметов): ");
                a = Console.ReadLine();
                fill = @"$HOME\AppData\Local\opti-schools\2.txt";
                using (StreamWriter txt = new StreamWriter(fill))
                {
                    txt.Write(a);
                }
                a0 = "третий";
                Console.Write("Введите " + a0 + " предмет из расписания (из 20 предметов): ");
                a = Console.ReadLine();
                fill = @"$HOME\AppData\Local\opti-schools\3.txt";
                using (StreamWriter txt = new StreamWriter(fill))
                {
                    txt.Write(a);
                }
                a0 = "четвёртый";
                Console.Write("Введите " + a0 + " предмет из расписания (из 20 предметов): ");
                a = Console.ReadLine();
                fill = @"$HOME\AppData\Local\opti-schools\4.txt";
                using (StreamWriter txt = new StreamWriter(fill))
                {
                    txt.Write(a);
                }
                a0 = "пятый";
                Console.Write("Введите " + a0 + " предмет из расписания (из 20 предметов): ");
                a = Console.ReadLine();
                fill = @"$HOME\AppData\Local\opti-schools\5.txt";
                using (StreamWriter txt = new StreamWriter(fill))
                {
                    txt.Write(a);
                }
                a0 = "шестой";
                Console.Write("Введите " + a0 + " предмет из расписания (из 20 предметов): ");
                a = Console.ReadLine();
                fill = @"$HOME\AppData\Local\opti-schools\6.txt";
                using (StreamWriter txt = new StreamWriter(fill))
                {
                    txt.Write(a);
                }
                a0 = "седьмой";
                Console.Write("Введите " + a0 + " предмет из расписания (из 20 предметов): ");
                a = Console.ReadLine();
                fill = @"$HOME\AppData\Local\opti-schools\7.txt";
                using (StreamWriter txt = new StreamWriter(fill))
                {
                    txt.Write(a);
                }
                a0 = "восьмой";
                Console.Write("Введите " + a0 + " предмет из расписания (из 20 предметов): ");
                a = Console.ReadLine();
                fill = @"$HOME\AppData\Local\opti-schools\8.txt";
                using (StreamWriter txt = new StreamWriter(fill))
                {
                    txt.Write(a);
                }
                a0 = "девятый";
                Console.Write("Введите " + a0 + " предмет из расписания (из 20 предметов): ");
                a = Console.ReadLine();
                fill = @"$HOME\AppData\Local\opti-schools\9.txt";
                using (StreamWriter txt = new StreamWriter(fill))
                {
                    txt.Write(a);
                }
                a0 = "десятый";
                Console.Write("Введите " + a0 + " предмет из расписания (из 20 предметов): ");
                a = Console.ReadLine();
                fill = @"$HOME\AppData\Local\opti-shools\10.txt";
                using (StreamWriter txt = new StreamWriter(fill))
                {
                    txt.Write(a);
                }
            }
            if (start_menu_string == "q")
            {
                return;
            }
        }
    }
}
