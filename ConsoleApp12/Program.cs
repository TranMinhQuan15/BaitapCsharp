// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
namespace LAP5_BT1
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = 10;
			int[] arr = new int[n];

			for (int i = 0; i < n; i++)
			{
				Console.Write(" a[{0}] = ", i);
				arr[i] = int.Parse(Console.ReadLine());
			}
			for (int i = 0; i < 10; i += 2)
			{
				Console.WriteLine(arr[i]);
			}



		}
	}
}