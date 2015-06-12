using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace pls.Controllers
{
    [Route("api/v0/[controller]/[action]")]
    public class ValuesController : Controller
    {
        [HttpGet]
        public IEnumerable<string> test()
        {
            return new string[] { "value1", "value2" };
        }
    }
}S
