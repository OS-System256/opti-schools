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
        internal void Main0()
        {
            object start_menu_object;
            string start_menu_string;
            Console.Write("::Выберите действие: \n  1)Ввывод ШДЗ на следующий день \n  2)Ввод ШДЗ \n  3)Изменить постоягое расписание \n  q)Выход \nнажмите Enter для выбора по умолчанию (по умолчанию 1): ");
            start_menu_object = Console.ReadLine();
            start_menu_string = Convert.ToString(start_menu_object);
            if (start_menu_string == "1")
            {
                
            }
            if (start_menu_string == "" )
            {
                
            }
            if (start_menu_string == "2")
            {
                
            }
            if (start_menu_string == "3")
            {
                //Console.Write("Требуется ли вам дополнить возможныне предметы в расписании ");
            }
            if (start_menu_string == "q")
            {
                return;
            }

        }
    }
}
