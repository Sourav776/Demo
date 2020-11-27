using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;

namespace Demo.Helper
{
    public class CallApi
    {
        internal HttpClient client = new HttpClient();

        public CallApi()
        {
            BaseUrlSet();
        }

        public CallApi(string address)
        {
            BaseUrlSet(address);
        }

        public void BaseUrlSet()
        {
            client.BaseAddress = new Uri(ConfigurationManager.AppSettings["BaseUrl"]);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        }
        public void BaseUrlSet(string address)
        {
            client.BaseAddress = new Uri(address);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}