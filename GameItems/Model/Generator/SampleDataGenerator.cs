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
        public static SampleData GenerateSampleGameData()
        {
            String sampleGamesJson = GameItems.Resource.SampleJsonData;
            SampleData sampleData = JsonConvert.DeserializeObject<SampleData>(sampleGamesJson);
            return sampleData;
        }
    }
}
