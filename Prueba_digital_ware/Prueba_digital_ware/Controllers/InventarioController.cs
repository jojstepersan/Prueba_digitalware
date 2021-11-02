using InventarioData.Model;
using InventarioLogic.Repository;
using Microsoft.AspNetCore.Http;
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
    public class InventarioController : ControllerBase
    {
        private readonly ILogger<InventarioController> _logger;
        private readonly IInventarioService _inventarioService;
        public InventarioController(ILogger<InventarioController> logger, IInventarioService InventarioService)
        {
            _logger = logger;
            _inventarioService = InventarioService;
        }

        [Route("create")]
        [HttpPost]
        public IActionResult CreateInventario(Inventario model)
        {
            try
            {
                _inventarioService.Insert(model);
                return new JsonResult(new { code = HttpStatusCode.OK, message = "Insertado satisfactoriamente" });
            }
            catch (Exception e)
            {
                return new JsonResult(new { code = HttpStatusCode.InternalServerError, message = e.Message });
            }



        }
        [Route("Update")]
        [HttpPut]
        public IActionResult UpdateInventario(Inventario model)
        {
            try
            {
                _inventarioService.Update(model);
                return new JsonResult(new { code = HttpStatusCode.OK, message = "Actualizado satisfactoriamente" });
            }
            catch (Exception e)
            {
                return new JsonResult(new { code = HttpStatusCode.InternalServerError, message = e.Message });
            }
        }

        [Route("Delete")]
        [HttpDelete]
        public IActionResult DeleteInventario(Inventario model)
        {
            try
            {
                _inventarioService.Remove(model);
                return new JsonResult(new { code = HttpStatusCode.OK, message = "Removido satisfactoriamente" });
            }
            catch (Exception e)
            {
                return new JsonResult(new { code = HttpStatusCode.InternalServerError, message = e.Message });
            }
        }
        [Route("GetAll")]
        [HttpGet]
        public IActionResult GetAllInventario()
        {
            try
            {
                return new JsonResult(new
                {
                    code = HttpStatusCode.OK,
                    result = _inventarioService.GetAll()
                });
            }
            catch (Exception e)
            {
                return new JsonResult(new { code = HttpStatusCode.InternalServerError, message = e.Message });
            }
        }
        [Route("GetById/{InventarioId}")]
        [HttpGet]
        public IActionResult GetByIdInventario(int InventarioId)
        {
            try
            {
                return new JsonResult(new
                {
                    code = HttpStatusCode.OK,
                    result = _inventarioService.GetById(InventarioId)
                });
            }
            catch (Exception e)
            {
                return new JsonResult(new { code = HttpStatusCode.InternalServerError, message = e.Message });
            }
        }

    }
}
