using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SpecEditor.Models.Binding
{
    [Table("Mapping.ColumnMap")]
    public partial class ColumnMap
    {
        public int ID { get; set; }

        public int ClientID { get; set; }

        public int ColumnID { get; set; }

        [Required]
        [StringLength(128)]
        public string Identifier { get; set; }

        public virtual Client Client { get; set; }

        public virtual Column Column { get; set; }
    }
}
