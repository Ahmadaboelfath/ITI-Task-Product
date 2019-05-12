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

        /// <summary>
        ///  Get all products inside the product table
        /// </summary>
        /// <returns> returns an IEnumerable of all products </returns>

        [HttpGet]
        public IActionResult GetAllProducts()
        {
          var productsFromRepo =  _unitOfWork.Product.GetAll();

            return Ok(productsFromRepo);
        }

        /// <summary>
        /// Get a product by his Id
        /// </summary>
        /// <param name="id"> the id of the product you want to get </param>
        /// <returns>
        /// a product with id, product name, price, image url , company name
        /// </returns>
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

        /// <summary>
        /// Update a specific product by his id
        /// </summary>
        /// <param name="id"></param> product Id
        /// <param name="product"></param> product sent in the body of the request
        /// <returns>
        ///     returns 204 no content status code on success 
        /// </returns>
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