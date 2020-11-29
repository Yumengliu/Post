using System;
using System.Threading.Tasks;
using Post.Fetchers;

namespace Post
{
    class Program
    {
        static async Task Main(string[] args)
        {
            PostFetcher postFetcher = new PostFetcher();
            Console.WriteLine(await postFetcher.FetchPosts());
        }
    }
}
