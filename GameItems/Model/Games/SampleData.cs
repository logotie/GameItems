﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameItems.Model.Games
{
    public class SampleData
    {
        [JsonProperty("games")]
        public IList<Game> games { get; set; }
    }
}