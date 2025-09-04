using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    [Table("F2_DRIVER_COMPETITION")]
    public class DriverCompetition
    {
        [Column("ID_F2_DRIVER_COMPETITION"), Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("ID_DRIVER")]
        public int DriverId { get; set; }

        [ForeignKey(nameof(DriverId))]
        public Driver? Driver { get; set; }

        [Column("ID_COMPETITION")]
        public int CompetitionId { get; set; }

        [ForeignKey(nameof(CompetitionId))]
        public Competition? Competition { get; set; }

        [Column("ID_TEAM")]
        public int TeamId { get; set; }

        [ForeignKey(nameof(TeamId))]
        public Team? Team { get; set; }
    }
}
