using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RabbitApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class RabbitController : ControllerBase
    {
        // GET: api/Rabbit
        [HttpGet]
        public IEnumerable <Models.Rabbit> Get()
        {
            Models.Rabbit r1 = new Models.Rabbit(Models.Rabbit.FurColors.Black, Models.Rabbit.EyeColors.Black, Models.Rabbit.Gender.Male);
            List<Models.Rabbit> rabbits = new List<Models.Rabbit>();
            rabbits.Add(r1);
            return rabbits;
        }

        // GET: api/Rabbit/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Rabbit
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Rabbit/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
