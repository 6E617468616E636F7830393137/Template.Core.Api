using System;

namespace Template.Core.Api.Api.Configuration
{
    public interface ISettings
    {
        string DisableSwagger { get; }
        Version BuildVersion { get; }
        DateTime BuildDate { get; }
    }
}
