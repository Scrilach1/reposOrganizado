using System;
namespace product
{
    public class Product
    {
        public Product()
        {

        }
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }


        override
            public string ToString()
        {
            return "Nome do produto: " + Name
                + ", Preço: R$" + Price
                + ", Quantidade em estoque: " + Quantity
                + "Descrição: " + Description;

        }

    }
}
