using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITI.Product.Task.BackendApi.Core;
using ITI.Product.Task.BackendApi.Core.Repository;
using Microsoft.EntityFrameworkCore;

namespace ITI.Product.Task.BackendApi.Persistence.Repository
{
    public class ProductRepository:Repository<Core.Domain.Product>, IProductRepository
    {
        public ProductRepository(DbContext context) : base(context)
        {

        }
    }
}
