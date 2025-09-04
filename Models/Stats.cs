using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Table("F2_STATS")]
    public class Stats
    {
        [Column("ID_STATS"), Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("RACE_STARTS")]
        public int RaceStarts { get; set; }

        [Column("WINS")]
        public int Wins { get; set; }

        [Column("TOP3")]
        public int Top3 { get; set; }

        [Column("TOP5")]
        public int Top5 { get; set; }

        [Column("TOP10")]
        public int Top10 { get; set; }

        [Column("POLES")]
        public int Poles { get; set; }

        [Column("FASTEST_LAPS")]
        public int FastestLaps { get; set; }
    }
}
