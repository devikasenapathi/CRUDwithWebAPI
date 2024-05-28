using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using CRUDwithWebAPI12;
using System.Threading.Tasks;
using CRUDwithWebAPI;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CRUDwithWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookshopController : ControllerBase

    {
        BookRep Regis;
        public BookshopController()
        {
            Regis = new BookRep();
        }
        // GET: api/<BookshopController>
        [HttpGet]
        public IEnumerable<BookShop> Get()
        {
            return Regis.Select();
        }

        // GET api/<BookshopController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<BookshopController>
        [HttpPost]
        public void Post([FromBody] BookShop Regiss)
        {
            Regis.SignUp1(Regiss);

        }

        // PUT api/<BookshopController>/5
        [HttpPut("{BookName}/{ToatalNoPages}")]
        public void Put(string BookName,long ToatalNoPages)
        {
            Regis.SignUpUpdate(BookName,ToatalNoPages);
        }

        // DELETE api/<BookshopController>/5
        [HttpDelete("{id}")]
        public void Delete(string BookName)
        {
            Regis.DeleteTable(BookName);
        }
    }
}
