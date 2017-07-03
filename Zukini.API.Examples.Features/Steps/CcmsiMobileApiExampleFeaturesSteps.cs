using System;
using TechTalk.SpecFlow;
using BoDi;
using FluentAssertions;
using NUnit.Framework;
using Zukini.API.Steps;
using Zukini.API.Examples.Features.Ccmsi.IdentityServer.Request;
using Zukini.API.Examples.Features.Ccmsi.MobileApi.Request;
using Zukini.API.Examples.Features.Ccmsi.MobileApi.Response;

namespace Zukini.API.Examples.Features.Steps
{
    [Binding]
    [Parallelizable(ParallelScope.Fixtures)]
    public class CcmsiMobileApiExampleFeaturesSteps : ApiSteps
    {
        public CcmsiMobileApiExampleFeaturesSteps(IObjectContainer objectContainer)
            : base(objectContainer)
        {
        }
        private string accessToken;
        RootObject jsonObject;

        [Given(@"an access token")]
        public void GivenAnAccessToken()
        {
            SearchIdentityServer searchIS = new SearchIdentityServer();
            accessToken = searchIS.getIdentityServerTokenDTO().access_token;
        }

        [When(@"I search for userId ""(.*)""")]
        public void WhenISearchForUserId(string userId)
        {
            SearchCcmsiApi search = new SearchCcmsiApi();
            jsonObject = search.getClientList(userId, accessToken);
        }

        [When(@"I search for userId '(.*)' and clientNumber '(.*)'")]
        public void WhenISearchForUserIdAndClientNumber(string userId, string clientNumber)
        {
            SearchCcmsiApi search = new SearchCcmsiApi();
            jsonObject = search.getClaimList(userId, clientNumber, accessToken);
        }

     
        [Then(@"the result contains (.*) and (.*)")]
        public void ThenTheResultContains(int clientValue, string clientName)
        {
            int i = clientValue - 1;
            int clientValueResponse = Int32.Parse(jsonObject.result.entityItemList[i].clientValue);
            string clientNameResponse = jsonObject.result.entityItemList[i].clientName;
            clientValue.Should().Be(clientValueResponse);
            clientNameResponse.ShouldBeEquivalentTo(clientName);
        }

        [Then(@"the result must contains (.*) and (.*)")]
        public void ThenTheResultMustContains(string claimNumber, string adjusterEmail)
        {
            string claimNumberResponse = jsonObject.result.entityItemList[0].claimNumber;
            string adjusterEmailResponse = jsonObject.result.entityItemList[0].adjusterEmail;

            claimNumber.ShouldBeEquivalentTo(claimNumberResponse);
            adjusterEmail.ShouldBeEquivalentTo(adjusterEmailResponse);                
        }
    }
}
