using System;
using System.Threading;
using System.Windows.Forms;
using SpecEditor.Models.Context;

namespace SpecEditor
{
	internal static class Program
	{
		private static readonly SqlHelper SQLHelper = new SqlHelper();
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		private static void Main()
		{
			Thread thread = new Thread(AddServers);
			thread.Start();

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new frm_Main());
		}

		private static void AddServers()
		{
			using (SpecEditorContext db = new SpecEditorContext())
			{
				SQLHelper.AddServers(db);
			}
		}
	}
}
