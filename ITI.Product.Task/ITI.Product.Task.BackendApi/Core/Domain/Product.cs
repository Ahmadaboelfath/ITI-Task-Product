using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITI.Product.Task.BackendApi.Core.Domain
{
    /// <summary>
    /// Responsible for managing the products inside the application
    /// </summary>
    public class Product
    {
       
            public Guid Id { get; set; }
            public string ProductName { get; set; }
            public double Price { get; set; }
            public string CompanyName { get; set; }
            public string ImageUrl { get; set; }


        
    }
}
