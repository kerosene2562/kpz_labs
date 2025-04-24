using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Classes
{
    class MainHandler : SupportHandler
    {
        public override bool Handle()
        {
            Console.WriteLine("\n======\n");
            Console.WriteLine("\nВітаємо! Яке у вас питання?");
            Console.WriteLine("1 - Заблокувати картку");
            Console.WriteLine("2 - Замовити нову картку");
            Console.WriteLine("3 - Тарифний план");
            Console.WriteLine("\n======\n");
            Console.Write("Ваш вибір: ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.WriteLine("Щоб заблокувати картку оберіть в налаштуваннях відповідну функцію!");
                    return true;
                case "2":
                    Console.WriteLine("Натисніть в налаштуваннях Нова карта, наш оператор звяжеться з вами");
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
