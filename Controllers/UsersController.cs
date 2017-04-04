using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Angular2CoreMVC.Controllers
{
    //[Produces("application/json")]
    //[Route("api/Users")]
    [Route("api/[controller]")]
    public class UsersController : BaseController
    {
        #region Declares
        Models.TMSalesManagerContext db;
        public UsersController(Models.TMSalesManagerContext context)
        {
            db = context;
        }
        protected override void Dispose(bool disposing)
        {
            if (db != null) db.Dispose();
            base.Dispose(disposing);
        }
        #endregion
        [HttpGet("[action]")]
        public IEnumerable<Models.Users> Get()
        {
            //return new string[] { "value1", "value2" };
            var page = new TM.Page.Pages();
            var rs = page.PagesAnonymous(db.Users);
            //var rs = db.Users;
            return rs;
        }

        // GET: api/Users/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Users
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Users/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
