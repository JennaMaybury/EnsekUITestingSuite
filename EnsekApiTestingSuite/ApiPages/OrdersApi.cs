using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestSharp;
using System.Net;

namespace EnsekApiTestingSuite.ApiPages
{
    public class OrdersApi : ApiBasePage
    {

        public string pathTemplate = "ENSEK/orders";


        public RestResponse OrdetRequest(HttpStatusCode status, Method requestType, string? orderId)
        {

            var client = CreateClient("https://qacandidatetest.ensek.io/");
            var request = new RestRequest($"{pathTemplate}", requestType);
            var response = client.Execute(request);

            if (response.StatusCode != status && response.StatusCode == 0)
            {
                Assert.Fail();
            }
            return response;
        }
    }
}
