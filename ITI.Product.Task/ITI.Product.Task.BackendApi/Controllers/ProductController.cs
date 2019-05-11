using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITI.Product.Task.BackendApi.Core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ITI.Product.Task.BackendApi.Controllers
{
    /// <summary>
    ///  Controller Responsible for Managing CRUD operation for product entity
    /// </summary>
    [Route("api/products")]
    
    public class ProductController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProductController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public IActionResult GetAllProducts()
        {
          var productsFromRepo =  _unitOfWork.Product.GetAll();

            return Ok(productsFromRepo);
        }


        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            var productFromRepo = _unitOfWork.Product.Get(id);

            if (productFromRepo == null)
            {
                return NotFound();
            }

            return Ok(productFromRepo);

        }


        //[HttpPut("{id}")]
        //public IActionResult Edit(Guid id)
        //{
        //    var prod
        //}

    }
}