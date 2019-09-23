using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Template.Core.Api.Api.Configuration
{
    public class Settings : ISettings
    {
        private IConfigurationRoot Configuration { get; set; }
        private IConfigurationSection AppSettings { get; set; }
        public Settings()
        {
            var builder = new ConfigurationBuilder()
                //.SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();
            AppSettings = Configuration.GetSection("AppSettings");
            DisableSwagger = AppSettings["DisableSwagger"];
        }
        public string DisableSwagger { get; } 
        public Version BuildVersion { get; } = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
        //public DateTime BuildDate { get; } = Convert.ToDateTime(Properties.Resources.BuildDate);
    }
}
