using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApp_isracard.Models;

using System.Net.Http.Headers;
using System.Threading.Tasks;
using WebApp_isracard.bl;
using System.Web.Http.Cors;


using Newtonsoft.Json;
// ...   

namespace WebApp_isracard.Controllers
{
   
    public class GitHubController : ApiController
    {
        // GET: api/GitHub
        public IHttpActionResult Get(string q)
        {

            var reposResult = JsonConvert.DeserializeObject(github_BL.getGithubRepo(q));
            var response = new  {reposResult= reposResult };
            
            return Ok(response);
        }

        // GET: api/GitHub/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/GitHub
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/GitHub/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/GitHub/5
        public void Delete(int id)
        {
        }
    }
}
