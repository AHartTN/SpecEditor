using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SpecEditor.Models.Binding
{
    [Table("Schematic.Schema")]
    public partial class Schema
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Schema()
        {
            Tables = new HashSet<Table>();
        }

        public int ID { get; set; }

	    public int DatabaseID { get; set; }

	    public int SchemaID { get; set; }

		[Required]
        [StringLength(128)]
        public string Name { get; set; }

	    public DateTime? FirstSeen { get; set; }

	    public DateTime? LastSeen { get; set; }

		public virtual Database Database { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Table> Tables { get; set; }
    }
}
