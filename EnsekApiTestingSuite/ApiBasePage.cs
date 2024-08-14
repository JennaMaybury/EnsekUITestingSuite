using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp.Authenticators;

namespace EnsekApiTestingSuite
{
    public class ApiBasePage
    {
        public static IRestClient CreateClient(string baseUrl)
        {

            // Creates a client using the options object
            var options = new RestClientOptions(baseUrl)
            {
                Timeout = TimeSpan.FromSeconds(1000), 
                Authenticator = new JwtAuthenticator(baseUrl),
            };
            var client = new RestClient(options);
            return client;
        }
    }
}
