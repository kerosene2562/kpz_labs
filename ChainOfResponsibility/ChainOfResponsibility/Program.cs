using System.Text;
using ChainOfResponsibility.Classes;
class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        var main = new MainHandler();
        var tarif = new TarifHandler();
        var app = new AppHandler();
        var security = new SecurityHandler();
        var loan = new LoanHandler();

        main.SetNext(tarif).SetNext(loan).SetNext(app).SetNext(security);

        bool resolved = false;
        while (!resolved)
        {
            Console.WriteLine("\n Головне меню");
            Console.WriteLine("1 - Продовжити");
            Console.WriteLine("2 - Вийти");
            Console.Write("Ваш вибір: ");
            string input = Console.ReadLine();

            if (input == "1")
            {
                resolved = main.Handle();

                if (!resolved)
                {
                    Console.WriteLine("\nУпс, почнімо спочатку!\n");
                }
            }
            else if (input == "2")
            {
                Console.WriteLine("До побачення!");
                break;
            }
            else
            {
                Console.WriteLine("Неправильний вибір!");
            }
        }
    }
}