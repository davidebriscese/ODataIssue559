using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.OData.Query;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ODataIssue599.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ODataIssue : ControllerBase
    {
        // GET: api/<ODataIssue>
        [HttpGet]
        public IEnumerable<string> Get(ODataQueryOptions<DummyModel> options)
        {
            return new string[] { "value1", "value2" };
        }
    }

    public class DummyModel
    {

    }
}
