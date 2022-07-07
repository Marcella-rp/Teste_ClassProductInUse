using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Teste_ClassProductInUse
{
    internal class ProductInUse
    {
        public List<Product> OpenShampoo { get; private set; } = new();
        public List<Product> OpenCondicionador { get; private set; } = new();
        public List<Product> OpenPerfume { get; private set; } = new();


        public void ReceiveServices(Service service)
        {

            //Category wantedProductCategory, Usage wantedProductUsage, Species wantedProductSpecies
        }

        public int getConsumptionPerService(int amountproduct)
        {
            amountproduct = 10;
            return amountproduct;
        }
        /// <summary>
        /// Metodo para chamar o metodo que "gasta o produto", por tipo de produto.
        /// </summary>
        /// <param name="ProductUseType"> tipo de produto </param>
        /// <param name="productUse">produto usado no serviço </param>
        public void SelectTypeToUse(Category ProductUseType, Product productUse)
        {
            switch (ProductUseType)
            {
                case Category.Shampoo:
                    {
                        if (!ShampooUse(productUse))
                        {
                            Console.WriteLine("Acabou o produto!");
                        }
                    }
                    return;
                case Category.Condicionador:
                    {
                        if (!ConditionerUse(productUse))
                        {
                            Console.WriteLine("Acabou o produto!");
                        }
                    }
                    return;
                case Category.Perfume:
                    {
                        if (!PerfumeUse(productUse))
                        {
                            Console.WriteLine("Acabou o produto!");
                        }
                    }
                    return;
                default:
                    break;
            }
            return;
        }

        /// <summary>
        /// esse metodo é responsavel por receber um produto e alterar a quantidade disponivel 
        /// </summary>
        /// <param name="productUse"> produto usado no serviço </param>
        /// <param name="amountproduct"> quantidade gasta no serviço </param>
        /// 
        /// <returns> caso true: ainda existe shampoo para proximo banho; caso false: nao tem mais shampoo para proximo banho</returns>
        public bool ShampooUse(Product productUse, int amountproduct = 10)
        {
            var retorno = false;
            if (OpenShampoo.Contains(productUse))
            {
                retorno = productUse.CurrentVolume > amountproduct;
                if (!retorno)
                {
                    OpenShampoo.Remove(productUse);
                }

                productUse.spendProduct(amountproduct);
            }
            return retorno;
        }
        public bool ConditionerUse(Product productUse, int amountproduct = 10)
        {
            var retorno = false;
            if (OpenCondicionador.Contains(productUse))
            {
                retorno = productUse.CurrentVolume > amountproduct;
                if (!retorno)
                {
                    OpenCondicionador.Remove(productUse);
                }

                productUse.spendProduct(amountproduct);
            }
            return retorno;
        }
        public bool PerfumeUse(Product productUse, int amountproduct = 10)
        {
            var retorno = false;
            if (OpenPerfume.Contains(productUse))
            {
                retorno = productUse.CurrentVolume > amountproduct;
                if (!retorno)
                {
                    OpenPerfume.Remove(productUse);
                }

                productUse.spendProduct(amountproduct);
            }
            return retorno;
        }

        // A partir desse codigo o Heber fez a refatoração. Eram iguais para shampoo, condicionador e perfume.
        //So deixei o do Perfume, para ter como referencia do antes da mudança.
        /*public void PerfumeUse(Product productUse, int amountproduct, Stock productNew)
        {
            amountproduct = 10;

            if (OpenPerfume.Contains(productUse))
            {
                if (productUse.CurrentVolume >= amountproduct)
                {
                    Console.WriteLine("Produto aberto!E tem quantidade suficiente");
                    productUse.spendProduct(amountproduct);
                }
                else if (productUse.CurrentVolume < amountproduct)
                {
                    Console.WriteLine("Produto aberto!Mas sem quantidade suficiente para banho");
                    productUse.spendProduct(amountproduct);
                    OpenPerfume.Remove(productUse);
                    Console.WriteLine("Abrir novo produto");
                    productNew.ProductRemovalFromStock();
                    productNew.spendProductV(amountproduct);
                    OpenPerfume.Add(productNew);
                }
            }
            else
            {
                Console.WriteLine("Abrir novo produto");
                productNew.ProductRemovalFromStock();
                OpenPerfume.Add(productNew);
                productNew.spendProductVT(amountproduct);
            }
        }*/

        /// <summary>
        /// Busca por tipo de produto.
        /// </summary>
        /// <param name="productType"></param>
        void ConsultByCategory(Category productType)  
        { 
            var BuscaShampooUse = OpenShampoo.Where(p => p.Category == productType).ToList();
            var BuscaCondicionadorUse = OpenCondicionador.Where(p => p.Category == productType).ToList();
            var BuscaPerfume = OpenPerfume.Where(p => p.Category == productType).ToList();
        }
        /// <summary>
        /// Busca por uso de produto.
        /// </summary>
        /// <param name="productUsage"></param>
        void ConsultByUsage(Usage productUsage)
        {
            var BuscaShampooUse = OpenShampoo.Where(p => p.Usage == productUsage ).ToList();
            var BuscaCondicionadorUse = OpenCondicionador.Where(p => p.Usage == productUsage).ToList();
            var BuscaPerfume = OpenPerfume.Where(p => p.Usage == productUsage).ToList();
        }
        /// <summary>
        /// Busca por especie.
        /// </summary>
        /// <param name="productSpecie"></param>
        void ConsultBySpecies(Species productSpecie)
        {
            var BuscaShampooUse = OpenShampoo.Where(p => p.Species == productSpecie).ToList();
            var BuscaCondicionadorUse = OpenCondicionador.Where(p => p.Species == productSpecie).ToList();
            var BuscaPerfume = OpenPerfume.Where(p => p.Species == productSpecie).ToList();
        }  
    }   
}           

