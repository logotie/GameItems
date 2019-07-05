using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameItems.Model.Games
{
    public class Comment
    {
        public string user { get; set; }
        public string message { get; set; }
        public string dateCreated { get; set; }
        public int like { get; set; }
    }
}
