using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_ClassProductInUse
{
    public class Product
    {
        public Category Category { get;  private set; }
        public Usage Usage { get; private set; }
        public string Name { get; private set; }
        public string Brand { get; private set; }
        public decimal Price { get; private set; }
        public  int TotalVolume { get; private set; }
        public  int CurrentVolume { get; private set; }
        public DateTime ExpirationDate { get; private set; }
        public Species Species { get; private set; }

        public Product()
        {

        }

        public Product(Category category, Usage usage, string name, string brand, decimal price,
            int totalVolume, DateTime expirationDate, Species species)
        {
            Category = category;
            Usage = usage;
            Name = name;
            Brand = brand;
            Price = price;
            TotalVolume = totalVolume;
            CurrentVolume = totalVolume;
            ExpirationDate = expirationDate;
            Species = species;
        }

        public int spendProduct(int toExpendVolume)
        {
            return CurrentVolume -= toExpendVolume;
        }
        public int spendProductV(int toExpendVolume)
        {
            return CurrentVolume = TotalVolume - toExpendVolume + CurrentVolume;
        }
        public  int spendProductVT(int toExpendVolume)
        {
            return CurrentVolume = TotalVolume - toExpendVolume;
        }
       
    }
}
