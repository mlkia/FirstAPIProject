using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FirstAPIProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CallcController : ControllerBase
    {
        [HttpGet("add/{a}/{b}")] 
        public int Add(int a, int b)
        {
            return a + b;
        }

        [HttpGet("sub/{a}/{b}")]
        public int Sub(int a, int b)
        {
            return a - b;
        }

        [HttpGet("Mult/{a}/{b}")]
        public int Mult(int a, int b)
        {
            return a * b;
        }

        [HttpGet("Div/{a}/{b}")]
        public int Div(int a, int b)
        {
            return a / b;
        }


        // GET: api/<CallcController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<CallcController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CallcController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CallcController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CallcController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
