using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GameItems.Model.Games
{
    ///<summary> 
    ///Model class for the Payload JSON
    ///{
    ///"title":"Uncharted 4",
    ///"description":"For the first time ever in Uncharted history",
    ///"by":"Sony",
    ///"platform":["PS4"],
    ///"age_rating":"16",
    ///"likes":100,
    ///"comments":
    ///[
    ///{"user":"bob","message":"Cracking game far too much cinematic","dateCreated":"2011-01-03","like":6}
    ///]
    ///}
    /// </summary>
    public class Payload
    {
        [Key]
        [JsonIgnore]
        public int PayloadId { get; set; }
        [JsonProperty("title")]
        public string title { get; set; }

        [JsonProperty("description")]
        public string description { get; set; }

        [JsonProperty("by")]
        public string by { get; set; }

        [JsonProperty("platform")]
        public IList<string> platform { get; set; }

        [JsonProperty("age_rating")]
        public string age_rating { get; set; }

        [JsonProperty("likes")]
        public int likes { get; set; }

        [JsonProperty("comments")]
        public IList<Comment> comments { get; set; }
    }
}
