// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
namespace lab3_BT7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("       MENU       ");
            Console.WriteLine("==================");
            Console.WriteLine("1.  CF");
            Console.WriteLine("2.  C");
            Console.WriteLine("3.  HDJ");
            Console.WriteLine("4.  DreamWeaver");
            Console.WriteLine("5.  RDBMS");
            Console.WriteLine("6.  Learn Java By Examples");
            Console.WriteLine("==================");
            Console.Write("Chon : ");
            byte a = byte.Parse(Console.ReadLine());
            if (a == 1)
            {
                Console.WriteLine(" Chon CF");
            }
            else if (a == 2)
            {
                Console.WriteLine(" Chon C");
            }
            else if (a == 3)
            {
                Console.WriteLine(" Chon HDJ");
            }
            else if (a == 4)
            {
                Console.WriteLine(" Chon DreamWeaver!");
            }
            else if (a == 5)
            {
                Console.WriteLine(" Chon RDBMS");
            }
            else if (a == 6)
            {
                Console.WriteLine(" Chon Learn Java By Examples");
            }
            else
            {
                Console.WriteLine(" Vui long chon so co trong MENU");
            }

        }
    }
}