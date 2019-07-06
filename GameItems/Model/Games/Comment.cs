using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GameItems.Model.Games
{
    ///<summary>  
    ///Model class for the Comment JSON
    /// {
    /// "user":"bob",
    /// "message":"Cracking game far too much cinematic",
    /// "dateCreated":"2011-01-03",
    /// "like":6
    /// }
    /// </summary>
    public class Comment
    {
        [JsonProperty("user")]
        public string user { get; set; }

        [JsonProperty("message")]
        public string message { get; set; }

        [JsonProperty("dateCreated")]
        public string dateCreated { get; set; }

        [JsonProperty("like")]
        public int like { get; set; }
    }
}
