using System;
using System.Collections.Generic;
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
        public string title { get; set; }
        public string description { get; set; }
        public string by { get; set; }
        public string[] platform { get; set; }
        public string age_rating { get; set; }
        public int likes { get; set; }
        public Comment[] comment { get; set; }
    }
}
