using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Labb2_API.Modeller;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Labb2_API.Metoder;

namespace Labb2_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrenumerantController : ControllerBase
    {

        [HttpGet]
        public ActionResult<IEnumerable<PrenumerantModell>> GetAllPrenumeranter()
        {
            List<PrenumerantModell> prenlista = new List<PrenumerantModell>();
            PrenumerantMetoder pm = new PrenumerantMetoder();
            string error = "";

            prenlista = pm.GetPrenumeranter(out error);

            return prenlista;
        }

        [HttpGet("{id}")]
        public ActionResult<IEnumerable<PrenumerantModell>> GetEnPrenumerant(int id)
        {
            List<PrenumerantModell> prenlista = new List<PrenumerantModell>();
            PrenumerantMetoder pm = new PrenumerantMetoder();
            string error = "";

            prenlista = pm.GetEnPrenumerant(id, out error);

            return prenlista;
        }

      
    }
}
