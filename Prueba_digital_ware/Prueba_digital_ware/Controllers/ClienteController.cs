using InventarioData.Model;
using InventarioLogic.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Prueba_digital_ware.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly ILogger<ClienteController> _logger;
        private readonly IClienteService _clienteService;
        public ClienteController(ILogger<ClienteController> logger, IClienteService clienteService)
        {
            _logger = logger;
            _clienteService = clienteService;
        }

        [Route("create")]
        [HttpPost]
        public IActionResult CreateCliente(Cliente model)
        {
            try
            {
                _clienteService.Insert(model);
                return new JsonResult(new { code= HttpStatusCode.OK, message="Insertado satisfactoriamente"});
            }
            catch (Exception e)
            {
                return new JsonResult(new { code = HttpStatusCode.InternalServerError, message = e.Message });
            }

            

        }
        [Route("Update")]
        [HttpPut]
        public IActionResult UpdateCliente(Cliente model)
        {
            try
            {
                _clienteService.Update(model);
                return new JsonResult(new { code = HttpStatusCode.OK, message = "Actualizado satisfactoriamente" });
            }
            catch (Exception e)
            {
                return new JsonResult(new { code = HttpStatusCode.InternalServerError, message = e.Message });
            }
        }

        [Route("Delete")]
        [HttpDelete]
        public IActionResult DeleteCliente(Cliente model)
        {
            try
            {
                _clienteService.Remove(model);
                return new JsonResult(new { code = HttpStatusCode.OK, message = "Removido satisfactoriamente" });
            }
            catch (Exception e)
            {
                return new JsonResult(new { code = HttpStatusCode.InternalServerError, message = e.Message });
            }
        }
        [Route("GetAll")]
        [HttpGet]
        public IActionResult GetAllCliente()
        {
            try
            {                
                return new JsonResult(new {
                    code = HttpStatusCode.OK,                    
                    result=_clienteService.GetAll()
                });
            }
            catch (Exception e)
            {
                return new JsonResult(new { code = HttpStatusCode.InternalServerError, message = e.Message });
            }
        }
        [Route("GetById/{ClienteId}")]
        [HttpGet]
        public IActionResult GetByIdCliente(int ClienteId)
        {
            try
            {
                return new JsonResult(new
                {
                    code = HttpStatusCode.OK,
                    result = _clienteService.GetById(ClienteId)
                });
            }
            catch (Exception e)
            {
                return new JsonResult(new { code = HttpStatusCode.InternalServerError, message = e.Message });
            }
        }

    }
}
