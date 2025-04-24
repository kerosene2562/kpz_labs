using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Classes
{
    class TarifHandler : SupportHandler
    {
        public override bool Handle()
        {
            Console.WriteLine("\n======\n");
            Console.WriteLine("\nТарифний план");
            Console.WriteLine("1 - Тариф по акції");
            Console.WriteLine("2 - Змінити тариф");
            Console.WriteLine("3 - Кредитний план");
            Console.WriteLine("\n======\n");
            Console.Write("Ваш вибір: ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.WriteLine("Тариф по акції: Суперсила");
                    return true;
                case "2":
                    Console.WriteLine("Щоб змінити тариф натисніть в налаштуваннях Зміна Тарифу");
                    return true;
                case "3":
                    return next?.Handle() ?? false;
                default:
                    Console.WriteLine("Неправильний вибір!");
                    return false;
            }
        }
    }
}
