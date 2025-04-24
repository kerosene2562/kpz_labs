using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Classes
{
    class AppHandler : SupportHandler
    {
        public override bool Handle()
        {
            Console.WriteLine("\n======\n");
            Console.WriteLine("\nНалаштування застосунку");
            Console.WriteLine("1 - Проблема з входом");
            Console.WriteLine("2 - Помилка при переказі коштів");
            Console.WriteLine("3 - Налаштування безпеки");
            Console.WriteLine("\n======\n");
            Console.Write("Ваш вибір: ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.WriteLine("Спробуйте перевстановити застосунок");
                    return true;
                case "2":
                    Console.WriteLine("Запит відправлено в техпідтримку");
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
