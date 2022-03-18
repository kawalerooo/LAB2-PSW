using System;
public class Task5
{
    public static void Main(string[] args)
    {
        int n, i, m = 0, flag = 0;
        Console.Write("Wprowadź liczbę w celu jej weryfikacji: ");

        n = int.Parse(Console.ReadLine());
        m = n / 2;
        for (i = 2; i <= m; i++)
        {
            if (n % i == 0)
            {
                Console.Write("Podana liczba nie jest liczbą pierwszą !");
                flag = 1;
                break;
            }
        }
        if (flag == 0)
            Console.Write("Podana liczba jest liczbą pierwszą !");
    }
}
