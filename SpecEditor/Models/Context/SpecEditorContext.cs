using System.Data.Entity;
using SpecEditor.Models.Binding;
using SpecEditor.Models.Initializer;

namespace SpecEditor.Models.Context
{
	public partial class SpecEditorContext : DbContext
	{
		public SpecEditorContext()
			: base("name=SpecEditor")
		{

		}

		static SpecEditorContext()
		{
			System.Data.Entity.Database.SetInitializer(new DatabaseInitializer());
		}

		public virtual DbSet<Client> Clients { get; set; }
		public virtual DbSet<ColumnCast> ColumnCasts { get; set; }
		public virtual DbSet<ColumnMap> ColumnMaps { get; set; }
		public virtual DbSet<Column> Columns { get; set; }
		public virtual DbSet<Binding.Database> Databases { get; set; }
		public virtual DbSet<Schema> Schemata { get; set; }
		public virtual DbSet<Server> Servers { get; set; }
		public virtual DbSet<Table> Tables { get; set; }
		public virtual DbSet<Import> Imports { get; set; }
		public virtual DbSet<Data> Data { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Client>()
				.HasMany(e => e.ColumnMaps)
				.WithRequired(e => e.Client)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<ColumnCast>()
				.HasMany(e => e.Columns)
				.WithRequired(e => e.ColumnCast)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Server>()
				.HasMany(e => e.Databases)
				.WithRequired(e => e.Server)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Binding.Database>()
				.HasMany(e => e.Schemata)
				.WithRequired(e => e.Database)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Schema>()
				.HasMany(e => e.Tables)
				.WithRequired(e => e.Schema)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Table>()
				.HasMany(e => e.Columns)
				.WithRequired(e => e.Table)
				.HasForeignKey(e => e.TableID)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Column>()
				.HasMany(e => e.ColumnMaps)
				.WithRequired(e => e.Column)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<ColumnMap>()
				.Property(e => e.Identifier)
				.IsUnicode(false);

			modelBuilder.Entity<Import>()
				.HasMany(m => m.Data)
				.WithRequired(r => r.ImportRecord)
				.HasForeignKey(fk => fk.ImportID);
		}

	}
}
