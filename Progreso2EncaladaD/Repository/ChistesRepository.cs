using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace Progreso2EncaladaD.Repository
{
    internal class ChistesRepository
    {
        internal async Task<string> GetChisteAsync()
        {
            throw new NotImplementedException();
        }

        public class ChisteRepository
        {
            private readonly HttpClient _httpClient;

            public ChisteRepository()
            {
                _httpClient = new HttpClient();
            }

            public async Task<string> GetChisteAsync()
            {
                var response = await _httpClient.GetStringAsync("https://official-joke-api.appspot.com/random_joke");
                var json = JObject.Parse(response);
                string setup = json["setup"]?.ToString();
                string punchline = json["punchline"]?.ToString();
                return $"{setup}\n\n{punchline}";
            }
        }
    }

}
