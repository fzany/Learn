using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Learn
{
    public class Rester
    {
        public static async Task<string> GetUsers()
        {
            HttpClient client = new HttpClient() { BaseAddress = new Uri("https://randomuser.me/") };
            HttpResponseMessage response = await client.GetAsync("api");
            var returnString =  await response.Content.ReadAsStringAsync();
            return returnString;
        }
    }
}
