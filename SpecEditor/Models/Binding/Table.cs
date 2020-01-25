using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SpecEditor.Models.Binding
{
	[Table("Schematic.Table")]
	public partial class Table
	{
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
		public Table()
		{
			Columns = new HashSet<Column>();
		}

		public int ID { get; set; }

		public int SchemaID { get; set; }

		public int ObjectID { get; set; }

		[Required]
		[StringLength(128)]
		public string Name { get; set; }

		public DateTime? FirstSeen { get; set; }

		public DateTime? LastSeen { get; set; }

		public virtual Schema Schema { get; set; }

		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
		public virtual ICollection<Column> Columns { get; set; }
	}
}
