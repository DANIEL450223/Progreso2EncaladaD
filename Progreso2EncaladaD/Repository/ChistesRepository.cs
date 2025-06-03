using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace Progreso2EncaladaD.Repository
{
    public class ChistesRepository
    {
        private readonly HttpClient _httpClient;
        public ChistesRepository()
        {
            _httpClient = new HttpClient();
        }
            internal async Task<string> GetChisteAsync()
            {
                var response = await _httpClient.GetStringAsync("https://official-joke-api.appspot.com/random_joke");
                var json = JObject.Parse(response);
                string setup = json["setup"]?.ToString();
                string punchline = json["punchline"]?.ToString();
                return $"{setup}\n\n{punchline}";
            }
        
    }

}
