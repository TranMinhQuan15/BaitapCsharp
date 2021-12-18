// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
namespace LAB4_BT3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap 1so m: ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Nhap 1so n: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = m; i <= n; i++)
            {
                if (i % 7 == 0)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}