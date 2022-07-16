using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var tries = 0;

            Random random = new Random();
            
            var number = random.Next(0, 100);

            Console.WriteLine("Odgadnij liczbę od 0 - 100.");

            while(true)
            {
                Console.WriteLine("Podaj liczbę:");
                var userNumber = GetNumber();

                if (userNumber < number)
                {
                    Console.WriteLine("Twoja liczba jest za mała. Spróbuj ponownie!");
                    tries++;
                    continue;
                }
                if (userNumber > number)
                { 
                    Console.WriteLine("Twoja liczba jest za duża. Spróbuj ponownie!");
                    tries++;
                    continue;
                }
                else
                    Console.WriteLine("Udało Ci się odgadnąć liczbę! Wylosowana liczba to: {0}. Liczba prób: {1}", number, tries);
                break;
            }
        }

        private static int GetNumber()
        {
            while(true)
            {
                if(!int.TryParse(Console.ReadLine(), out int number) || number < 0 || number > 100)
                {
                    Console.WriteLine("Podałeś nieprawidłowe dane! To musi być liczba od 0 - 100");
                    continue;
                }
                return number;
            }
        }
    }
}
