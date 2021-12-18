// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
namespace lap3_BT2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Tinh Phuong trinh bac 2");
            Console.Write("Nhap a = ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap b = ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap c = ");
            c = Convert.ToInt32(Console.ReadLine());

            if (a == 0)
            {
                if (b == 0)
                { Console.WriteLine("PT vo nghiem"); 
                }
                else if
                   (c == 0)
                { Console.WriteLine(" PT nghiem x = 0"); }
                else
                { Console.Write("PT nghiem x = " + (-c / a)); 
                }
            }
            else
            {
                int d = b * b - 4 * a * c;
                if (d < 0)
                { Console.WriteLine("PT vo nghiem");
                }
                else if (d > 0)
                {

                    double x1 = (-b + Convert.ToDouble(Math.Sqrt(d)) / (2 * a));
                    double x2 = (-b - Convert.ToDouble(Math.Sqrt(d)) / (2 * a));
                    Console.WriteLine("PT co 2 nghiem x1 = {0} \n x2 = {1}", x1, x2);
                }
                else
                {
                    int x3;
                    x3 = (-b / (2 * a));
                    Console.Write("Phong trinh co nghiem kep: x1 = x2 = {0}", x3);
                }


            }

            Console.ReadKey();
        }
    }
}