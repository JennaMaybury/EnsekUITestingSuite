using System;
using System.Net;
using EnsekApiTestingSuite.ApiPages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestSharp;
using TechTalk.SpecFlow;

namespace EnsekApiTestingSuite.Steps
{
    [Binding]
    public class BuyEnergyStepDefinitions
    {
        public BuyApiModel _BuyApiModel;
        public RestResponse _BuyRequest = null!;

        public BuyEnergyStepDefinitions(BuyApiModel buyApiModel)
        {
            _BuyApiModel = buyApiModel;
        }


        [When(@"A call is made to the buy energy end point using '([^']*)' with '([^']*)' values")]
        public void WhenACallIsMadeToTheBuyEnergyEndPointUsingWithValues(string post, string valid)
        {
            //idea was to make it dynamic to allow all calls to be done via one step and pass in expected status code and method + data
            _BuyRequest = _BuyApiModel.BuyEnergyRequest(1, 10, HttpStatusCode.OK);
        }

        [Then(@"'([^']*)' status code is returned")]
        public void ThenStatusCodeIsReturned(string p0)
        {
            //idea was to make it dynamic to allow all calls to be done via one step and pass in expected status code to compare against
            Assert.AreEqual(HttpStatusCode.OK, _BuyRequest.StatusCode);
        }

        [Then(@"'([^']*)' message is returned within the body")]
        public void ThenMessageIsReturnedWithinTheBody(string success)
        {
            //todo: add call to check message returned from api response against expected message and compare data within for expected vs actual
        }
    }
}
