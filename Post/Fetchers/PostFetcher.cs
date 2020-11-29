using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Post.Fetchers
{
    public class PostFetcher
    {
        private readonly HttpClient httpClient;
        public PostFetcher()
        {
            httpClient = new HttpClient();
        }

        public async Task<string> FetchPosts()
        {
            Task<string> response = httpClient.GetStringAsync("https://jsonplaceholder.typicode.com/posts");
            string jsonString = await response;
            return jsonString;
        }
    }
}
