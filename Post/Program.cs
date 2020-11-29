using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Post.Fetchers;
using Post.Models;
using Post.Repository;

namespace Post
{
    class Program
    {
        static async Task Main(string[] args)
        {
            PostRepository postRepository = new PostRepository();
            PostFetcher postFetcher = new PostFetcher();
            List<PostResult> PostResults = await postFetcher.FetchPosts();
            postRepository.Posts.AddRange(PostResults);
            postRepository.SaveChanges();
        }
    }
}
