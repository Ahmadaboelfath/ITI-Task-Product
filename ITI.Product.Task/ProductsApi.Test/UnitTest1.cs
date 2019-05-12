using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using ITI.Product.Task.BackendApi.Controllers;
using ITI.Product.Task.BackendApi.Core;
using ITI.Product.Task.BackendApi.Core.Domain;
using ITI.Product.Task.BackendApi.Persistence;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using Xunit;

namespace ProductsApi.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Task_GetAllPosts()
        {
            //Arrange
            var controller = new ProductController(new UnitOfWork(new ProductDbContext()));


            //Act
            var data =controller.GetAllProducts();
            

            //Assert
            data.Should().BeOfType<IEnumerable<Product>>()
                .Which.Count().Should().Be(20);
        }
    }
}
