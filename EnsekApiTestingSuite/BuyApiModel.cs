using RestSharp;

namespace EnsekApiTestingSuite
{
    public class BuyApiModel: ApiBasePage

    {
        public BuyApiModel()
        {

        }

        public RestRequest BuyEnergyRequest()
        {
            CreateClient("https://qacandidatetest.ensek.io");
            RestRequest request = new RestRequest("/ENSEK/buy/1/5335'", Method.Put);
            var response = request;

            return response;
        }
    }
}
