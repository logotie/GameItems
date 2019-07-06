using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameItems.Model;
using GameItems.Model.Games;

namespace GameItems.Services.Games
{
    public class GameRetrieval : IGameRetrieval
    {
        private readonly GameItemsContext gameItemsContext;

        public GameRetrieval(GameItemsContext _gameItemsContext)
        {
            gameItemsContext = _gameItemsContext;
        }

        public Game RetrieveGameById(int gameId)
        {
            throw new NotImplementedException();
        }
    }
}
