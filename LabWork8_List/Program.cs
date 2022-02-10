using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork8_List
{
    class Program
    {
        private static Random rnd = new Random();
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            var listProducts = new List<Product>();
            for (int i = 1; i <= 7; i++)
            {
                var name = "Product" + i;
                var dateProduction = new DateTime(2022, 1, 25).AddDays(rnd.Next(-5, 5));
                var dateExpiration = rnd.Next(10, 60);
                var price = rnd.Next(10, 50);
                listProducts.Add(new Product(name, dateProduction, dateExpiration, price));
            }

            Console.WriteLine("Все продукты:");
            OutputList(listProducts);

            var listProductsUnfit = listProducts.Where(p => p.GetDateEnd() > DateTime.Today);
            Console.WriteLine("Продукты, у которых срок годности истек:");
            OutputList(listProductsUnfit);

            var listProductsThirty = listProducts.Where(p => p.DaysExpiration < 30);
            Console.WriteLine("Продукты, у которых срок годности заканчивается в течение 30 суток:");
            OutputList(listProductsThirty);

            Console.ReadLine();
        }

        private static void OutputList(IEnumerable<Product> list)
        {
            Console.WriteLine();
            if (list.Count() > 0)
            {
                Console.WriteLine("__________________________________________________________________");
                foreach (var item in list)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("__________________________________________________________________");
            }
            else
            {
                Console.WriteLine("Список пуст.");
            }
            Console.WriteLine();
        }
    }
}
