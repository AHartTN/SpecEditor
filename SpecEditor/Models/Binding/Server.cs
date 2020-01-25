using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace SpecEditor.Models.Binding
{
    [Table("Schematic.Server")]
    public partial class Server
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Server()
        {
            Columns = new HashSet<Column>();
            Databases = new HashSet<Database>();
        }

        public int ID { get; set; }

		[Required]
		[StringLength(128)]
	    public string ServerName { get; set; }

	    [StringLength(128)]
	    public string InstanceName { get; set; }

	    [StringLength(20)]
	    public string Version { get; set; }

		public bool IsClustered { get; set; }

	    public DateTime? FirstSeen { get; set; }

	    public DateTime? LastSeen { get; set; }

		[NotMapped]
	    public string HostName => $"{ServerName}{InstanceName.IfNotNullOrWhiteSpace($"\\{InstanceName}")}";
		[NotMapped]
	    public string DisplayName => $"{(IsClustered ? "(C) " : "")}{HostName} ({Version})";
		[NotMapped]
		public int MajorRelease => int.TryParse(Version?.Split('.').FirstOrDefault(), out int i) ? i : 0;
		[NotMapped]
		public int MinorRelease => int.TryParse(Version?.Split('.').Skip(1).FirstOrDefault(), out int i) ? i : 0;
		[NotMapped]
		public int MaintenanceRelease => int.TryParse(Version?.Split('.').Skip(2).FirstOrDefault(), out int i) ? i : 0;
		[NotMapped]
		public int BuildNumber => int.TryParse(Version?.Split('.').Skip(3).FirstOrDefault(), out int i) ? i : 0;

		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Column> Columns { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Database> Databases { get; set; }
	}
}
