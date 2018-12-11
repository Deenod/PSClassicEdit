using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSClassicEdit.GameService.Models
{
    public class GameInfo
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Publisher { get; set; }
        public int Year { get; set; }
        public int Players { get; set; }
        public List<string> DiscIds { get; set; }

        public GameInfo()
        {
            DiscIds = new List<string>();
        }
    }
}
