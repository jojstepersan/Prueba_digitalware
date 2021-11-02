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
    public class OrdenController : ControllerBase
    {
        private readonly ILogger<OrdenController> _logger;
        private readonly IOrdenService _ordenService;
        public OrdenController(ILogger<OrdenController> logger, IOrdenService OrdenService)
        {
            _logger = logger;
            _ordenService = OrdenService;
        }

        [Route("create")]
        [HttpPost]
        public IActionResult CreateOrden(Orden model)
        {
            try
            {
                _ordenService.Insert(model);
                return new JsonResult(new { code = HttpStatusCode.OK, message = "Insertado satisfactoriamente" });
            }
            catch (Exception e)
            {
                return new JsonResult(new { code = HttpStatusCode.InternalServerError, message = e.Message });
            }



        }
        [Route("Update")]
        [HttpPut]
        public IActionResult UpdateOrden(Orden model)
        {
            try
            {
                _ordenService.Update(model);
                return new JsonResult(new { code = HttpStatusCode.OK, message = "Actualizado satisfactoriamente" });
            }
            catch (Exception e)
            {
                return new JsonResult(new { code = HttpStatusCode.InternalServerError, message = e.Message });
            }
        }

        [Route("Delete")]
        [HttpDelete]
        public IActionResult DeleteOrden(Orden model)
        {
            try
            {
                _ordenService.Remove(model);
                return new JsonResult(new { code = HttpStatusCode.OK, message = "Removido satisfactoriamente" });
            }
            catch (Exception e)
            {
                return new JsonResult(new { code = HttpStatusCode.InternalServerError, message = e.Message });
            }
        }
        [Route("GetAll")]
        [HttpGet]
        public IActionResult GetAllOrden()
        {
            try
            {
                return new JsonResult(new
                {
                    code = HttpStatusCode.OK,
                    result = _ordenService.GetAll()
                });
            }
            catch (Exception e)
            {
                return new JsonResult(new { code = HttpStatusCode.InternalServerError, message = e.Message });
            }
        }
        [Route("GetById/{OrdenId}")]
        [HttpGet]
        public IActionResult GetByIdOrden(int OrdenId)
        {
            try
            {
                return new JsonResult(new
                {
                    code = HttpStatusCode.OK,
                    result = _ordenService.GetById(OrdenId)
                });
            }
            catch (Exception e)
            {
                return new JsonResult(new { code = HttpStatusCode.InternalServerError, message = e.Message });
            }
        }

    }
}
