using System;
using System.Linq;

namespace ConsoleApp3
{
	public static class Task2
	{
		public static void Main()
		{
			Console.WriteLine("Wyświetl liczbę unikatowych wartości");
			string choosen = Console.ReadLine();
			Console.WriteLine($"Wybrałeś: {choosen}");
			int result = choosen.Where(item => char.IsNumber(item)).Distinct().Count();
			Console.WriteLine($"Wpisałeś unikalne {result} licz");
		}
	}
}
