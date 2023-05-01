using System;
using System.Collections.Generic;
using System.Text;

namespace Eshop.Infrastructure.Events.Product
{
    public class ProductCreated
    {
        public Guid ProductId { get; set; }
        public string ProductName { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
