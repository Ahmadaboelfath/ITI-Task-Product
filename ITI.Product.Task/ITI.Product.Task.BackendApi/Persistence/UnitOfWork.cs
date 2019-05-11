using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITI.Product.Task.BackendApi.Core;
using ITI.Product.Task.BackendApi.Core.Repository;
using ITI.Product.Task.BackendApi.Persistence.Repository;

namespace ITI.Product.Task.BackendApi.Persistence
{
    /// <summary>
    /// Unit of work implementation
    /// </summary>
    public class UnitOfWork:IUnitOfWork
    {
        private readonly ProductDbContext _context;

        public UnitOfWork(ProductDbContext context)
        {
            _context = context;
            Product = new ProductRepository(context);
        }

     

        public IProductRepository Product { get; set; }


        public int Complete()
        {
           return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

       
    }
}
