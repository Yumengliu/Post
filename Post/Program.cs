using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Post.Fetchers;
using Post.Models;

namespace Post
{
    class Program
    {
        static async Task Main(string[] args)
        {
            PostFetcher postFetcher = new PostFetcher();
            List<PostResult> PostResults = await postFetcher.FetchPosts();
            foreach(PostResult p in PostResults)
            {
                Console.WriteLine(p.Id);
            }
        }
    }
}
