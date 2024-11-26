using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Falp.Donaciones.Aplicacion.DTO;
using Falp.Donaciones.Aplicacion.Interface;

namespace Falp.Donaciones.Servicio.WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class RecaudacionController : Controller
    {
        private readonly IDonacionesAplicacion _donacionesAplicacion;

        public RecaudacionController(IDonacionesAplicacion donacionesAplicacion)
        {
            _donacionesAplicacion = donacionesAplicacion;
        }

        #region Métodos
        [HttpPost]
        public IActionResult Insertar ([FromBody] DTODonaciones dtoDonaciones)
        {
            if (dtoDonaciones == null)
                return BadRequest();

            var response = _donacionesAplicacion.Insertar(dtoDonaciones);

            if (response.IsSucess)
                return Ok(response);
            else
                return BadRequest(response.Message);
        }
        #endregion
    }
}