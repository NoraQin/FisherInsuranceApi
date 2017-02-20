using Microsoft.AspNetCore.Mvc; 
using FisherInsuranceApi.Data;
using FisherInsuranceApi.Models;

namespace FisherInsuranceApi.Controllers{
    [Route("api/claims")] 
    public class ClaimsController : Controller {
        private IMemoryStore db;
        public ClaimsController(IMemoryStore repo)
        {
            db = repo;
        }

        [HttpGet]
        public IActionResult GetQuotes()
        {
            return Ok(db.RetrieveAllClaims);
        }
        
        // POST api/customercare/claims
        [HttpPost]
        public IActionResult Post([FromBody]Claim claim) {
            return Ok(db.CreateClaim(claim));
        }

        // GET api/customercare/claims/5 
        [HttpGet("{id}")] 
        public IActionResult Get(int id) {
            return Ok(db.RetrieveClaim(id));
        }

        // PUT api/customercare/claims/id
        [HttpPut("{id}")] 
        public IActionResult Put(int id, [FromBody]Claim claim) {
            return Ok(db.UpdateClaim(claim)); 
        }

        // DELETE api/customercare/claims/id
        [HttpDelete("{id}")] 
        public IActionResult Delete(int id, [FromBody]Claim claim) {
            db.DeleteClaim(id);
            return Ok(); 
        }

    }
}