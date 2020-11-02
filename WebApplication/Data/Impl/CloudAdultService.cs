using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Models;

namespace FamilyWeb1.Data.Impl
{
    public class CloudAdultService : IAdultService
    {
        private string adultFile = "adults.json";
        private IList<Adult> _adults;
        public async Task<IList<Adult>> GetAdultsAsync()
        {
            HttpClient client = new HttpClient();
            string message = await client.GetStringAsync("http://localhost.5003/Adults");
            Console.WriteLine(message);
            List<Adult> result = JsonSerializer.Deserialize<List<Adult>>(message);
            return result;
        }

        public async Task AddAdultAsync(Adult adult)
        {
            throw new System.NotImplementedException();
        }

        public async Task RemoveAdultAsync(Adult adult)
        {
            throw new System.NotImplementedException();
        }

        public async Task UpdateAsync(Adult adult)
        {
            throw new System.NotImplementedException();
        }
    }
}