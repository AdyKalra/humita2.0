using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace Zukini.API.Services
{
    public abstract class CcmsiService
    {

        public T getDeserializeResponse<T>(IRestResponse response)
        {
            var content = response.Content;
            JObject jObject = JObject.Parse(content);
            string json = JsonConvert.SerializeObject(jObject);
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            return serializer.Deserialize<T>(json);
        }
    }
}
