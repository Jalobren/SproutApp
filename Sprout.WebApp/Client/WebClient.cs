using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace Sprout.WebApp.Client
{
    public class WebClient : IWebClient
    {
        private System.Net.Http.HttpClient _httpClient;

        private string ServiceUrl { get; set; }

        public WebClient()
        {
            ServiceUrl = ConfigurationManager.AppSettings["api:baseUrl"];
        }

        public async Task<T> GetAsync<T>(string relativePath)
        {
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, ServiceUrl + relativePath);
            HttpResponseMessage apiResponse = await this.Client.SendAsync(request);

            if (apiResponse.IsSuccessStatusCode)
            {
                var responseData = apiResponse.Content.ReadAsStringAsync().Result;

                if (!string.IsNullOrWhiteSpace(responseData))
                {
                    return JsonConvert.DeserializeObject<T>(responseData);
                }
            }
            else
            {
                return default(T);
            }
            return default(T);
        }


        protected HttpClient Client
        {
            get
            {
                if (this._httpClient == null)
                {
                    this._httpClient = new HttpClient();
                }

                return this._httpClient;
            }
        }


    }
}