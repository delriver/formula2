using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models.Models
{
    [Table("F2_FAST_LAP")]
    public class FastLap
    {
        [Column("ID_FAST_LAP"), Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("LAP_TIME")]
        public TimeOnly LapTime { get; set; }

        [Column("ID_DRIVER")]
        public int DriverId {  get; set; }

        [ForeignKey(nameof(DriverId))]
        public Driver Driver { get; set; }
    }
}