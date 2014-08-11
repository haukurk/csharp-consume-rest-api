using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace samskip.rating_browser.Models
{
    public class RatingsAPICall
    {
        [JsonProperty(PropertyName = "data")]
        public RatingsCollection Data;
    }

    public class RatingsCollection
    {
        [JsonProperty(PropertyName = "ratings")]
        public List<Rating> Ratings;
    }

    public class Rating
    {
        [JsonProperty(PropertyName = "id")]
        public int Id;

        [JsonProperty(PropertyName = "created")]
        public DateTime Created;

        [JsonProperty(PropertyName = "fullname")]
        public string Fullname;

        [JsonProperty(PropertyName = "jirakey")]
        public string Jirakey;

        [JsonProperty(PropertyName = "stars")]
        public int Stars;

        [JsonProperty(PropertyName = "updated")]
        public DateTime Updated;

        [JsonProperty(PropertyName = "username")]
        public string Username;

        [JsonProperty(PropertyName = "comment")]
        public string Comment;
    }
}
