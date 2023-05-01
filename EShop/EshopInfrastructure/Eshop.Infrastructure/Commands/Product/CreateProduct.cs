using System;
using System.Collections.Generic;
using System.Text;

namespace Eshop.Infrastructure.Commands.Product
{
    public class CreateProduct
    {
        public Guid ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public float ProductPrice { get; set; }
        public Guid CategorId { get; set; }
    }
}
