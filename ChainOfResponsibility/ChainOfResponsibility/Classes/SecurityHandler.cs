using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Classes
{
    class SecurityHandler : SupportHandler
    {
        public override bool Handle()
        {
            Console.WriteLine("\n======\n");
            Console.WriteLine("\nНалаштування безпеки");
            Console.WriteLine("1 - Зміна PIN-коду");
            Console.WriteLine("2 - Підозрілий вхід");
            Console.WriteLine("3 -  Відправити звіт про операції");
            Console.WriteLine("\n======\n");
            Console.Write("Ваш вибір: ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.WriteLine("Щоб змінити PIN-код натисніть в налаштуваннях Новий пароль");
                    return true;
                case "2":
                    Console.WriteLine("Інцидент зафіксовано. Зв'яжемося з вами!");
                    return true;
                case "3":
                    Console.WriteLine("Ваш звіт надіслано в повідомленнях!");
                    return true;
                default:
                    Console.WriteLine("Неправильний вибір!");
                    return false;
            }
        }
    }
}
