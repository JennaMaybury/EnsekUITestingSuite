using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestSharp;
using System.Net;

namespace EnsekApiTestingSuite.ApiPages
{
    public class LoginApi : ApiBasePage
    {
        public string pathTemplate = "ENSEK/login";


        public RestResponse<LoginResponseData> LoginRequest(HttpStatusCode status, string username, string password)
        {
            var data = new LoginDataProperties
            {
                username = username,
                password = password
            };


            var client = CreateClient("https://qacandidatetest.ensek.io/");
            var request = new RestRequest($"{pathTemplate}", Method.Post);
            request.AddBody(data);
            var response = client.Execute<LoginResponseData>(request);

            if (response.StatusCode != status)
            {
                Assert.Fail();
            }
            return response;
        }

        public class LoginDataProperties
        {
            public string username { get; set; }
            public string password { get; set; }

        }

        public class LoginResponseData
        {
            public string access_token { get; set; }
        }
    }
}
