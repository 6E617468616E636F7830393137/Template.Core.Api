using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autofac;
using Microsoft.AspNetCore.Mvc;
using Log4Net.Helper.Logging.Core;
using Swashbuckle.AspNetCore.Swagger;
using Microsoft.Extensions.Configuration;
using Web = System.Web.Http;

namespace Template.Core.Api.Api.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : Controller
    {
        
        public ValuesController()
        {
            Logger.Info(": : : : : Values Controller : : : : :");            
            
        }        
        [HttpGet]
        public IEnumerable<string> Get()
        {
            Logger.Info("Calling Get End Point");
            return DependencyInjection.Container.container.Resolve<Bll.Values.IValuesService>().FindAll();
            //return this._valuesService.FindAll();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return DependencyInjection.Container.container.Resolve<Bll.Values.IValuesService>().Find(id);
        }
    }
}
