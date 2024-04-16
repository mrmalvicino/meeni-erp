using System;
using System.ComponentModel;

namespace Entities
{
    public class QuoteRow
    {
        // PROPERTIES

        [DisplayName("ID de fila")]
        public int QuoteRowId { get; set; }

        [DisplayName("Índice")]
        public int Index { get; set; }

        [DisplayName("Cantidad")]
        public int Amount { get; set; }

        [DisplayName("Descripción")]
        public string Description { get; set; }

        [DisplayName("Precio")]
        public decimal Price { get; set; }

        [DisplayName("Producto")]
        public Product Product { get; set; }

        [DisplayName("Servicio")]
        public Service Service { get; set; }

        // CONSTRUCT

        public QuoteRow()
        {
            Product = new Product();
            Service = new Service();
        }

        // METHODS

        public override string ToString()
        {
            if (Product != null)
            {
                Description = Product.ToString();
                Price = Product.Price;
            }
            else if (Service != null)
            {
                Description = Service.ToString();
                Price = Service.Price;
            }

            return Amount + "\t" + Description + $"{tab(Description)}$" + Price;
        }

        private string tab(string text)
        {
            string space = "";
            int maxAmountOfTabs = 9;
            int tabs = maxAmountOfTabs - text.Length / 8;

            for (int i = 0; i < tabs; i ++)
            {
                space += "\t";
            }

            return space;
        }
    }
}
