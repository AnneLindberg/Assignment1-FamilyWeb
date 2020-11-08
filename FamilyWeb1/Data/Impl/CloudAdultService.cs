using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Models;

namespace FamilyWeb1.Data.Impl
{
    public class CloudAdultService : IAdultService
    {
        private HttpClient _client;


        public CloudAdultService()
        {
            this._client = new HttpClient();
        }

        public async Task<IList<Adult>> GetAdultsAsync()
        {
            HttpClient client = new HttpClient();
            string message = await client.GetStringAsync("https://localhost:5005/Adults");
            Console.WriteLine(message);
            List<Adult> result = JsonSerializer.Deserialize<List<Adult>>(message);
            return result;
        }

        public async Task AddAdultAsync(Adult adult)
        {
            Console.WriteLine(adult.ToString());
            string todoSerialized = JsonSerializer.Serialize(adult);
            StringContent content = new StringContent(
                todoSerialized,
                Encoding.UTF8,
                "application/json"
            );
            HttpResponseMessage responseMessage = await _client.PostAsync("https://localhost:5005/Adults", content);
            //return responseMessage;
        }

    }
}