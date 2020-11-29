using System;
using System.Text.Json.Serialization;

namespace Post.Models
{
    public class PostResult
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("userId")]
        public int UserId { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("body")]
        public string Body { get; set; }

        public PostResult()
        {
        }
    }
}
