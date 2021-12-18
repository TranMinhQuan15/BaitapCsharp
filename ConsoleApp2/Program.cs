// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
namespace lab3_BT3
{
    class Program
    {
        static void Main(string[] args)
        {
            float a = 5.4f, b = 4, c = 7.5f, d = 10;

            if (a > b)
            {
                {
                    if (a > c)

                    {
                        if (a > d)
                        {
                            Console.WriteLine("M = " + a + " m = " + b);
                        }
                        else
                        {
                            Console.WriteLine("M = " + d + " m = " + b);
                        }
                    }
                    else
                    {
                        if (c > d)
                        {
                            Console.WriteLine("M = " + c + " m = " + b);
                        }
                        else
                        {
                            Console.WriteLine("M = " + d + " m = " + b);
                        }
                    }
                }
            }

            else
            {
                if (b > c)
                {
                    if (b > d)
                    {
                        Console.WriteLine("M = " + b + " min = " + a);
                    }
                    else
                    {
                        Console.WriteLine("M = " + d + " min = " + a);
                    }
                }
                else
                {
                    if (c > d)
                    {
                        Console.WriteLine("M = " + c + " m = " + a);
                    }
                    else
                    {
                        Console.WriteLine("M = " + d + " m = " + a);
                    }
                }

            }
        }
    }
}