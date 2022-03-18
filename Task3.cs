using System;
using System.Linq;

namespace ConsoleApp3
{
	public static class Task3
	{
		public static void Run()
		{
			Console.WriteLine("Wpisz liczbe binarna.");
			string choosen = Console.ReadLine();
			Console.WriteLine($"Wybrałeś: {choosen}");
			string trimmed = choosen.Trim('0');

			//1 sposób
			string[] splitted = trimmed.Split("0").Where(item => !string.IsNullOrWhiteSpace(item)).ToArray();
			Console.WriteLine($"Dziury: {splitted.Length - 1}");

			//2 sposób
			int counter = 0;
			for(int index = 0; index < trimmed.Length; index++)
			{
				bool isOne = trimmed[index] == '1';
				bool beforZero = index - 1 >= 0 && trimmed[index - 1] == '0';
				if (isOne && beforZero)
					counter++;
			}

			Console.WriteLine($"Dziury: {counter}");
		}
	}
}
