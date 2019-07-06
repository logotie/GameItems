using GameItems.Model.Games;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameItems.Services.Games
{
    public interface IGameRetrieval
    {
        Game RetrieveGameById(int gameId);
    }
}
