using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace API_Stuff.Controllers
{
    [ApiController]
    [Route("api/random")]
    public class RandomController : ControllerBase
    {
        List<Random> randoms = new List<Random>()
        {
            new Random() {name = "Random 1"},
            new Random() {name = "Random 2"}
        };

        [HttpGet]
        public ActionResult Get()
        {
            return Ok(randoms[0]);
        }

        [HttpPut]
        public ActionResult Put(Random random)
        {
            randoms.Add(random);

            return Ok(random);
        }
    }
}
