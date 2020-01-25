using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using SpecEditor.Models.Context;

namespace SpecEditor.Models.Binding
{
    [Table("Schematic.Column")]
    public partial class Column
    {
	    private int _columnCastId;

	    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Column()
        {
            ColumnMaps = new HashSet<ColumnMap>();
        }

        public int ID { get; set; }

		public int TableID { get; set; }

	    public int ColumnCastID
	    {
		    get
		    {
			    if (!(_columnCastId > 0))
			    {
				    using (SpecEditorContext db = new SpecEditorContext())
				    {
					    ColumnCast cast = db.ColumnCasts.FirstOrDefault(f => f.SystemTypeID == SystemTypeID && f.UserTypeID == UserTypeID);
					    _columnCastId = cast.ID;
				    }
			    }
			    return _columnCastId;
		    }
		    set => _columnCastId = value;
	    }

	    public int Index { get; set; }

        [Required]
        [StringLength(128)]
        public string Name { get; set; }

	    public short? MaxLength { get; set; }

	    public byte? Precision { get; set; }

	    public byte? Scale { get; set; }

		public bool Nullable { get; set; }

		public bool IsLocked { get; set; }

	    [NotMapped]
	    public int SystemTypeID { get; set; }

	    [NotMapped]
	    public int UserTypeID { get; set; }

		public DateTime? FirstSeen { get; set; }

	    public DateTime? LastSeen { get; set; }

	    public virtual Table Table { get; set; }

		public virtual ColumnCast ColumnCast { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ColumnMap> ColumnMaps { get; set; }
    }
}
