using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Table("F2_TEAM")]
    public class Team
    {
        [Column("ID_TEAM"), Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("NAME")]
        public string Name { get; set; }

        [Column("DESCRIPTION")]
        public string? Description { get; set; }

        [Column("ID_STATS")]
        public int StatsId { get; set; }

        [ForeignKey("StatsId")]
        public Stats? Stats { get; set; }

        //public List<Driver> Drivers { get; set; }
    }
}
