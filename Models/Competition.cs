using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    [Table("F2_COMPETITION")]
    public class Competition
    {
        [Column("ID_COMPETITION"), Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        //public List<Race> Races { get; set; }
        [Column("DESCRIPTION")]
        public string? Description { get; set; }

        [Column("PLAYOFFS_ON_CHAMPIONSHIP")]
        public bool Playoffs { get; set; }

        //public List<Race> PlayoffRaces { get; set; }
        //public List<Team> Teams { get; set; }
        //public List<Driver> Drivers { get; set; }

        [Column("CARS_CATEGORY")]
        public Category? Category { get; set; }
    }
}
