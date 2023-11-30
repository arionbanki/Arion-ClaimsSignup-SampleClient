using System.Text;
using System.Text.Json;

namespace Arion.ClaimsSignup.SampleClient.RequestsApiHelper
{
    public static class ApiHelper
    {
        public static StringContent CreateSerializedRequest<TRequest>(TRequest request)
        {
            return CreateSerializedRequest(request, GetDefaultNamingStrategy());
        }

        public static StringContent CreateSerializedRequest<TRequest>(TRequest request, JsonNamingPolicy namingPolicy)
        {
            var result = new StringContent(JsonSerializer.Serialize(request, new JsonSerializerOptions
            {
                PropertyNamingPolicy = namingPolicy,
                WriteIndented = true // Optional: makes the JSON output more readable
            }), Encoding.UTF8, "application/json");

            return result;
        }

        internal static JsonNamingPolicy GetDefaultNamingStrategy()
        {
            return JsonNamingPolicy.CamelCase;
        }
    }
}
