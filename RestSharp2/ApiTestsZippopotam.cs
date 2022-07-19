using NUnit.Framework;
using RestSharp;
using RestSharp.Serializers.Json;
using System.Threading.Tasks;

namespace RestSharp2
{
    public class ApiTestsZippopotam
    {
        private RestClient client;

        [SetUp]
        public void SetUp()
        {
            
                       
        }

        [TestCase("BG", "1000", "Sofija")]
        [TestCase("BG", "5000", "Veliko Turnovo")]
        [TestCase("CA", "M5S", "Toronto")]
        [TestCase("GB", "B1", "Birmingham")]
        [TestCase("DE", "01067", "Dresden")]
        public async Task TestZippopotam(string countryCode, string zipCode, string expectedPlace)
        {
            var client = new RestClient("https://api.zippopotam.us");
            var request = new RestRequest(countryCode + "/" + zipCode);
            var responce = await client.ExecuteAsync(request, Method.Get);
            var location = new SystemTextJsonSerializer().Deserialize<Location>(responce);
            StringAssert.Contains(expectedPlace, location.Places[0].PlaceName);
        }
    }
}