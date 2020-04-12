using AutoMapper;
using ProductsInventory.API.Models;
using ProductsInventory.API.Services;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;

namespace ProductsInventory.API.Controllers
{
    [ApiController]
    [Route("api/product")]
    public class ProductController :ControllerBase
    {
        private readonly IProductsRepository _productRepository;
        private readonly IMapper _mapper;

        public ProductController(IProductsRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository ??
                   throw new ArgumentNullException(nameof(productRepository));

            _mapper = mapper ??
                throw new ArgumentNullException(nameof(mapper)); ;
        }

        [EnableCors]
        [HttpGet(Name = "GetProducts")]
        public IActionResult GetProducts()
        {
            var productFromRepo = _productRepository.GetProducts();
            return Ok(_mapper.Map<IEnumerable<ProductDto>>(productFromRepo));
        }

        [EnableCors]
        [HttpGet("{productId}", Name = "GetProduct")]
        public IActionResult GetProduct(int productId)
        {
            var productFromRepo = _productRepository.GetProduct(productId);

            if (productFromRepo == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<ProductDto>(productFromRepo));
        }

        [EnableCors]
        [HttpPost(Name = "CreateCategory")]
        public ActionResult<ProductDto> CreateProduct(ProductForCreationDto product)
        {
            if (product == null)
            {
                return BadRequest();
            }

            var productEntity = _mapper.Map<Entities.Products>(product);
            _productRepository.AddProduct(productEntity);
            _productRepository.Save();

            var productToReturn = _mapper.Map<ProductDto>(productEntity);
            return CreatedAtRoute("GetProduct",
                new { productId = productToReturn.productId },
                productToReturn);
        }

        [EnableCors]
        [HttpPut("{productId}", Name = "UpdateProduct")]
        public IActionResult UpdateProduct(int productId, ProductForUpdateDto product)
        {
            if (!_productRepository.ProductsExists(productId))
            {
                return NotFound();
            }

            var productFromRepo = _productRepository.GetProduct(productId);

            if (productFromRepo == null)
            {
                return NotFound();
            }

            _mapper.Map(product, productFromRepo);


            _productRepository.UpdateProducts(productFromRepo);


            _productRepository.Save();
            return NoContent();
        }

        [EnableCors]
        [HttpDelete("{productId}", Name = "DeleteProduct")]
        public IActionResult DeleteProduct(int productId)
        {
            if (!_productRepository.ProductsExists(productId))
            {
                return NotFound();
            }
            var productFromRepo = _productRepository.GetProduct(productId);

            if (productFromRepo == null)
            {
                return NotFound();
            }

            _productRepository.DeleteProducts(productFromRepo);
            _productRepository.Save();

            return NoContent();
        }

    }
}
