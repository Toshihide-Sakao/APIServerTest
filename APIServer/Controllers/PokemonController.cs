using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace APIServer.Controllers
{
    [ApiController]
    [Route("api/Matkort")]
    public class PokemonController : ControllerBase
    {
        static List<MatStalle> mat = new List<MatStalle>()
        {
            new MatStalle() {Name = "subway" , ExtraPris = false},
            new MatStalle() {Name = "Falaffel", ExtraPris = false},
            new MatStalle() {Name = "Hemköp", ExtraPris = true}
        };

        [HttpGet]
        public ActionResult Get()
        {
            return Ok(mat);
        }
    }
}
