using Microsoft.AspNetCore.Mvc; 
using FisherInsuranceApi.Models;

namespace FisherInsuranceApi.Controllers {
    [Route("api/quotes")] 
    public class QuoteController : Controller {
        

        // POST api/auto/quotes
        
        [HttpGet]
        public IActionResult GetQuotes()
        {
            return Ok();
        }

        [HttpPost] 
        public IActionResult Post([FromBody]Quote quote) {
            return Ok();
        }

        // GET api/auto/quotes/5 
        [HttpGet("{id}")] 
        public IActionResult Get(int id) {
            return Ok();
        }

        // PUT api/auto/quotes/id
        [HttpPut("{id}")] 
        public IActionResult Put(int id, [FromBody]Quote quote) {
            return Ok(); 
        }

        // DELETE api/auto/quotes/id
        [HttpDelete("{id}")] 
        public IActionResult Delete(int id, [FromBody]Quote quote) {
            return Ok();
        }

    }

}