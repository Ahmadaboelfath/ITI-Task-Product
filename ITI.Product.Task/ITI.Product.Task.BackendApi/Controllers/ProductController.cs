using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ITI.Product.Task.BackendApi.Core;
using ITI.Product.Task.BackendApi.Models;
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


        [HttpPut("{id}")]
        public IActionResult Edit(Guid id, [FromBody] ProductUpdateDto product )
        {
            if (product == null)
            {
                return BadRequest();
            }

            var productFromRepo = _unitOfWork.Product.Get(id);
            if (productFromRepo == null)
            {
                return NotFound();
            }

            //Mapping the ProductUpdateDto to the product entity
            productFromRepo.Id = id;
            productFromRepo.CompanyName = product.CompanyName;
            productFromRepo.ImageUrl = product.ImageUrl;
            productFromRepo.Price = product.Price;
            productFromRepo.ProductName = product.ProductName;


            if (!(_unitOfWork.Complete() > 0))
            {
               throw new Exception($"Updating the product with id: {id} has failed");
            }

            return NoContent();
        }

    }
}