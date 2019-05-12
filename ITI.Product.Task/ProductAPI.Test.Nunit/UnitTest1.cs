using ITI.Product.Task.BackendApi.Controllers;
using ITI.Product.Task.BackendApi.Core;
using ITI.Product.Task.BackendApi.Persistence;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        private  IUnitOfWork UnitOfWork { get; set; }
        private  ProductDbContext Context { get; set; }

        [SetUp]
        public void Setup()
        {
            Context = new ProductDbContext();
            Context.EnsureSeedDataForContext();
            var unitOfWork = new UnitOfWork(Context);
        }

        [Test]
        public void GetAllProducts()
        {
            //Arrange
            var productController = new ProductController(UnitOfWork);
            //Act
            var Data = productController.GetAllProducts();


            Assert.Pass();
        }
    }
}