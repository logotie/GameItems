using GameItems.Model.Games;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameItems.Model.Generator
{
    public class SampleDataGenerator
    {
        public static Game GenerateSampleGameData()
        {
            String sampleGamesJson = GameItems.Resource.SampleJsonData;
            Game sampleData = JsonConvert.DeserializeObject<Game>(sampleGamesJson);
            return sampleData;
        }
    }
}
