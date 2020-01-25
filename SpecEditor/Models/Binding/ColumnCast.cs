using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SpecEditor.Models.Binding
{
    [Table("Mapping.ColumnCast")]
    public partial class ColumnCast
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ColumnCast()
        {
            Columns = new HashSet<Column>();
        }

        public int ID { get; set; }

        public int SystemTypeID { get; set; }

        public int UserTypeID { get; set; }

        [Required]
        [StringLength(128)]
        public string SQLTypeName { get; set; }

        [StringLength(128)]
        public string CLRTypeName { get; set; }

        [StringLength(128)]
        public string DotNetTypeName { get; set; }

        public short? MaxLength { get; set; }

        public byte? Precision { get; set; }

        public byte? Scale { get; set; }

        public bool IsNullable { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Column> Columns { get; set; }
    }
}
