// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
namespace Lab3_BT1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.Write("Cho vao a = ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("cho vao b = ");
            b = Convert.ToInt32(Console.ReadLine());
            if (b == 0)
            { Console.WriteLine("Error: divided by zero"); }
            else
            {
                float c = (float)a / b;
                Console.WriteLine("C = " + c);

            }
            Console.ReadKey();
        }
    }
}