using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITI.Product.Task.BackendApi.Core;

namespace ITI.Product.Task.BackendApi.Core.Repository
{
    public interface IProductRepository:IRepository<Domain.Product>
    {
    }
}
