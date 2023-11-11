using System;

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
                Console.Write("У вас есть список всех предметов из которого состоит расписание или вам не трубуется измениение этого списка [y/n] ");
                start_menu_string = Console.ReadLine();
                if (start_menu_string == "y")
                {
                    new Program().Main0();
                }
                if (start_menu_string == "n")
                {
                    new Work().расписание();
                }
            }
            if (start_menu_string == "q")
            {
                return;
            }
        }
    }
}
