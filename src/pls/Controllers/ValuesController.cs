using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Microsoft.Framework.Logging;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace pls.Controllers
{
    [Route("api/v0/[controller]/[action]")]
    public class ValuesController : Controller
    {
		private ILogger _logr;
		public ValuesController(ILogger lg)
		{
			_logr = lg;
			_logr.LogInformation("hit");
		}
        [HttpGet]
        public IEnumerable<string> test()
        {
            return new string[] { "value1", "value2" };
        }
    }
}
