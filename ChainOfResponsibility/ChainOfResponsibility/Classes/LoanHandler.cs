using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Classes
{
    class LoanHandler : SupportHandler
    {
        public override bool Handle()
        {
            Console.WriteLine("\n======\n");
            Console.WriteLine("\nКредитний план");
            Console.WriteLine("1 - Дострокове погашення");
            Console.WriteLine("2 - Прострочення платежу");
            Console.WriteLine("3 -  Проблеми із застосунком");
            Console.WriteLine("\n======\n");
            Console.Write("Ваш вибір: ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.WriteLine("Запит на дострокове погашення прийнято");
                    return true;
                case "2":
                    Console.WriteLine("Ми надішлемо вам інструкції щодо погашення боргу");
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
