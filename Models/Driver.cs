using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    [Table("F2_DRIVER")]
    public class Driver
    {
        [Column("ID_DRIVER"), Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("NAME")]
        public string Name { get; set; }

        [Column("DESCRIPTION")]
        public string? Description { get; set; }

        [Column("IMAGE_ROUTE")]
        public string? ImgSrc { get; set; }

        [Column("ID_COUNTRY")]
        public int? CountryId { get; set; }

        [ForeignKey("CountryId")]
        public Country? Country { get; set; }

        [Column("ID_STATS")]
        public int? StatsId { get; set; }

        [ForeignKey("StatsId")]
        public Stats? Stats { get; set; }

        //public List<Competition> CompetitionList { get; set; }
    }
}