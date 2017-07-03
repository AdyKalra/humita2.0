using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using Zukini.API.Services;

namespace Zukini.API.Examples.Features.Ccmsi.IdentityServer.Request
{
    public class SearchIdentityServer : CcmsiService
    {
        public Uri BaseApiUrl
        {
            get { return new Uri(TestSettings.ApiMobileUrlDEV); }
        }

        public IdentityServerTokenDTO getIdentityServerTokenDTO()
        {
            var client = new RestClient(TestSettings.IdentityServerApiUrlDEV);
            var request = new RestRequest("/connect/token", Method.POST);
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("content-type", "application/x-www-form-urlencoded");
            request.AddParameter("application/x-www-form-urlencoded", "grant_type=password&username=sblakeney&password=Devpass2&scope=ccmsimobileapi%20offline_access&client_id=ccmsiapi&client_secret=z3oKWgpX4JZulVlgnCCX7ffDkNbQH4zV", ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
           
            return getDeserializeResponse<IdentityServerTokenDTO>(response);

        }
    }
}
