using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autofac;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Template.Core.Api.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SettingsController : Controller
    {
        /// <summary>Gets swagger setting for API.</summary>
        /// <remarks>Gets swagger setting for API.
        /// <br />
        /// No Request Model
        /// 
        /// </remarks>
        /// <retuns></retuns>
        /// <response code = "400" > Bad Request</response>
        /// <response code = "404" > Not Found</response>
        /// <response code = "500" > Internal Server Error</response>        
        // GET api/values
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        // Get api/swaggersetting
        [Route("swaggersetting")]
        [HttpGet]
        public async Task<IActionResult> GetDisableSwaggerSetting()
        {
            var result = await Task.Run(() => DependencyInjection.Container.container.Resolve<Configuration.ISettings>().DisableSwagger);
            return Ok(result);
        }
        /// <summary>Gets version for API.</summary>
        /// <remarks>Gets version for API.
        /// <br />
        /// No Request Model
        /// 
        /// </remarks>
        /// <retuns></retuns>
        /// <response code = "400" > Bad Request</response>
        /// <response code = "404" > Not Found</response>
        /// <response code = "500" > Internal Server Error</response>        
        // GET api/values
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        // Get api/swaggersetting
        [Route("version")]
        [HttpGet]
        public async Task<IActionResult> GetVersion()
        {
            var result = await Task.Run(() => DependencyInjection.Container.container.Resolve<Configuration.ISettings>().BuildVersion);
            return Ok(result);
        }
    }
}