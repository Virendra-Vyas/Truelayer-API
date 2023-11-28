using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace TrueLayer_API.Interfaces
{
    public interface IAuthService
    {
        HttpResponseMessage ExchangeCodeForAccessToken(string code);
        Uri GetAuthorizationUri();
    }
}
