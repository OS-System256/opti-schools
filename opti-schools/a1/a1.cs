using System;
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
                new Program().Main0();
            }
            else
            {
                new Program().Main0();
            }
        }
    }    
}



