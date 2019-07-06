using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GameItems.Model.Games
{
    ///<summary>  
    ///Model class for the Game JSON
    ///{
    ///"id":2,
    ///"payload":{
    ///"title":"Uncharted 4",
    ///"description":"For the first time ever in Uncharted",
    ///"by":"Sony",
    ///"platform":["PS4"],
    ///"age_rating":"16",
    ///"likes":100,
    ///"comments":
    ///[{"user":"bob","message":"Cracking game far too much cinematic","dateCreated":"2011-01-03","like":6}
    ///,{"user":"testingPriest","message":"Not enough shooting for me,far too easy ","dateCreated":"2011-04-02","like":5}]
    ///}
    ///}
    ///
    /// </summary>
    public class Game
    {
        [Key]
        [JsonIgnore]
        public int id { get; set; }
        public Payload payload { get; set; }
    }
}
