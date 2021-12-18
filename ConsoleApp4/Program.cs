// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
namespace baitap5
{ class Program
  {
    static void Main(string[] args)
    {
        Console.WriteLine("km taxi:");
        float km = float.Parse(Console.ReadLine());
        if (km <= 1)
        {
            float tongtien = km * 15000;
            Console.WriteLine("km,tongtien", km, tongtien);
        }
        else if (km <= 5)
        {
            float tongtien = (1 * 15000) + ((km - 1) * 13500);
            Console.WriteLine("km,tongtien", km, tongtien);
        }
        else if (km > 5)
        {
            float tongtien = (1 * 15000) + (4 * 13500) + ((km - 5) * 11000);
            Console.WriteLine("km,tongtien", km, tongtien);
        }
        else if (km > 120)
        {
            float tongtien = (float)((1 * 15000) + (4 * 13500) + ((km - 5) * 11000)) * 1 / 10;
            Console.WriteLine("km,tongtien", km, tongtien);
        }
        Console.ReadLine();
    }
  }
}