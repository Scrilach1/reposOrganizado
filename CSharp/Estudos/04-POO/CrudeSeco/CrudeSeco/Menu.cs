using System;
using product;
using cadastro;
using System.ComponentModel;

namespace menu
{
    public class Menu
    {
        public Menu()
        {
        }
        public List<Product> AddProd(List<Product> productList)
        {
            int LastId = productList[productList.Count - 1].Id;
            Cadastro CadProd = new Cadastro();
            Product product0 = CadProd.CadastraProdutos(LastId);
            productList.Add(product0);
            return productList;
        }

        public List<Product> EditProd(List<Product> productList, int Id)
        {
            for (int i = 0; i < productList.Count; i++)
            {
                Product product = productList[i];
                if (product.Id == Id) 
                { 
                Cadastro cadastro = new Cadastro();
                product = cadastro.EditProd(product);
                productList[i] = product;
                break;
                }
            }
            return productList;
        }

        public List<Product> RemProd(List<Product> productList, int Id)
        {
            for (int i = 0; i < productList.Count; i++)
            {
                Product product = productList[i];
                if (product.Id == Id)
                {
                    productList.Remove(product);
                    break;
                }
            }
            return productList;

        }
    }
}