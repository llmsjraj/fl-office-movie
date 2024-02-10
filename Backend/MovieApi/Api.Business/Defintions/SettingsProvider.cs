using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Business.Defintions
{
    public class SettingsProvider
    {
        public Logging Logging { get; set; }
        public string AllowedHosts { get; set; }
        public string CorsOrigin { get; set; }
        public ConnectionStrings ConnectionStrings { get; set; }
    }

    public class LogLevel
    {
        public string Default { get; set; }
        public string MicrosoftAspNetCore { get; set; }
    }

    public class Logging
    {
        public LogLevel LogLevel { get; set; }
    }

    public class ConnectionStrings
    {
        public string DefaultConnection { get; set; }
    }
}
