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
    public class VentaController : ControllerBase
    { 
        private readonly ILogger<VentaController> _logger;
        private readonly IVentaService _ventaService;
        public VentaController(ILogger<VentaController> logger, IVentaService VentaService)
        {
            _logger = logger;
            _ventaService = VentaService;
        }

        [Route("create")]
        [HttpPost]
        public IActionResult CreateVenta(Venta model)
        {
            try
            {
                _ventaService.Insert(model);
                return new JsonResult(new { code = HttpStatusCode.OK, message = "Insertado satisfactoriamente" });
            }
            catch (Exception e)
            {
                return new JsonResult(new { code = HttpStatusCode.InternalServerError, message = e.Message });
            }



        }
        [Route("Update")]
        [HttpPut]
        public IActionResult UpdateVenta(Venta model)
        {
            try
            {
                _ventaService.Update(model);
                return new JsonResult(new { code = HttpStatusCode.OK, message = "Actualizado satisfactoriamente" });
            }
            catch (Exception e)
            {
                return new JsonResult(new { code = HttpStatusCode.InternalServerError, message = e.Message });
            }
        }

        [Route("Delete")]
        [HttpDelete]
        public IActionResult DeleteVenta(Venta model)
        {
            try
            {
                _ventaService.Remove(model);
                return new JsonResult(new { code = HttpStatusCode.OK, message = "Removido satisfactoriamente" });
            }
            catch (Exception e)
            {
                return new JsonResult(new { code = HttpStatusCode.InternalServerError, message = e.Message });
            }
        }
        [Route("GetAll")]
        [HttpGet]
        public IActionResult GetAllVenta()
        {
            try
            {
                return new JsonResult(new
                {
                    code = HttpStatusCode.OK,
                    result = _ventaService.GetAll()
                });
            }
            catch (Exception e)
            {
                return new JsonResult(new { code = HttpStatusCode.InternalServerError, message = e.Message });
            }
        }
        [Route("GetById/{VentaId}")]
        [HttpGet]
        public IActionResult GetByIdVenta(int VentaId)
        {
            try
            {
                return new JsonResult(new
                {
                    code = HttpStatusCode.OK,
                    result = _ventaService.GetById(VentaId)
                });
            }
            catch (Exception e)
            {
                return new JsonResult(new { code = HttpStatusCode.InternalServerError, message = e.Message });
            }
        }

    }
}
