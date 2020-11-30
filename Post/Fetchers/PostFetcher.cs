using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Post.Models;

namespace Post.Fetchers
{
    public class PostFetcher
    {
        private readonly HttpClient httpClient;
        public PostFetcher()
        {
            httpClient = new HttpClient();
        }

        public async Task<List<PostResult>> FetchPosts()
        {
            Task<string> response = httpClient.GetStringAsync("https://jsonplaceholder.typicode.com/posts");
            string jsonString = await response;
            return JsonSerializer.Deserialize<List<PostResult>>(jsonString);
        }

        public async Task<List<Comment>> FetchComments(int PostId)
        {
            Task<string> response = httpClient.GetStringAsync("https://jsonplaceholder.typicode.com/comments?postId=" + PostId);
            string jsonString = await response;
            return JsonSerializer.Deserialize<List<Comment>>(jsonString);

        }
    }
}
