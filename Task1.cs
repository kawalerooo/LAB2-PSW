using System;

public static class Task1
{
	internal static void Main()
	{
	
		int liczba = (RandomNumbers.NextNumber() % 1000);
		Console.Write("Podaj liczbe od 1 do 1000.");
		Console.Write("\n");
		int strzal;
		int liczbastrzalow = 0;
		strzal = int.Parse(ConsoleInput.ReadToWhiteSpace(true));
		do
		{
			if (strzal > 1000)
			{
				Console.Write("Podaj liczbe od 1 do 1000!");
				Console.Write("\n");
				strzal = int.Parse(ConsoleInput.ReadToWhiteSpace(true));
			}
			else
			{
				liczbastrzalow++;
			}

			if (strzal > liczba)
			{
				Console.Write("Wylosowana liczba jest mniejsza od Twojej typowanej.");
				Console.Write("\n");
				Console.Write("Sprobuj ponownie.");
				Console.Write("\n");
				strzal = int.Parse(ConsoleInput.ReadToWhiteSpace(true));
			}
			else
			{
				Console.Write("Wylosowana liczba jest wieksza od Twojej typowanej. Sprobuj ponownie.");
				Console.Write("\n");
			}

			strzal = int.Parse(ConsoleInput.ReadToWhiteSpace(true));
		} while (strzal != liczba);

		Console.Write("Brawo, trafiles we wlasciwa liczbe! Dana liczba bylo ");
		Console.Write(liczba);
		Console.Write(". Strzelales ");
		Console.Write(liczbastrzalow);
		Console.Write(" razy!");
		Console.Write("\n");

	}
}

internal static class RandomNumbers
{
	private static System.Random r;

	public static int NextNumber()
	{
		if (r == null)
			Seed();

		return r.Next();
	}

	public static int NextNumber(int ceiling)
	{
		if (r == null)
			Seed();

		return r.Next(ceiling);
	}

	public static void Seed()
	{
		r = new System.Random();
	}

	public static void Seed(int seed)
	{
		r = new System.Random(seed);
	}
}


internal static class ConsoleInput
{
	private static bool goodLastRead = false;
	public static bool LastReadWasGood
	{
		get
		{
			return goodLastRead;
		}
	}

	public static string ReadToWhiteSpace(bool skipLeadingWhiteSpace)
	{
		string input = "";

		char nextChar;
		while (char.IsWhiteSpace(nextChar = (char)System.Console.Read()))
		{
			
			if (!skipLeadingWhiteSpace)
				input += nextChar;
		}
		
		input += nextChar;

	
		while (!char.IsWhiteSpace(nextChar = (char)System.Console.Read()))
		{
			input += nextChar;
		}

		goodLastRead = input.Length > 0;
		return input;
	}

	public static string ScanfRead(string unwantedSequence = null, int maxFieldLength = -1)
	{
		string input = "";

		char nextChar;
		if (unwantedSequence != null)
		{
			nextChar = '\0';
			for (int charIndex = 0; charIndex < unwantedSequence.Length; charIndex++)
			{
				if (char.IsWhiteSpace(unwantedSequence[charIndex]))
				{
					
					while (char.IsWhiteSpace(nextChar = (char)System.Console.Read()))
					{
					}
				}
				else
				{
					nextChar = (char)System.Console.Read();
					if (nextChar != unwantedSequence[charIndex])
						return null;
				}
			}

			input = nextChar.ToString();
			if (maxFieldLength == 1)
				return input;
		}

		while (!char.IsWhiteSpace(nextChar = (char)System.Console.Read()))
		{
			input += nextChar;
			if (maxFieldLength == input.Length)
				return input;
		}

		return input;
	}
}
