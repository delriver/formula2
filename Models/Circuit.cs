using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    [Table("F2_CIRCUIT")]
    public class Circuit
    {
        [Column("ID_CIRCUIT"), Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("NAME"), Required]
        public string Name { get; set; }

        [Column("DESCRIPTION")]
        public string? Description { get; set; }

        [Column("IMAGE_ROUTE")]
        public string? ImgSrc { get; set; }

        [Column("ID_COUNTRY")]
        public int CountryId { get; set; }

        [ForeignKey("CountryId")]
        public Country? Country { get; set; }

        [Column("ID_FASTEST_LAP")]
        public int IdFastestLap {  get; set; }

        [ForeignKey("IdFastestLap")]
        public FastLap? FastestLap { get; set; }
    }
}