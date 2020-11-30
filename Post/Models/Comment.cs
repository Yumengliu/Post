using System;
using System.Text.Json.Serialization;

namespace Post.Models
{
    public class Comment
    {
        public int Id { get; set; }

        [JsonPropertyName("postId")]
        public int PostResultId { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("body")]
        public string Body { get; set; }

        public PostResult PostResult { get; set; }
        public Comment()
        {
        }
    }
}
