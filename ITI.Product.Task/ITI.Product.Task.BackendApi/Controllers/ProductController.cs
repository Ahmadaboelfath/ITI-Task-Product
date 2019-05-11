﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITI.Product.Task.BackendApi.Core;
using Microsoft.AspNetCore.Cors;
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
        [EnableCors]
        [HttpGet]
        public IActionResult GetAllProducts()
        {
          var productsFromRepo =  _unitOfWork.Product.GetAll();

            return Ok(productsFromRepo);
        }

        [EnableCors]
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

        [EnableCors]
        [HttpPut("{id}")]
        public IActionResult Edit(Guid id, [FromBody] Core.Domain.Product product )
        {
            var productFromRepo = _unitOfWork.Product.Get(id);
            if (productFromRepo == null)
            {
                return NotFound();
            }

            productFromRepo = product;

            if (!(_unitOfWork.Complete() <= 0))
            {
               throw new Exception($"Updating the product with id: {id} has failed");
            }

            return NoContent();
        }

    }
}