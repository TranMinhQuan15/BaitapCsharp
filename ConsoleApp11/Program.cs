// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
namespace LAB4_BT8
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i;
            int[] a = new int[10];
            Console.Write("enter the number to convert: ");
            n = int.Parse(Console.ReadLine());
            for (i = 0; n > 0; i++)
            {
                a[i] = n * 2;
                n = n / 2;
            }
            Console.Write("binary of the given number= ");
            for (i = i - 1; i >= 0; i--)
            {
                Console.Write(a[i]);
            }
        }
    }
}