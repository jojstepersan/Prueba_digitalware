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
    public class ProductoController : ControllerBase
    {
        private readonly ILogger<ProductoController> _logger;
        private readonly IProductoService _productoService;
        public ProductoController(ILogger<ProductoController> logger, IProductoService productoService)
        {
            _logger = logger;
            _productoService = productoService;
        }

        [Route("create")]
        [HttpPost]
        public IActionResult CreateProducto(Producto model)
        {
            try
            {
                _productoService.Insert(model);
                return new JsonResult(new { code = HttpStatusCode.OK, message = "Insertado satisfactoriamente" });
            }
            catch (Exception e)
            {
                return new JsonResult(new { code = HttpStatusCode.InternalServerError, message = e.Message });
            }



        }
        [Route("Update")]
        [HttpPut]
        public IActionResult UpdateProducto(Producto model)
        {
            try
            {
                _productoService.Update(model);
                return new JsonResult(new { code = HttpStatusCode.OK, message = "Actualizado satisfactoriamente" });
            }
            catch (Exception e)
            {
                return new JsonResult(new { code = HttpStatusCode.InternalServerError, message = e.Message });
            }
        }

        [Route("Delete")]
        [HttpDelete]
        public IActionResult DeleteProducto(Producto model)
        {
            try
            {
                _productoService.Remove(model);
                return new JsonResult(new { code = HttpStatusCode.OK, message = "Removido satisfactoriamente" });
            }
            catch (Exception e)
            {
                return new JsonResult(new { code = HttpStatusCode.InternalServerError, message = e.Message });
            }
        }
        [Route("GetAll")]
        [HttpGet]
        public IActionResult GetAllProducto()
        {
            try
            {
                return new JsonResult(new
                {
                    code = HttpStatusCode.OK,
                    result = _productoService.GetAll()
                });
            }
            catch (Exception e)
            {
                return new JsonResult(new { code = HttpStatusCode.InternalServerError, message = e.Message });
            }
        }
        [Route("GetById/{ProductoId}")]
        [HttpGet]
        public IActionResult GetByIdProducto(int ProductoId)
        {
            try
            {
                return new JsonResult(new
                {
                    code = HttpStatusCode.OK,
                    result = _productoService.GetById(ProductoId)
                });
            }
            catch (Exception e)
            {
                return new JsonResult(new { code = HttpStatusCode.InternalServerError, message = e.Message });
            }
        }

        [Route("GetMinimoExistencia")]
        [HttpGet]
        public IActionResult GetMinimoExistenciaProducto()
        {
            try
            {
                return new JsonResult(new
                {
                    code = HttpStatusCode.OK,
                    result = _productoService.GetMinimoExistencia()
                });
            }
            catch (Exception e)
            {
                return new JsonResult(new { code = HttpStatusCode.InternalServerError, message = e.Message });
            }
        }
    }
}
