using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static EnsekApiTestingSuite.ApiPages.BuyApiModel;

namespace EnsekApiTestingSuite.ApiPages
{
    public class EnergyApi : ApiBasePage
    {
        public string pathTemplate = "ENSEK/energy";

        public EnergyApi() { }

        public RestResponse<Electric> GetEnergyRequest(HttpStatusCode status)
        {

            var client = CreateClient("https://qacandidatetest.ensek.io/");
            var request = new RestRequest($"{pathTemplate}", Method.Get);
            var response = client.Execute<Electric>(request);


            if (response.StatusCode != status)
            {
                Assert.Fail();
            }
            return response;
        }

        public class Electric
        {
            public Electric() { }

            int[] energy_id { get; set; }
            int[] price_per_unit { get; set; }
            int[] quantity_of_units { get; set; }
            string[] unit_type { get; set; }
        }

    }
}
