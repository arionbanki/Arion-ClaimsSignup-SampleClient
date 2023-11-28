using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Text;

namespace Arion.ClaimsSignup.SampleClient.RequestsApiHelper
{
    public static class ApiHelper
    {
        public static StringContent CreateSerializedRequest<TRequest>(TRequest request)
        {
            return CreateSerializedRequest<TRequest>(request, GetDefaultNamingStrategy());
        }

        public static StringContent CreateSerializedRequest<TRequest>(TRequest request, NamingStrategy namingStrategy)
        {
            var result = new StringContent(JsonConvert.SerializeObject(request, new JsonSerializerSettings
            {
                ContractResolver = new DefaultContractResolver
                {
                    NamingStrategy = namingStrategy
                }
            }), Encoding.UTF8, "application/vnd.api+json");

            return result;
        }
        internal static NamingStrategy GetDefaultNamingStrategy()
        {
            return new CamelCaseNamingStrategy();
        }
    }
}
