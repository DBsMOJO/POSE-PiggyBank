/*--------------------------------------------------------------
 *				HTBLA-Leonding / Class: 3.ACIF
 *--------------------------------------------------------------
 *              Daniel Binder, 11.11.2023
 *--------------------------------------------------------------
 * Description:
 * Calculating a savings balance
 *--------------------------------------------------------------
*/

using System;

namespace PiggyBank
{
    public class Program
    {
        public static void Main()
        {
            int ec20,
                ec50,
                euro,
                euro2,
                cent;
            double result;

            // Input
            Console.Write("\nWie viele 20 Euro-Cent-Stücke? ");
            ec20 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Wie viele 50 Euro-Cent-Stücke? ");
            ec50 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Wie viele 1 Euro-Stücke?       ");
            euro = Convert.ToInt32(Console.ReadLine());
            Console.Write("Wie viele 2 Euro-Stücke?       ");
            euro2 = Convert.ToInt32(Console.ReadLine());

            // Process
            result = (euro2 * 2) + euro + (ec50 / (double)2) + (ec20 / (double)5);
            cent = Convert.ToInt32(result * 100);
            euro = cent / 100;
            cent %= 100;

            // Out
            Console.WriteLine($"Dein Sparschwein enthält {result:0.00} Euro!");
            Console.WriteLine($"Dein Sparschwein enthält {euro} Euro und {cent} Euro-Cent!");
        }
    }
}
