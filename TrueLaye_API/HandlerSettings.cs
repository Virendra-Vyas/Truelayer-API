using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrueLayer_API
{
    public class HandlerSettings
    {

        public string AuthBaseUri { get; set; }

        public string ApiBaseUri { get; set; }

        public string AuthClientId { get; set; }
        
        public string AuthScope { get; set; }

        public string AuthProvider { get; set; }
        
        public string AuthClientSecret { get; set; }
        
        public string AuthRedirectUri { get; set; }
    }
}
