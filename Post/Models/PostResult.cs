using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Post.Models
{
    public class PostResult
    {
        

        [JsonPropertyName("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [JsonPropertyName("userId")]
        public int UserId { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("body")]
        public string Body { get; set; }

        public List<Comment> Comments { get; set; }

        public PostResult()
        {
        }
    }
}
