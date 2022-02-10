using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork8_List
{
    public class Product
    {
        public string Name { get; set; }
        public DateTime DateProduction { get; set; }
        public int DaysExpiration { get; set; }
        public int Price { get; set; }

        public Product(string name, DateTime dateProduction, int daysExpiration, int price)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            DateProduction = dateProduction;
            DaysExpiration = daysExpiration;
            Price = price;
        }

        public DateTime GetDateEnd()
        {
            return DateProduction.AddDays(DaysExpiration);
        }

        public override string ToString()
        {
            return $"{Name} | {DateProduction.ToString("d")} | Годен до: {GetDateEnd().ToString("d")} | {Price}$";
        }
    }
}
