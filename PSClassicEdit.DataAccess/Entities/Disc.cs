using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSClassicEdit.DataAccess.Entities
{
    [Table("DISC")]
    public class Disc
    {
        [Column("DISC_ID")]
        public int DiscId { get; set; }

        [Column("GAME_ID")]
        public int GameId { get; set; }

        [Column("DISC_NUMBER")]
        public int DiscNumber { get; set; }

        [Column("BASENAME")]
        public string DiscBasename { get; set; }
    }
}
