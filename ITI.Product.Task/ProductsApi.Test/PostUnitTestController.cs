using System;
using System.Collections.Generic;
using System.Text;
using ITI.Product.Task.BackendApi.Core;
using ITI.Product.Task.BackendApi.Persistence;

namespace ProductsApi.Test
{
    class PostUnitTestController
    {
        UnitOfWork uw = new UnitOfWork(new ProductDbContext());
    }
}
