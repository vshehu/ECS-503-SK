using SEEU_Shop__SK_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEEU_Shop__SK_.ViewModels
{
    public class CreateProductViewModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal Amount { get; set; }
        public decimal Discount { get; set; }
        public string ImageURL { get; set; }

        public int CategoryId { get; set; }
        public int VATId { get; set; }

        public List<Category> Categories { get; set; }
        public List<VAT> VATs { get; set; }

    }
}
