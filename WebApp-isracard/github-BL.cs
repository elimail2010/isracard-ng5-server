using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Octokit;
using System.Net.Http.Headers;
using System.Net;

namespace WebApp_isracard.bl
{
    public class Product
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
    }

    public class github_BL
    {
        static HttpClient client = new HttpClient();
        public static string getGithubRepo(string query)
        {
            if (string.IsNullOrEmpty(query)) return null;
            //use for https urls:
            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;

            string response=null;
            string url = "https://api.github.com/search/repositories?q=" + query;
            client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 6.1; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/58.0.3029.110 Safari/537.36");
            try
            {
                response= client.GetStringAsync(new Uri(url)).Result;
            }
            catch (Exception)
            {
                //if error occurs - return null object to client
                //throw;
            }

            
            return response;
        }


     

    }
}