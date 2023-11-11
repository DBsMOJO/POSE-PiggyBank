/*--------------------------------------------------------------
 *				HTBLA-Leonding / Class: 3.ACIF
 *--------------------------------------------------------------
 *              Daniel Binder, 11.11.2023
 *--------------------------------------------------------------
 * Description:
 *
 *--------------------------------------------------------------
*/

using System;

namespace PiggyBank
{
    class Program
    {
        public static void Main()
        {
            int ec20,
                ec50,
                e1,
                e2;
            double result;

            // Input
            Console.Write("\nWie viele 20 Euro-Cent-Stücke? ");
            ec20 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Wie viele 50 Euro-Cent-Stücke? ");
            ec50 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Wie viele 1 Euro-Stücke?       ");
            e1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Wie viele 2 Euro-Stücke?       ");
            e2 = Convert.ToInt32(Console.ReadLine());

            // Process
            result = (e2 * 2) + e1 + (ec50 * (50 / (double)100)) + (ec20 * (20 / (double)100));

            // Output
            Console.WriteLine($"{result:0.00}");
        }
    }
}
