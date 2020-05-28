using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace emailapi.Controllers
{
    [Route("api/[controller]")]
    public class EmailController : Controller
    {
        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        
        [HttpGet]

        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>

        [HttpPost]
        public void Post(string value)
        {
            var x = Request.Body.;
            var y = x;

            //string content = await new StreamReader(Request.Body.Read.name).ReadToEndAsync();
            //var arr = content.Split(':');
        
            //var y = question;
            //var x = content;

        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
