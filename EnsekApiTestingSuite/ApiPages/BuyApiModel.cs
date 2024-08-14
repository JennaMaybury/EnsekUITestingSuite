using System.Net;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestSharp;

namespace EnsekApiTestingSuite.ApiPages
{
    public class BuyApiModel : ApiBasePage

    {
        public string pathTemplate = "ENSEK/buy/";
        public string successMessage = "";
        public RestResponse BuyEnergyRequest(int id, int qty, HttpStatusCode status)
        {
            var data = new BuyEnergyRequestData
            {
                Id = id,
                Quantity = qty
            };

            var client = CreateClient("https://qacandidatetest.ensek.io/");
            var request = new RestRequest($"{pathTemplate}{data.Id}/{data.Quantity}", Method.Put);
            var response = client.Execute(request);

            if (response.StatusCode != status)
            {
                Assert.Fail();
            }

            return response;
        }

        public class BuyEnergyRequestData
        {
            public int Id { get; set; }
            public int Quantity { get; set; }
        }

    }
}
