using System;
using System.Linq;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            var dict = new Dictionary<string, double[]>();

            while (true)
            {
                if (input[0] == "buy")
                {
                    break;
                }

                var product = input[0];
                var price = double.Parse(input[1]);
                var quantity = int.Parse(input[2]);

                if (!dict.ContainsKey(product))
                {
                    dict[product] = new double[] { price, quantity };
                }
                else
                {
                    double[] productInfo = dict[product];
                    double existingPrice = productInfo[0];
                    int existingQuantity = (int)productInfo[1];

                    if (existingPrice != price)
                    {
                        productInfo[0] = price;
                    }
                    productInfo[1] = existingQuantity + quantity;
                }


                input = Console.ReadLine().Split();
            }

            foreach (KeyValuePair<string, double[]> product in dict)
            {
                string name = product.Key;
                double price = product.Value[0];
                int quantity = (int)product.Value[1];
                double totalPrice = price * quantity;
                Console.WriteLine($"{name} -> {totalPrice:F2}");
            }
        }
    }
}

