using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    [Table("F2_CATEGORY")]
    public class Category
    {
        [Column("ID_CATEGORY"), Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("NAME")]
        public string Name { get; set; }

        //public CarType Cars { get; set; }
    }
}