using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Threading.Tasks;
using Domain.DTO.Order;
using Domain.Entities;
using Domain.Entities.Order;
using Domain.Service;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private IProductService _service;

        public ProductController(IProductService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("{type}")]
        public ActionResult<IEnumerable<OrderResultDto>> Get(string type)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest();

                return Ok(_service.GetAll(type));
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
