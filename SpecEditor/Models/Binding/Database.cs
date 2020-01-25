using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SpecEditor.Models.Binding
{
    [Table("Schematic.Database")]
    public partial class Database
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Database()
        {
            Schemata = new HashSet<Schema>();
        }

        public int ID { get; set; }

        public int ServerID { get; set; }

        public int DatabaseID { get; set; }

        [Required]
        [StringLength(128)]
        public string Name { get; set; }

	    public DateTime? FirstSeen { get; set; }

	    public DateTime? LastSeen { get; set; }

		public virtual Server Server { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Schema> Schemata { get; set; }
    }
}
