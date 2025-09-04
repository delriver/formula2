using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Table("F2_RACE")]
    public class Race
    {
        [Column("ID_RACE"), Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("NAME")]
        public string Name { get; set; }

        [Column("DESCRIPTION")]
        public string? Description { get; set; }

        [Column("ID_CIRCUIT")]
        public int CircuitId { get; set; }

        [ForeignKey("CircuitId")]
        public Circuit? circuit { get; set; }

        [Column("IMAGE_ROUTE")]
        public string? ImgSrc { get; set; }

        [Column("LAP_NUMBER")]
        public int Laps { get; set; }

        [Column("ID_COUNTRY")]
        public int CountryId { get; set; }

        [ForeignKey("CountryId")]
        public Country? Country { get; set; }

        
        //public List<Driver> drivers { get; set; }
        //public List<Competition> competitions { get; set; }
    }
}
