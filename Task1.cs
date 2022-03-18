using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    class Task1
    {

        static void Main(string[] args)
        {
            Random rand = new Random();
            int guess = 0;
            string welcome = "Proszę wprowadzić liczbę z zakresu 1-100";
            int num = rand.Next(1, 100);
            Console.WriteLine(welcome);


            int i = 0;

            while (guess != num)
            {
                try
                {
                    guess = Convert.ToInt32(Console.ReadLine());

                    if (guess > num)
                    {
                        Console.WriteLine("Za wysoka wartość");
                    }
                    else
                    {
                        Console.WriteLine("Za mała wartość");
                    }
                }

                catch
                {
                    Console.WriteLine("Wprowadzona wartość musi być liczbą");
                    i--;
                }


                i++;
            }
            Console.WriteLine("Udało Ci się zgadnąć liczbę. Probowałeś " + i + " razy");
            Console.ReadLine();
        }
    }
