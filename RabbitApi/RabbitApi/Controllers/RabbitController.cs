using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RabbitApi.Models;


namespace RabbitApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class RabbitController : ControllerBase
    {
        List<Rabbit> rabbits = new List<Rabbit>();
        public RabbitController() 
        { 
        
           Rabbit r1 = new Rabbit()
           {


            furColor = Rabbit.FurColors.Black,
            eyeColor = Rabbit.EyeColors.Black,
            gender = Rabbit.Gender.Male,
            dateOfBirth = new DateTime(2000, 11, 11)

           };
            r1.ToString();
            rabbits.Add(r1);
        

        }
        // GET: api/Rabbit
        [HttpGet]
        public IEnumerable<Rabbit> Get()
        {

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
        public void Post([FromBody] Models.Rabbit model)
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
