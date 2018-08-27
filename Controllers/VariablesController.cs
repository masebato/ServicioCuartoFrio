using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ServicioCuartoFrio.Models;

namespace ServicioCuartoFrio.Controllers
{
    public class VariablesController : ApiController
    {

        Variables var = new Variables();

        [HttpPost]
        public IHttpActionResult RegistrarVariables( Variables obj)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            else
            {
                if (var.InsertarDato(obj))
                {
                    return Json(new { data = obj, result = true });
                }
                else
                {
                    return Json(new { result = false });
                }

            }
        } 

        [HttpGet]
        public IHttpActionRresult ConsultarVariables()
        {
           
        }

    }
}
