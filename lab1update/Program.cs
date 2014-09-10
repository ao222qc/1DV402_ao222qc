using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab1update
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                double productValue = 0;  // Varans pris
                int total;                // Det avrundade priset du faktiskt betalar.
                int cashPayment = 0;      // Kontant betalning.
                double roundingOffAmount; // Belopp som avrundas.
                int cashReturn;           // Växel

                // ger vissa variabler ett "fast värde" då de inte garanterat får något genom readline (fel format t.ex)

                while (true)

                    try
                    {
                        Console.Write("Input total price: ");
                        productValue = double.Parse(Console.ReadLine());
                        break;
                    }
                    catch (FormatException)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Does not compute. Please enter a valid format.");
                        Console.ResetColor();
                    }

                if (Math.Round(productValue, MidpointRounding.AwayFromZero) < 1)
                {
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("The sum entered is too small and the transaction could not be made.");
                    Console.ResetColor();
                    return;
                }
                while (true)

                    try
                    {
                        Console.Write("Input cash payment: ");
                        cashPayment = int.Parse(Console.ReadLine());
                        break;
                    }
                    catch (FormatException)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Does not compute. Please enter a valid format.");
                        Console.ResetColor();
                    }

                if (productValue > cashPayment)
                {
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Payment does not cover the total price and the transaction could not be made.");
                    Console.ResetColor();
                    return;
                }

                Console.WriteLine("\n");
                Console.WriteLine("RECEIPT");
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("Price of product     :{0, 15:c}", productValue);
                total = (int)Math.Round(productValue);
                roundingOffAmount = total - productValue;
                Console.WriteLine("Sum rounded          :{0, 15:c}", roundingOffAmount);
                Console.WriteLine("Price to pay         :{0, 15:c}", total);
                Console.WriteLine("Sum payed in cash    :{0, 15:c}", cashPayment);
                cashReturn = cashPayment - total;
                Console.WriteLine("Change               :{0, 15:c}", cashReturn);
                Console.WriteLine("-------------------------------------");
                Console.Write("\n");


                if (cashReturn >= 500)
                {
                    Console.WriteLine("Amount of 500kr bills     : {0}", cashReturn / 500);
                    cashReturn = (cashReturn % 500);
                }

                if (cashReturn >= 100)
                {

                    Console.WriteLine("Amount of 100kr bills     : {0}", cashReturn / 100);
                    cashReturn = (cashReturn % 100);
                }

                if (cashReturn >= 50)
                {
                    Console.WriteLine("Amount of 50kr bills      : {0}", cashReturn / 50);
                    cashReturn = (cashReturn % 50);
                }


                if (cashReturn >= 20)
                {
                    Console.WriteLine("Amount of 20kr bills      : {0}", cashReturn / 20);
                    cashReturn = (cashReturn % 20);
                }

                if (cashReturn >= 10)
                {
                    Console.WriteLine("Amount of 10kr coins      : {0}", cashReturn / 10);
                    cashReturn = (cashReturn % 10);
                }

                if (cashReturn >= 5)
                {
                    Console.WriteLine("Amount of 5kr coins       : {0}", cashReturn / 5);
                    cashReturn = (cashReturn % 5);
                }

                if (cashReturn >= 1)
                {
                    Console.WriteLine("Amount of 1kr coins       : {0}", cashReturn / 1);
                    cashReturn = (cashReturn % 1);
                }
                Console.Write("\n");

                Console.WriteLine("Thank you for your purchase!");

                Console.Write("\n");
                Console.WriteLine("Press any key for next costumer or press ESCAPE to exit.");

                if (Console.ReadKey().Key == ConsoleKey.Escape) //Escape avslutar med en break, annan knapp rullar Whilen på.
                {
                    break;
                }

            }


        }

    }
}
