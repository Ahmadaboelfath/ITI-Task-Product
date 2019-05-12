using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using ITI.Product.Task.BackendApi.Controllers;
using ITI.Product.Task.BackendApi.Core;
using ITI.Product.Task.BackendApi.Core.Domain;
using ITI.Product.Task.BackendApi.Persistence;
using Microsoft.AspNetCore.Mvc;
using Xunit;
using Moq;

namespace ProductApi.xTest
{
    public class ProductControllerTest
    {
        [Fact]
        public void GetAllProducts()
        {
            var mockUnitOfWork = new Mock<IUnitOfWork>();
            var sut = new ProductController(mockUnitOfWork.Object);

            IActionResult result = sut.GetAllProducts();

            Assert.Equal(mockUnitOfWork. ,result);
        }
    }
}
