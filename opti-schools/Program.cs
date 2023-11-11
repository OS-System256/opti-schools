using System;

namespace opti_schools
{
    class Program
    {
        static void Main()
        {
            object start_menu_object;
            int start_menu_int;
            Console.WriteLine("ВНИМАНИЕ! Перед использованием этой прогаммы прочитайте информацию о даной программе на репозитории GitHab от автора даной программы, а именно от OS-System256, в разделе wiki или по ссылке: https://github.com/OS-System256/opti-schools/wiki \n");
            Console.Write("::Выберите действие: \n 1)Ввывод ШДЗ на следующий день \n 2)Ввод ШДЗ \n нажмите Enter для выбора по умолчанию (по умолчанию 1): ");
            start_menu_object = Console.ReadLine();
            start_menu_int = Convert.ToInt32(start_menu_object);
            if (start_menu_int == 1)
            {
                object a;
                string a0;
                Console.Write("есть изменение в расписании? [y/n] ");
                a = Console.ReadLine();
                a0 = Convert.ToString(a);
                a = "Введите";
                if (a0 == "" )
                {
                    Console.Write(a + "назввние первого урока или n (при отсутствии этого урока): ");
                }
            }

        }
    }
}
