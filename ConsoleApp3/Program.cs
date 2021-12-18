// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
namespace Lap3_BT4
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b, c;
            Console.WriteLine("Nhap canh thu 1: ");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap canh thu 2: ");
            b = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap canh thu 3: ");
            c = float.Parse(Console.ReadLine());
            if (a + b >= c || a + c >= b || b + c >= a)
            {
                Console.WriteLine(" 3 canh cua tam giac");
            }
            else
            {
                Console.WriteLine(" khong phai 3 canh cua tam giac");
            }

        }
    }
}