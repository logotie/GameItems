using GameItems.Model.Games;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameItems.Model.Generator
{
    public class DbContextInitiallizer
    {
        //DbContext is the link between the database and my models.
        public static void Initialize(GameItemsContext dbContext)
        {
            //What does a db context do?
            dbContext.Database.EnsureCreated();

            if(dbContext.Games.Any())
            {
                return; //Test data has already been added.
            }

            Game sampleGameData = SampleDataGenerator.GenerateSampleGameData();

            dbContext.Games.Add(sampleGameData);

            dbContext.SaveChanges();
        }

    }
}
