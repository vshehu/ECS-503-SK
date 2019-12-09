using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEEU_Shop__SK_.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal Amount { get; set; }
        public decimal Discount { get; set; }
        public string ImageURL { get; set; }

        public Category Category { get; set; }
        public VAT VAT { get; set; }
    }
}
