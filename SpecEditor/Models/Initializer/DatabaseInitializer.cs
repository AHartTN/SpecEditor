using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using SpecEditor.Models.Binding;
using SpecEditor.Models.Context;

namespace SpecEditor.Models.Initializer
{

	//public class DatabaseInitializer : DropCreateDatabaseIfModelChanges<SpecEditorContext>
	//public class DatabaseInitializer : DropCreateDatabaseAlways<SpecEditorContext>
	public class DatabaseInitializer : CreateDatabaseIfNotExists<SpecEditorContext>
	{
		public DatabaseInitializer()
		{
			//try
			//{
			//	using (SpecEditorContext entities = new SpecEditorContext())
			//	{
			//		if (!entities.Database.Exists())
			//		{
			//			DateTime limit = DateTime.Now.AddSeconds(30);

			//			((IObjectContextAdapter)entities).ObjectContext.CreateDatabase();

			//			bool success = false;

			//			while (!success && DateTime.Now < limit)
			//			{
			//				if (entities.Database.Exists())
			//					success = true;
			//			}
			//			if (!success)
			//				throw new Exception(
			//					"Something went wrong when trying to create the database! The 30 second timeout has been exceeded an the database still shows as not existing.");
			//		}
			//	}
			//}
			//catch (Exception ex)
			//{
			//	throw new InvalidOperationException(
			//		"The SpecEditor database could not be initialized.",
			//		ex);
			//}
		}

		protected override void Seed(SpecEditorContext db)
		{
			SqlHelper sqlHelper = new SqlHelper();
			sqlHelper.RefreshDatabase(db);
		}
	}
}