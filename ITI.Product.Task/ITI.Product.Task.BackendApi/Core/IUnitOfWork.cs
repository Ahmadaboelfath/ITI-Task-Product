using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITI.Product.Task.BackendApi.Core.Repository;

namespace ITI.Product.Task.BackendApi.Core
{
    /// <summary>
    /// Generic unit of work interface
    /// </summary>
    public interface IUnitOfWork:IDisposable
    {
        IProductRepository Product { get; set; }

        int Complete();

    }
}
