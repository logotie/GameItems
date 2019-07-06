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
        private readonly SampleData sampleData;

        public SampleDataGenerator()
        {
            String sampleGamesJson = GameItems.Resource.SampleJsonData;
            sampleData = JsonConvert.DeserializeObject<SampleData>(sampleGamesJson);
        }

        public List<Game> GetAllGames()
        {
            return sampleData.games;
        }

    }
}
