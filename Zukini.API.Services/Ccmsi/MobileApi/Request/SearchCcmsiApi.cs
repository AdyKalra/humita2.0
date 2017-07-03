using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using Zukini.API.Examples.Features.Ccmsi.MobileApi.Response;
using Zukini.API.Services;

namespace Zukini.API.Examples.Features.Ccmsi.MobileApi.Request
{
    public class SearchCcmsiApi : CcmsiService
    {
        public Uri BaseApiUrl
        {
            get { return new Uri(TestSettings.ApiMobileUrlDEV); }
        }

        public RootObject getClientList(String userId, String accessToken)
        {
            var client = new RestClient(BaseApiUrl + "/Clients?userId=" + userId);
            IRestResponse response = getResponseWithaddAuthorizationHeaders(client, accessToken);
            return getDeserializeResponse<RootObject>(response);
        }

        public RootObject getClaimList(String userId, String clientNumber, String accessToken)
        {
            var client = new RestClient(BaseApiUrl + "/Claims?clientNumber=" + clientNumber + "&userId=" + userId);
            IRestResponse response = getResponseWithaddAuthorizationHeaders(client, accessToken);
            return getDeserializeResponse<RootObject>(response);
        }

        private IRestResponse getResponseWithaddAuthorizationHeaders(IRestClient client, String accessToken)
        {
            var request = new RestRequest(Method.GET);
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("authorization", "Bearer " + accessToken);
            IRestResponse response = client.Execute(request);
            return response;
        }

    }
}
