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
using Microsoft.AspNetCore.Mvc;

namespace Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private IOrderService _service;

        public OrderController(IOrderService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<IEnumerable<OrderResultDto>> Get()
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest();

                return Ok(_service.GetAll());
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        [Route("{id}", Name = "GetWithId")]
        public ActionResult<OrderResultDto> Get(Guid id)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest();

                var entity = _service.Get(id);
                if (entity == null)
                    return NotFound();

                return Ok(entity);
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        public ActionResult<OrderResultDto> Post([FromBody] OrderDto order)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest();

                var entity = _service.Get(order.Id);
                if (entity == null)
                    return NotFound();

                var result = _service.Post(order);

                if (result != null)
                {
                    return Created(new Uri(Url.Link("GetWithId", new { id = result.Id })), result);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPut]
        public ActionResult<OrderResultDto> Put([FromBody] OrderDto order)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest();

                var entity = _service.Get(order.Id);
                if (entity == null)
                    return NotFound();

                var result = _service.Put(order);

                if (result != null)
                {
                    return Ok(result);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(Guid id)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest();

                return Ok(_service.Delete(id));
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        [Route("calcula_order")]
        public ActionResult<OrderResultDto> CalculaOrder([FromBody] OrderDto order)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest();

                return Ok(_service.CalculaOrder(order));
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
