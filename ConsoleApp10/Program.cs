// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
namespace LAB4_BT5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, sum = 0, m;
            Console.Write("Nhap so bat ky: ");
            n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                m = n % 10;
                sum = sum + m;
                n = n / 10;
            }
            Console.Write("Tong cac so la " + sum);
        }
    }
}