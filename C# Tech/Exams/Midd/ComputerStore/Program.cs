using System;
using System.Linq;
using System.Collections.Generic;

namespace ComputerStore
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            double sum = 0;
            double taxes = 0;

            double totalPrice = 0;
       
               while (input != "special" && input != "regular")
               {
                   if (input == "special")
                   {
                       break;
                   }
                   if (input == "regular")
                   {
                       break;
                   }
             
                   var converted = double.Parse(input);
             
                   if (converted > 0)
                   {
                       totalPrice += converted;
                   }
                   else
                   {
                       Console.WriteLine("Invalid Price!");
                   }
               
             
               input = Console.ReadLine();
             }

            if (totalPrice == 0)
            {
                Console.WriteLine("Invalid order!");
                return;
            }

            var totalTaxes = totalPrice * 0.20;
            var totalTaxesPlusPrice = totalPrice + totalTaxes;
            var totalPriceWithTaxesAndDiscount = input == "special" ? totalTaxesPlusPrice * 0.9 : totalTaxesPlusPrice;

            Console.WriteLine("Congratulations you've just bought a new computer!");
            Console.WriteLine("Price without taxes: {0:F2}$", totalPrice);
            Console.WriteLine("Taxes: {0:F2}$", totalTaxes);
            Console.WriteLine("-----------");
            Console.WriteLine("Total price: {0:F2}$", totalPriceWithTaxesAndDiscount);
        }
    }
}

