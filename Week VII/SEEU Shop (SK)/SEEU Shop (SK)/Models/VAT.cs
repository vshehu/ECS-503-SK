using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEEU_Shop__SK_.Models
{
    public class VAT
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; }

        public List<Product> Products { get; set; }
    }
}
