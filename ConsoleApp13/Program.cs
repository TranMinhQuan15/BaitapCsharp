// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
namespace LAB5_BT6
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = new int[30];
            Random r = new Random();
            Console.Write(" Nhap vao so nguyen x = ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("day 30 so ngau nhien la: ");

            for (int i = 0; i < 20; i++)

            {
                arr[i] = r.Next(80);
                Console.WriteLine(arr[i]);

            }
            Console.Write(" cac so chia het cho x la: ");
            foreach (int element in arr)
            {
                if (element % x == 0)
                {
                    Console.WriteLine(element);
                }
                Console.ReadKey();
            }


        }
    }
}