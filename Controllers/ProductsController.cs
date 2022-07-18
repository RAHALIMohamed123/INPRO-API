using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using INPRO.API.Data;
using INPRO.API.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace INPRO.API.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly DataContext _context;
        private readonly IProductRepository _repo;
        private readonly IMapper _mapper;
        public ProductsController(DataContext context, IProductRepository repo, IMapper mapper)
        {
            _mapper = mapper;
            _repo = repo;
            _context = context;
        }
        
        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            var products = await _repo.GetProducts();
            var ProductsToReturn = _mapper.Map<IEnumerable<ProductForListDto>>(products);
            return Ok(ProductsToReturn);
        }

        [HttpGet("id")]
        public async Task<IActionResult> GetProduct(int id)
        {
            var product = await _repo.GetProduct(id);
            var ProductToReturn = _mapper.Map<ProductForListDto>(product);
            return Ok(ProductToReturn);
            //testest
        }
    }
}