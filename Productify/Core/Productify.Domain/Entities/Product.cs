using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Productify.Domain.Entities
{
    public class Product
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }
        public int QuantityInStock { get; set; }

        public DateTime CreatedOn { get; set; }
     
        public Product( string name, decimal price, int quantityInStock)
        {
            Id = Guid.NewGuid();
            Name = name;
            Price = price;
            QuantityInStock = quantityInStock;
            CreatedOn = DateTime.Now;
        }

    }
}
