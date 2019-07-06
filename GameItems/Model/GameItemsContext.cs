using GameItems.Model.Games;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameItems.Model
{
    /// <summary>
    /// Primary class responsible for handling db operations
    /// </summary>
    public class GameItemsContext: DbContext
    {
        public GameItemsContext(DbContextOptions<GameItemsContext> options) : base(options)
        {

        }

        //DbSet collection of Game objects, similar to a table and rows.
        public DbSet<Game> Games { get; set; }
        //Dbset collection of comments
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Payload> Payloads { get; set; }

    }
}
