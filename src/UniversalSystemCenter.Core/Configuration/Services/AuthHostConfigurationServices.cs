using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace UniversalSystemCenter.Core.Configuration.Services
{
    public class AuthHostConfigurationServices
    {
        private readonly IOptions<AuthHostConfiguration> _appConfiguration;
        public AuthHostConfigurationServices(IOptions<AuthHostConfiguration> appConfiguration)
        {
            _appConfiguration = appConfiguration;
        }

        public AuthHostConfiguration AuthHostConfigurations
        {
            get
            {
                return _appConfiguration.Value;
            }
        }
    }
}
