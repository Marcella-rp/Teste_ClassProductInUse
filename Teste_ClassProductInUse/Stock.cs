using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_ClassProductInUse
{
    public class Stock
    {
        public List<Product> StoredShampoo { get; private set; } = new();
        public List<Product> StoredCondicionador { get; private set; } = new();
        public List<Product> StoredPerfume { get; private set; } = new();


        public Product ProductRemovalFromStock(int productIndex, Category productType)
        {
            Product newProduct = new();

            switch (productType)
            {
                case Category.Shampoo:
                    return StoredShampoo.Pop(productIndex);

                case Category.Condicionador:
                    return StoredCondicionador.Pop(productIndex);

                case Category.Perfume:
                    return StoredPerfume.Pop(productIndex);

                default:
                    break;
            }
            return newProduct;
        }
    }
}
