using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PFA.Service;
using PFA.Models;

namespace ProductsAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {

        private ILogger _logger;
        private ICandidatService _service;

        
        public ProductsController(ILogger<ProductsController> logger, ICandidatService service)
        {
            _logger = logger;
            _service = service;
            
        }

        [HttpGet("/api/candidats")]
        public ActionResult<List<Candidat>> GetCandidats()
        {
            return _service.GetCandidats();
        }

        [HttpPost("/api/candidats")]
        public ActionResult<Candidat> AddProduct(Candidat candidat)
        {
            _service.AddCandidat(candidat);
            return candidat;
        }

        [HttpPut("/api/candidats/{id}")]
        public ActionResult<Candidat> UpdateCandidat(int id, Candidat candidat)
        {
            _service.UpdateCandidat(id, candidat);
            return candidat;
        }

        [HttpDelete("/api/candidats/    {id}")]
        public ActionResult<int> DeleteProduct(int id)
        {
            _service.DeleteCandidat(id);
            //_logger.LogInformation("products", _products);
            return id;
        }
    }
}
