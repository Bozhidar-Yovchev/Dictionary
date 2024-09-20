using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            var shop = new Dictionary<string, Dictionary<string, double>>();
            string line;

            Console.WriteLine("Enter magazine, product, price or Revision to end the program");
            while ((line = Console.ReadLine()).ToLower() != "Revision")
            {

                var tokens = Console.ReadLine().Split(',');
                var magazine = tokens[0];
                var product = tokens[1];
                var price = double.Parse(tokens[2]);

                if (!shop.ContainsKey(magazine))
                {
                    shop.Add(magazine, new Dictionary<string, double>());
                }
                shop[magazine].Add(product, price);
            }

            foreach (var item in shop)
            {
                var shopName = item.Key;
                Console.WriteLine($"{shopName}:");
                foreach (var itemshop in item.Value)
                {
                    var productName = itemshop.Key;
                    var productPrice = itemshop.Value;
                    Console.WriteLine($"Product: {productName}, Price: {productPrice}");
                }
            }
        }
    }
}
