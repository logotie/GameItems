using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        public string PayloadId { get; set; }
        public string title { get; set; }

        public string description { get; set; }

        public string by { get; set; }

        [NotMapped]
        public IList<string> platform { get; set; }

        //We cannot store an arraylist of strings in the Db, so instead we convert
        //to a string and store it here.
        [JsonIgnore]
        public string platformString { get; set; }

        public string age_rating { get; set; }

        public int likes { get; set; }

        public List<Comment> comments { get; set; }

        public void AlterModelForDbStorage()
        {
            //Join all the strings together and store.
            platformString = String.Join(",", platform.ToArray());
        }
    }
}
