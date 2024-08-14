using RestSharp;

namespace EnsekApiTestingSuite.ApiPages
{
    public class ApiBasePage
    {
        public static IRestClient CreateClient(string baseUrl)
        {

            // Creates a client using the options object
            var options = new RestClientOptions(baseUrl)
            {
                Timeout = TimeSpan.FromSeconds(1000),
                //Authenticator = new JwtAuthenticator(baseUrl),
            };
            var client = new RestClient(options);
            return client;
        }
    }
}
