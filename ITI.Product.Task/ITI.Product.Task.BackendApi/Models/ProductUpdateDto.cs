using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITI.Product.Task.BackendApi.Models
{
    public class ProductUpdateDto
    {
        public string ProductName { get; set; }
        public double Price { get; set; }
        public string CompanyName { get; set; }
        public string ImageUrl { get; set; }
    }
}
