using MapsterMapper;
using Microsoft.AspNetCore.Mvc;
using CosmeticsStore.BL.Interfaces;
using CosmeticsStore.Models.DTO;
using CosmeticsStore.Models.Requests;

namespace CosmeticsStore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CosmeticProductsController : ControllerBase
    {
        private readonly ICosmeticProductService _cosmeticProductService;
        private readonly IMapper _mapper;
        private readonly ILogger<CosmeticProductsController> _logger;

        public CosmeticProductsController(
            ICosmeticProductService cosmeticProductService,
            IMapper mapper,
            ILogger<CosmeticProductsController> logger)
        {
            _cosmeticProductService = cosmeticProductService;
            _mapper = mapper;
            _logger = logger;
        }

        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [HttpGet("GetAll")]
        public IActionResult Get()
        {
            var result = _cosmeticProductService.GetAllProducts();

            if (result == null || result.Count == 0)
            {
                return NotFound("No cosmetic products found");
            }

            return Ok(result);
        }

        [HttpGet("GetById")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetById(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return BadRequest("Id can't be null or empty");
            }

            var result = _cosmeticProductService.GetById(id);

            if (result == null)
            {
                return NotFound($"Cosmetic product with ID:{id} not found");
            }

            return Ok(result);
        }

        [HttpPost("Add")]
        public IActionResult Add(AddCosmeticProductRequest product)
        {
            try
            {
                var productDto = _mapper.Map<CosmeticProduct>(product);

                if (productDto == null)
                {
                    return BadRequest("Can't convert product to product DTO");
                }

                _cosmeticProductService.AddProduct(productDto);

                return Ok();
            }
            catch (System.Exception ex)
            {
                _logger.LogError(ex, $"Error adding cosmetic product");
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("Delete")]
        public IActionResult Delete(int id)
        {
            if (id <= 0)
            {
                return BadRequest("Id must be greater than 0");
            }

            _cosmeticProductService.DeleteProduct(id);

            return Ok();
        }
    }
}

