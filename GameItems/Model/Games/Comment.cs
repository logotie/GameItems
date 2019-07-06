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
        [Key]
        [JsonIgnore]
        public int CommentId { get; set; }
        public string user { get; set; }
        public string message { get; set; }
        public string dateCreated { get; set; }
        public int like { get; set; }
    }
}
