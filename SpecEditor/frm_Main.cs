using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using SpecEditor.Models.Binding;
using SpecEditor.Models.Context;
using Database = SpecEditor.Models.Binding.Database;

namespace SpecEditor
{
	public partial class frm_Main : Form
	{
		public SqlHelper SQLHelper = new SqlHelper();

		public static readonly IReadOnlyCollection<DialogResult> ValidResults = new[] { DialogResult.Yes, DialogResult.Retry, DialogResult.OK };
		public static readonly IReadOnlyCollection<DialogResult> InvalidResults = Enum.GetValues(typeof(DialogResult)).Cast<DialogResult>().Where(w => !ValidResults.Contains(w)).ToArray();

		private bool DatabaseEnabled => ddl_Server.SelectedValue is int i && i > 0;
		private bool SchemaEnabled => ddl_Database.SelectedValue is int i && i > 0;
		private bool TableEnabled => ddl_Schema.SelectedValue is int i && i > 0;
		private bool ColumnEnabled => ddl_Table.SelectedValue is int i && i > 0;
		private bool ClientEnabled => ddl_Client.SelectedValue is int i && i > 0;
		private bool ClientEditEnabled => dgv_Client.SelectedRows.Count > 0;
		private bool FileEnabled => ofd_ImportFile.FileNames.All(File.Exists);
		private bool MapColumnEnabled => ddl_AddColumnMapColumn.SelectedValue is int i && i > 0;

		public frm_Main()
		{
			InitializeComponent();
		}

		#region Control Events

		private void frm_Main_Load(object sender, EventArgs e)
		{
			tb_Username.Text = SQLHelper.Username;
			tb_Password.Text = SQLHelper.Password;

			tb_Username.TextChanged += Tb_Username_TextChanged;
			tb_Password.TextChanged += Tb_Password_TextChanged;

			//ToggleVisibility();
		}

		private void frm_Main_Shown(object sender, EventArgs e)
		{
			using (SpecEditorContext db = new SpecEditorContext())
			{
				Initialize(db);
			}
		}

		private void refreshServerListToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using (SpecEditorContext db = new SpecEditorContext())
			{
				PopulateServerDropdown(db);
			}
		}

		private void exitApplicationToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Environment.Exit(-1);
		}

		private void btn_SelectFile_Click(object sender, EventArgs e)
		{
			SelectFile();
		}

		private void Tb_Username_TextChanged(object sender, EventArgs e)
		{
			TextBox tb = (TextBox)sender;
			SQLHelper.Username = tb.Text;
		}

		private void Tb_Password_TextChanged(object sender, EventArgs e)
		{
			TextBox tb = (TextBox)sender;
			SQLHelper.Password = tb.Text;
		}

		private void ddl_Server_SelectedIndexChanged(object sender, EventArgs e)
		{
			tsp_Progress.Style = ProgressBarStyle.Marquee;
			ComboBox combo = (ComboBox)sender;

			if (combo.SelectedValue is int value)
				using (SpecEditorContext db = new SpecEditorContext())
					PopulateDatabaseDropdown(db, value);

			//ToggleVisibility();
			tsp_Progress.Style = ProgressBarStyle.Blocks;
		}

		private void ddl_Database_SelectedIndexChanged(object sender, EventArgs e)
		{
			tsp_Progress.Style = ProgressBarStyle.Marquee;
			ComboBox combo = (ComboBox)sender;

			if (combo.SelectedValue is int value)
				using (SpecEditorContext db = new SpecEditorContext())
					PopulateSchemaDropdown(db, value);

			//ToggleVisibility();
			tsp_Progress.Style = ProgressBarStyle.Blocks;
		}

		private void ddl_Schema_SelectedIndexChanged(object sender, EventArgs e)
		{
			tsp_Progress.Style = ProgressBarStyle.Marquee;
			ComboBox combo = (ComboBox)sender;

			if (combo.SelectedValue is int value)
				using (SpecEditorContext db = new SpecEditorContext())
					PopulateTableDropdown(db, value);

			//ToggleVisibility();
			tsp_Progress.Style = ProgressBarStyle.Blocks;
		}

		private void ddl_Table_SelectedIndexChanged(object sender, EventArgs e)
		{
			tsp_Progress.Style = ProgressBarStyle.Marquee;
			ComboBox combo = (ComboBox)sender;

			using (SpecEditorContext db = new SpecEditorContext())
			{
				if (combo.SelectedValue is int value)
				{
					PopulateColumnGrid(db, value);
					PopulateMapColumnDropdown(db, value);
				}

				PopulateColumnMapGrid(db, (int?)ddl_Table.SelectedValue, (int?)ddl_Client.SelectedValue);
			}
			//ToggleVisibility();
			tsp_Progress.Style = ProgressBarStyle.Blocks;
		}

		private void ddl_Client_SelectedIndexChanged(object sender, EventArgs e)
		{
			tsp_Progress.Style = ProgressBarStyle.Marquee;
			ComboBox combo = (ComboBox)sender;

			if (combo.SelectedValue is int value)
				using (SpecEditorContext db = new SpecEditorContext())
				{
					PopulateColumnMapGrid(db, (int?)ddl_Table.SelectedValue, value);
					foreach (DataGridViewRow row in dgv_Client.Rows)
					{
						if ((int)row.Cells["ID"].Value != value)
							continue;

						row.Selected = true;
						dgv_Client.CurrentCell = row.Cells[0];
					}
				}

			//ToggleVisibility();
			tsp_Progress.Style = ProgressBarStyle.Blocks;
		}

		private void ddl_AddColumnMapColumn_SelectedIndexChanged(object sender, EventArgs e)
		{
			tsp_Progress.Style = ProgressBarStyle.Marquee;
			ComboBox combo = (ComboBox)sender;

			if (combo.SelectedValue is int value)
			{
				foreach (DataGridViewRow row in dgv_Columns.Rows)
				{
					if ((int)row.Cells["ID"].Value != value)
						continue;

					row.Selected = true;
					dgv_Columns.CurrentCell = row.Cells[0];
				}

				ddl_EditColumnMapColumn.SelectedIndex = -1;
				tb_EditColumnMapIdentifier.Text = null;
			}

			//ToggleVisibility();
			tsp_Progress.Style = ProgressBarStyle.Blocks;
		}

		private void ddl_EditColumnMapColumn_SelectedIndexChanged(object sender, EventArgs e)
		{
			tsp_Progress.Style = ProgressBarStyle.Marquee;
			ComboBox combo = (ComboBox)sender;

			if (combo.SelectedValue is int value)
				foreach (DataGridViewRow row in dgv_Columns.Rows)
				{
					if ((int)row.Cells["ID"].Value != value)
						continue;

					row.Selected = true;
					dgv_Columns.CurrentCell = row.Cells[0];
				}

			//ToggleVisibility();
			tsp_Progress.Style = ProgressBarStyle.Blocks;
		}

		private void dgv_Client_SelectionChanged(object sender, EventArgs e)
		{
			tsp_Progress.Style = ProgressBarStyle.Marquee;
			DataGridView dgv = (DataGridView)sender;

			if (!(dgv.SelectedRows.Count > 0))
			{
				//ToggleVisibility();
				return;
			}

			DataGridViewRow row = dgv.SelectedRows[0];

			if (ddl_Client.SelectedValue != row.Cells["ID"])
				ddl_Client.SelectedValue = row.Cells["ID"].Value;

			tb_EditClientName.Text = (string)row.Cells["Name"]?.Value;
			tb_EditClientDescription.Text = (string)row.Cells["Description"]?.Value;

			//ToggleVisibility();
			tsp_Progress.Style = ProgressBarStyle.Blocks;
		}

		private void dgv_Columns_SelectionChanged(object sender, EventArgs e)
		{
			tsp_Progress.Style = ProgressBarStyle.Marquee;
			DataGridView dgv = (DataGridView)sender;

			if (!(dgv.SelectedRows.Count > 0))
			{
				//ToggleVisibility();
				return;
			}

			DataGridViewRow row = dgv.SelectedRows[0];

			if (ddl_AddColumnMapColumn.SelectedValue != row.Cells["ID"].Value)
				ddl_AddColumnMapColumn.SelectedValue = row.Cells["ID"].Value;

			//ToggleVisibility();
			tsp_Progress.Style = ProgressBarStyle.Blocks;
		}

		private void dgv_ColumnMap_SelectionChanged(object sender, EventArgs e)
		{
			tsp_Progress.Style = ProgressBarStyle.Marquee;
			DataGridView dgv = (DataGridView)sender;

			if (!(dgv.SelectedRows.Count > 0))
			{
				//ToggleVisibility();
				return;
			}

			DataGridViewRow row = dgv.SelectedRows[0];

			if (ddl_EditColumnMapColumn.SelectedValue != row.Cells["ColumnID"].Value)
				ddl_EditColumnMapColumn.SelectedValue = row.Cells["ColumnID"].Value;

			if (!tb_EditColumnMapIdentifier.Name.Equals(row.Cells["Identifier"].Value))
				tb_EditColumnMapIdentifier.Text = (string)row.Cells["Identifier"].Value;

			//ToggleVisibility();
			tsp_Progress.Style = ProgressBarStyle.Blocks;
		}

		private void dgv_ColumnMap_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode != Keys.D || (ModifierKeys & Keys.ControlKey) == Keys.ControlKey)
				return;

			IReadOnlyCollection<int> columnMapIDsToDelete = dgv_ColumnMap.SelectedRows.Cast<DataGridViewRow>().Select(row => (int)row.Cells["ID"].Value).ToArray();

			if (!columnMapIDsToDelete.Any())
				return;

			using (SpecEditorContext db = new SpecEditorContext())
			{
				IReadOnlyCollection<ColumnMap> columnMapsToDelete = db.ColumnMaps.Where(w => columnMapIDsToDelete.Contains(w.ID)).ToArray();

				string message = columnMapsToDelete.Aggregate("Are you sure you wish to delete the following column map(s)?\r\nThis action is irreversable and cannot be undone.\r\n",
					(current, columnMap) => current + $"\r\n{columnMap.Client.Name} - {columnMap.Column.Table.Name} - {columnMap.Column.Name} - {columnMap.Identifier}");

				DialogResult dr = MessageBox.Show(message, "CONFIRM COLUMN MAP DELETION", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
					MessageBoxDefaultButton.Button2);

				if (dr != DialogResult.Yes)
					return;

				db.ColumnMaps.RemoveRange(columnMapsToDelete);
				db.SaveChanges();

				PopulateColumnMapGrid(db, (int?)ddl_Table.SelectedValue, (int?)ddl_Client.SelectedValue);
			}
		}

		private void btn_EditClient_Click(object sender, EventArgs e)
		{
			if (!(dgv_Client.SelectedRows.Count > 0))
			{
				MessageBox.Show("There is no selected client. Unable to save changes.");
				return;
			}

			DataGridViewRow row = dgv_Client.SelectedRows[0];
			int id = (int)row.Cells["ID"].Value;

			using (SpecEditorContext db = new SpecEditorContext())
			{
				Client client = db.Clients.Find(id);

				if (client == null)
				{
					MessageBox.Show("The selected client does not appear to be an actual client. Unable to save changes.");
					return;
				}

				client.Name = tb_EditClientName.Text;
				client.Description = tb_EditClientDescription.Text;

				db.Entry(client).State = EntityState.Modified;
				db.SaveChanges();
			}
		}

		private void btn_EditClientReset_Click(object sender, EventArgs e)
		{
			tb_EditClientName.Text = dgv_Client.SelectedRows.Count > 0 ? (string)dgv_Client.SelectedRows[0].Cells["Name"].Value : null;
			tb_EditClientDescription.Text = dgv_Client.SelectedRows.Count > 0 ? (string)dgv_Client.SelectedRows[0].Cells["Description"].Value : null;
		}

		private void btn_AddClientClear_Click(object sender, EventArgs e)
		{
			tb_AddClientName.Text = tb_AddClientDescription.Text = null;
		}

		private void btn_AddClient_Click(object sender, EventArgs e)
		{
			if (tb_AddClientName.Text.IsNullOrWhiteSpace())
			{
				MessageBox.Show("A name is required for all clients. Please input a valid name.");
				return;
			}

			Client client = new Client
			{
				Name = tb_AddClientName.Text.Trim(),
				Description = tb_AddClientDescription.Text.IsNullOrWhiteSpace() ? null : tb_AddClientDescription.Text.Trim()
			};

			using (SpecEditorContext db = new SpecEditorContext())
			{
				db.AddRecords(new[] { client }, true);
				PopulateClientControls(db);
			}
		}

		private void btn_SaveColumnMapUpdates_Click(object sender, EventArgs e)
		{
			int? clientID = (int?)ddl_Client.SelectedValue;

			if (clientID == null || !(clientID > 0))
			{
				Message("No client is selected or the selected client has an invalid ID. Unable to process file.", "Please select a client", true);
				return;
			}

			using (SpecEditorContext db = new SpecEditorContext())
			{
				if (dgv_UnmappedColumns.Rows.Count > 0)
				{
					IReadOnlyCollection<DataGridViewRow> rows = dgv_UnmappedColumns.Rows.Cast<DataGridViewRow>().Where(w => w.Cells["ColumnID"].Value != null).ToArray();
					IReadOnlyCollection<ColumnMap> newColumnMaps = rows.Select(row => new ColumnMap
					{
						ClientID = clientID.Value,
						ColumnID = (int)row.Cells["ColumnID"].Value,
						Identifier = (string)row.Cells["Identifier"].Value
					})
						.ToArray();

					db.AddRecords(newColumnMaps, true);

					PopulateColumnMapGrid(db, (int?)ddl_Table.SelectedValue, clientID.Value);
				}

				FileInfo selectedFile = new FileInfo(ofd_ImportFile.FileName);
				PopulateFileInformationGrid(db, selectedFile);
			}
		}

		private void btn_FileRescan_Click(object sender, EventArgs e)
		{
			if (ofd_ImportFile.FileName.IsNullOrWhiteSpace())
				return;

			using (SpecEditorContext db = new SpecEditorContext())
			{
				FileInfo selectedFile = new FileInfo(ofd_ImportFile.FileName);
				PopulateFileInformationGrid(db, selectedFile);
			}
		}

		private void btn_ImportFile_Click(object sender, EventArgs e)
		{
			int? serverID = (int?)ddl_Server.SelectedValue;
			int? databaseID = (int?)ddl_Database.SelectedValue;
			int? schemaID = (int?)ddl_Schema.SelectedValue;
			int? tableID = (int?)ddl_Table.SelectedValue;
			int? clientID = (int?)ddl_Client.SelectedValue;

			if (serverID == null || !(serverID > 0))
			{
				Message("No server is selected or the selected server has an invalid ID. Unable to import file.", "Please select a server", true);
				return;
			}

			if (databaseID == null || !(databaseID > 0))
			{
				Message("No database is selected or the selected database has an invalid ID. Unable to import file.", "Please select a database", true);
				return;
			}

			if (schemaID == null || !(schemaID > 0))
			{
				Message("No schema is selected or the selected table has an invalid ID. Unable to import file.", "Please select a schema", true);
				return;
			}

			if (tableID == null || !(tableID > 0))
			{
				Message("No table is selected or the selected table has an invalid ID. Unable to import file.", "Please select a table", true);
				return;
			}

			if (clientID == null || !(clientID > 0))
			{
				Message("No client is selected or the selected client has an invalid ID. Unable to import file.", "Please select a client", true);
				return;
			}

			if (ofd_ImportFile.FileName.IsNullOrWhiteSpace() || !File.Exists(ofd_ImportFile.FileName))
			{
				Message("No file selected. Unable to import file", "Please select a file", true);
				return;
			}

			FileInfo fileInfo = new FileInfo(ofd_ImportFile.FileName);

			using (SpecEditorContext db = new SpecEditorContext())
			{
				Server server = db.Servers.Find(serverID);
				Database database = db.Databases.Find(databaseID);
				Schema schema = db.Schemata.Find(schemaID);
				Table table = db.Tables.Find(tableID);
				Client client = db.Clients.Find(clientID);


				if (server == null || !(server.ID > 0))
				{
					Message("No server is selected or the selected server has an invalid ID. Unable to import file.", "Please select a server", true);
					return;
				}

				if (database == null || !(database.ID > 0))
				{
					Message("No database is selected or the selected database has an invalid ID. Unable to import file.", "Please select a database", true);
					return;
				}

				if (schema == null || !(schema.ID > 0))
				{
					Message("No schema is selected or the selected table has an invalid ID. Unable to import file.", "Please select a schema", true);
					return;
				}

				if (table == null || !(table.ID > 0))
				{
					Message("No table is selected or the selected table has an invalid ID. Unable to import file.", "Please select a table", true);
					return;
				}

				if (client == null || !(client.ID > 0))
				{
					Message("No client is selected or the selected client has an invalid ID. Unable to import file.", "Please select a client", true);
					return;
				}

				Import import = new Import
				{
					DateCreated = DateTime.UtcNow,
					FilePath = fileInfo.FullName
				};

				db.AddRecords(new[] { import }, true);

				Dictionary<string, ColumnMap> columns = GetColumnMappings(db, fileInfo);
				DataTable importResults = PopulateDataTable(columns, fileInfo, ckb_HasHeader.Checked, null, import);

				string connectionString = SQLHelper.GetConnectionString(server.HostName, database.Name);
				string tableName = $"[{table.Schema.Name}].[{table.Name}]";

				using (SqlBulkCopy sbc = new SqlBulkCopy(connectionString))
				{
					foreach (DataColumn column in importResults.Columns)
					{
						sbc.ColumnMappings.Add(column.ColumnName, column.ColumnName);
					}

					sbc.DestinationTableName = tableName;
					sbc.WriteToServer(importResults);
				}
			}

			Message($"Import has completed successfully!\r\n{tssl_Status.Text}", "IMPORT COMPLETE", true);
		}

		private void btn_AddColumnMap_Click(object sender, EventArgs e)
		{
			if (!ClientEnabled)
			{
				MessageBox.Show("Select a client before trying to add a column map.");
				return;
			}

			if (!MapColumnEnabled)
			{
				MessageBox.Show("No column was selected for mapping. Select a column to be mapped to the identifier.");
				return;
			}

			if (tb_AddColumnMapIdentifier.Text.IsNullOrWhiteSpace())
			{
				MessageBox.Show("An identifier is required for new column mappings. Input an identifier.");
				return;
			}

			using (SpecEditorContext db = new SpecEditorContext())
			{
				ColumnMap map = new ColumnMap
				{
					ClientID = (int)ddl_Client.SelectedValue,
					ColumnID = (int)ddl_AddColumnMapColumn.SelectedValue,
					Identifier = tb_AddColumnMapIdentifier.Text
				};

				db.AddRecords(new[] { map }, true);

				if (map.ID > 0)
					PopulateColumnMapGrid(db, (int?)ddl_Table.SelectedValue, (int?)ddl_Client.SelectedValue);
			}

			ddl_AddColumnMapColumn.SelectedIndex = -1;
			tb_AddColumnMapIdentifier.Text = null;
		}

		private void btn_ColumnMapMapClear_Click(object sender, EventArgs e)
		{
			ddl_AddColumnMapColumn.SelectedIndex = -1;
			tb_AddColumnMapIdentifier.Text = null;
		}

		#endregion Control Events

		#region Methods

		private void Initialize(SpecEditorContext db)
		{
			PopulateClientControls(db);
			PopulateServerDropdown(db);
		}

		private bool Message(string message, string caption, bool showDialog = false, MessageBoxButtons buttons = MessageBoxButtons.OK,
			MessageBoxIcon icon = MessageBoxIcon.Exclamation)
		{
			tssl_Status.Text = $"{(caption.IsNullOrWhiteSpace() ? "" : $"{caption.Trim().Trim(':', '.')}: ")}{message}";
			return !showDialog || ValidResults.Contains(MessageBox.Show(message, caption, buttons, icon));
		}

		//private void ToggleVisibility()
		//{
		//	gb_DatabaseSelection.Visible = DatabaseEnabled;
		//	gb_SchemaSelection.Visible = SchemaEnabled;
		//	gb_TableSelection.Visible = TableEnabled;
		//	tp_SchemaAdmin.Visible = ColumnEnabled;
		//	gb_FileSelection.Visible = tp_Mapping.Visible = ColumnEnabled && ClientEnabled;
		//	tp_Import.Visible = ColumnEnabled && ClientEnabled && FileEnabled;
		//	gb_EditClient.Visible = ClientEditEnabled;

		//}

		private bool HandleSQLHelperMessages(bool showDialog = false)
		{
			if (!SQLHelper.Messages.Any())
			{
				tssl_Status.Text = null;
				return true;
			}

			IReadOnlyCollection<string> messages = SQLHelper.Messages.Distinct().ToArray();

			SQLHelper.Messages.Clear();

			string message = messages.Aggregate((current, segment) => current + " | " + segment);
			Message(message, "The following messages were received:", showDialog);

			return false;
		}

		private void PopulateClientDropdown(SpecEditorContext db)
		{
			ddl_Client.DataSource = db.Clients.OrderBy(o => o.Name).Select(s => new { s.ID, s.Name }).ToList();
			ddl_Client.Refresh();

			if (!ddl_Client.Items.Cast<object>().Any())
				tc_Main.SelectedTab = tc_Main.TabPages["tp_Administration"];
		}

		private void PopulateClientGrid(SpecEditorContext db)
		{
			db.Clients.Load();
			dgv_Client.DataSource = db.Clients.OrderBy(o => o.Name).Select(s => new { s.ID, s.Name, MapCount = s.ColumnMaps.Count, s.Description }).ToList();
			dgv_Client.Refresh();
		}

		private void PopulateClientControls(SpecEditorContext db)
		{
			PopulateClientDropdown(db);
			PopulateClientGrid(db);
		}

		private void PopulateServerDropdown(SpecEditorContext db)
		{
			dgv_MappedColumns.ClearSelection();
			dgv_UnmappedColumns.ClearSelection();
			dgv_ColumnMap.ClearSelection();
			dgv_Columns.ClearSelection();
			ddl_AddColumnMapColumn.SelectedIndex = -1;
			ddl_EditColumnMapColumn.SelectedIndex = -1;
			ddl_Table.SelectedIndex = -1;
			ddl_Schema.SelectedIndex = -1;
			ddl_Database.SelectedIndex = -1;
			ddl_Server.SelectedIndex = -1;

			dgv_ColumnMap.DataSource = null;
			dgv_Columns.DataSource = null;
			dgv_MappedColumns.DataSource = null;
			dgv_UnmappedColumns.DataSource = null;
			ddl_AddColumnMapColumn.DataSource = null;
			ddl_EditColumnMapColumn.DataSource = null;
			ddl_Table.DataSource = null;
			ddl_Schema.DataSource = null;
			ddl_Database.DataSource = null;

			//SQLHelper.AddServers(db);

			HandleSQLHelperMessages();

			ddl_Server.DataSource = db.Servers.ToArray().OrderBy(o => o.DisplayName).ToList();
			ddl_Server.ValueMember = "ID";
			ddl_Server.DisplayMember = "DisplayName";
			ddl_Server.Refresh();
		}

		private void PopulateDatabaseDropdown(SpecEditorContext db, int serverID)
		{
			dgv_MappedColumns.ClearSelection();
			dgv_UnmappedColumns.ClearSelection();
			dgv_ColumnMap.ClearSelection();
			dgv_Columns.ClearSelection();
			ddl_AddColumnMapColumn.SelectedIndex = -1;
			ddl_EditColumnMapColumn.SelectedIndex = -1;
			ddl_Table.SelectedIndex = -1;
			ddl_Schema.SelectedIndex = -1;
			ddl_Database.SelectedIndex = -1;

			dgv_MappedColumns.DataSource = null;
			dgv_UnmappedColumns.DataSource = null;
			dgv_ColumnMap.DataSource = null;
			dgv_Columns.DataSource = null;
			ddl_AddColumnMapColumn.DataSource = null;
			ddl_EditColumnMapColumn.DataSource = null;
			ddl_Table.DataSource = null;
			ddl_Schema.DataSource = null;

			SQLHelper.AddDatabases(db, serverID);

			HandleSQLHelperMessages();

			ddl_Database.DataSource = db.Databases.Where(w => w.ServerID == serverID).OrderBy(o => o.Name).ToList();
			ddl_Database.ValueMember = "ID";
			ddl_Database.DisplayMember = "Name";
			ddl_Database.Refresh();
		}

		private void PopulateSchemaDropdown(SpecEditorContext db, int databaseID)
		{
			dgv_MappedColumns.ClearSelection();
			dgv_UnmappedColumns.ClearSelection();
			dgv_ColumnMap.ClearSelection();
			dgv_Columns.ClearSelection();
			ddl_AddColumnMapColumn.SelectedIndex = -1;
			ddl_EditColumnMapColumn.SelectedIndex = -1;
			ddl_Table.SelectedIndex = -1;
			ddl_Schema.SelectedIndex = -1;

			dgv_MappedColumns.DataSource = null;
			dgv_UnmappedColumns.DataSource = null;
			dgv_ColumnMap.DataSource = null;
			dgv_Columns.DataSource = null;
			ddl_AddColumnMapColumn.DataSource = null;
			ddl_EditColumnMapColumn.DataSource = null;
			ddl_Table.DataSource = null;

			SQLHelper.AddSchemata(db, databaseID);

			HandleSQLHelperMessages();

			ddl_Schema.DataSource = db.Schemata.Where(w => w.DatabaseID == databaseID).OrderBy(o => o.Name).ToList();
			ddl_Schema.ValueMember = "ID";
			ddl_Schema.DisplayMember = "Name";
			ddl_Schema.Refresh();
		}

		private void PopulateTableDropdown(SpecEditorContext db, int schemaID)
		{
			dgv_MappedColumns.ClearSelection();
			dgv_UnmappedColumns.ClearSelection();
			dgv_ColumnMap.ClearSelection();
			dgv_Columns.ClearSelection();
			ddl_AddColumnMapColumn.SelectedIndex = -1;
			ddl_EditColumnMapColumn.SelectedIndex = -1;
			ddl_Table.SelectedIndex = -1;

			dgv_MappedColumns.DataSource = null;
			dgv_UnmappedColumns.DataSource = null;
			dgv_ColumnMap.DataSource = null;
			dgv_Columns.DataSource = null;

			SQLHelper.AddTables(db, schemaID);

			HandleSQLHelperMessages();

			ddl_Table.DataSource = db.Tables.Where(w => w.SchemaID == schemaID).OrderBy(o => o.Name).ToList();
			ddl_Table.ValueMember = "ID";
			ddl_Table.DisplayMember = "Name";
			ddl_Table.Refresh();
		}

		private void PopulateColumnGrid(SpecEditorContext db, int tableID)
		{
			dgv_ColumnMap.ClearSelection();
			dgv_Columns.ClearSelection();
			ddl_AddColumnMapColumn.SelectedIndex = -1;
			ddl_EditColumnMapColumn.SelectedIndex = -1;

			SQLHelper.AddColumns(db, tableID);

			HandleSQLHelperMessages();

			IQueryable<Column> columns = db.Columns.Where(w => w.TableID == tableID);
			columns.Load();
			var dataSource = columns.Select(s => new
			{
				s.ID,
				Locked = s.IsLocked ? "True" : "False",
				s.Index,
				s.Name,
				SQLDataType = s.ColumnCast.SQLTypeName,
				s.MaxLength,
				s.Precision,
				s.Scale,
				MapCount = s.ColumnMaps.Count,
				s.FirstSeen,
				s.LastSeen
			})
									.OrderBy(o => o.Index)
									.ToList();

			dgv_Columns.DataSource = dataSource;
			dgv_Columns.Refresh();
		}

		private void PopulateColumnMapGrid(SpecEditorContext db, int? tableID = null, int? clientID = null)
		{
			dgv_ColumnMap.ClearSelection();

			IQueryable<ColumnMap> columnMaps = db.ColumnMaps;

			if (tableID != null && tableID.Value > 0)
				columnMaps = columnMaps.Where(w => w.Column.TableID == tableID);

			if (clientID != null && clientID.Value > 0)
				columnMaps = columnMaps.Where(w => w.ClientID == clientID);

			columnMaps.Load();

			if (tableID == null && clientID == null)
				dgv_ColumnMap.DataSource = columnMaps.Select(s => new
				{
					s.ID,
					s.ClientID,
					ClientName = s.Client.Name,
					s.Column.TableID,
					TableName = s.Column.Table.Name,
					ColumnName = s.Column.Name,
					s.Identifier
				}).ToList();
			else if (tableID == null)
				dgv_ColumnMap.DataSource = columnMaps.Select(s => new
				{
					s.ID,
					s.Column.TableID,
					TableName = s.Column.Table.Name,
					s.ColumnID,
					ColumnName = s.Column.Name,
					s.Identifier
				}).ToList();
			else if (clientID == null)
				dgv_ColumnMap.DataSource = columnMaps.Select(s => new
				{
					s.ID,
					s.ClientID,
					ClientName = s.Client.Name,
					s.ColumnID,
					ColumnName = s.Column.Name,
					s.Identifier
				}).ToList();
			else
				dgv_ColumnMap.DataSource = columnMaps.Select(s => new
				{
					s.ID,
					s.ColumnID,
					ColumnName = s.Column.Name,
					s.Identifier
				}).ToList();

			dgv_ColumnMap.Refresh();
		}

		private void PopulateMapColumnDropdown(SpecEditorContext db, int tableID)
		{
			var dataSource = db.Columns.Where(w => w.TableID == tableID).Select(s => new { s.ID, s.Name }).ToList();

			ddl_AddColumnMapColumn.DataSource = ddl_EditColumnMapColumn.DataSource = dataSource;

			ddl_AddColumnMapColumn.ValueMember = ddl_EditColumnMapColumn.ValueMember = "ID";
			ddl_AddColumnMapColumn.DisplayMember = ddl_EditColumnMapColumn.DisplayMember = "Name";

			ddl_AddColumnMapColumn.Refresh();
			ddl_EditColumnMapColumn.Refresh();
		}

		private void SelectFile()
		{
			ofd_ImportFile.DefaultExt = ".csv";
			ofd_ImportFile.AutoUpgradeEnabled = true;
			ofd_ImportFile.CheckPathExists = true;
			ofd_ImportFile.CheckFileExists = true;
			ofd_ImportFile.RestoreDirectory = true;
			ofd_ImportFile.Multiselect = false;
			ofd_ImportFile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);

			if (ValidResults.Contains(ofd_ImportFile.ShowDialog(this)))
				LoadSelectedFile(ofd_ImportFile.FileName);
			else
				MessageBox.Show("Unable to load import file. No file was selected and/or the action was cancelled by the user.", "NO FILE SELECTED");
		}

		private void LoadSelectedFile(string fileName)
		{
			if (fileName.IsNullOrWhiteSpace())
			{
				tb_SelectedFile.Text = "NO FILE SELECTED";
				MessageBox.Show("No file path was specified.", "Unable to Load File", MessageBoxButtons.OK, MessageBoxIcon.Error);
				//throw new ArgumentNullException(nameof(fileName), "Unable to load import file. No file path was specified.");
				return;
			}

			if (!File.Exists(fileName))
			{
				tb_SelectedFile.Text = "NO FILE SELECTED";
				MessageBox.Show("The file path specified was invalid. The file does not exist.", "Unable to Load File", MessageBoxButtons.OK, MessageBoxIcon.Error);
				//throw new ArgumentNullException(nameof(fileName), "Unable to load import file. The selected file does not exist.");
				return;
			}

			FileInfo selectedFile = new FileInfo(fileName);

			if (!(selectedFile.Length > 0))
			{
				tb_SelectedFile.Text = "EMPTY FILE SELECTED";
				MessageBox.Show("The file path specified was invalid. The file is empty.", "Unable to Load File", MessageBoxButtons.OK, MessageBoxIcon.Error);
				//throw new ArgumentNullException(nameof(fileName), "Unable to load import file. The selected file does not have any content.");
				return;
			}

			tb_SelectedFile.Text = fileName;

			using (SpecEditorContext db = new SpecEditorContext())
			{
				PopulateFileInformationGrid(db, selectedFile);
			}
		}

		private Dictionary<string, ColumnMap> GetColumnMappings(SpecEditorContext db, FileInfo fileInfo)
		{
			int? tableID = (int?)ddl_Table.SelectedValue;
			int? clientID = (int?)ddl_Client.SelectedValue;

			if (tableID == null || !(tableID > 0))
			{
				Message("No table is selected or the selected table has an invalid ID. Unable to process file.", "Please select a table", true);
				return null;
			}

			if (clientID == null || !(clientID > 0))
			{
				Message("No client is selected or the selected client has an invalid ID. Unable to process file.", "Please select a client", true);
				return null;
			}

			if (fileInfo == null || !fileInfo.Exists)
			{
				Message("No file was specified or the file does not exist.", "Please select a file", true);
				return null;
			}

			Table table = db.Tables.Find(tableID);

			if (table == null)
			{
				Message("Unable to retrieve stored table information.", "Unable to process file", true);
				return null;
			}

			db.Columns.Load();
			db.ColumnMaps.Load();

			IQueryable<Column> tableColumns = db.Columns.Where(f => f.TableID == tableID);
			IQueryable<ColumnMap> tableColumnMaps = db.ColumnMaps.Where(w => w.Column.TableID == tableID && w.ClientID == clientID);

			if (!tableColumns.Any())
			{
				Message($"No columns exist in the '{table.Name}' table.", "Unable to process file", true);
				return null;
			}

			string header;

			try
			{
				using (StreamReader sr = new StreamReader(fileInfo.FullName))
				{
					header = sr.ReadLine()?.Trim();
					sr.Close();
				}
			}
			catch (Exception e)
			{
				MessageBox.Show(e.Message, "UNABLE TO RETRIEVE HEADER", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return null;
			}

			if (header.IsNullOrWhiteSpace())
			{
				Message("No header was detected in the selected file.", "Unable to proccess file. (Is the file empty?)", true);
				return null;
			}

			IReadOnlyCollection<string> allHeaders = header.SplitCSV(",").ToArray();

			if (allHeaders.Any(a => a.IsNullOrWhiteSpace()))
			{
				tssl_Status.Text =
					"One or more columns have a null or empty column name. All columns require a name to be defined in the header row. Unable to process file.";
				return null;
			}

			IReadOnlyCollection<string> distinctHeaders = allHeaders.Distinct().ToArray();

			if (allHeaders.Count > distinctHeaders.Count)
			{
				IReadOnlyCollection<string> duplicateHeaders = allHeaders.Where(w => !distinctHeaders.Contains(w)).ToArray();
				Message($"Import file has {duplicateHeaders} duplicate column{(duplicateHeaders.Count == 1 ? "" : "s")} defined in the header:\r\n({duplicateHeaders.Select(s => $"\"{s}\"").Aggregate((c, n) => c + " | " + n)}", "Unable to process file", true);
				return null;
			}

			Dictionary<string, ColumnMap> columns = distinctHeaders.ToDictionary(k => k, v => (ColumnMap)null);

			int newMapCounter = 0;

			IReadOnlyCollection<string> columnNames = columns.Keys.ToArray();

			foreach (string columnName in columnNames)
			{
				ColumnMap columnMap = tableColumnMaps.FirstOrDefault(f => f.Identifier == columnName);

				if (columnMap != null && columnMap.ID > 0)
				{
					// Map already exists... Use it
					columns[columnName] = columnMap;
					continue;
				}

				// Map doesn't exist... See if it matches a column directly
				Column column = tableColumns.FirstOrDefault(f => f.Name.ToLower() == columnName.ToLower());

				if (column == null)
					// Column name from header of CSV file doesnt match any identifier or column name... Leave it null as we'll check for that later
					continue;

				// Name has matched with a recorded column record, but doesn't have a map. Create one and use it
				ColumnMap newColumnMap = new ColumnMap
				{
					ClientID = clientID.Value,
					ColumnID = column.ID,
					Identifier = columnName
				};

				db.AddRecords(new[] { newColumnMap }, true);

				newMapCounter++;

				columns[columnName] = newColumnMap;
			}

			if (newMapCounter > 0)
			{
				PopulateColumnMapGrid(db, tableID, clientID);
				PopulateColumnGrid(db, tableID.Value);
				PopulateClientGrid(db);
			}

			int columnCount = columns.Count;
			int mappedColumnCount = columns.Count(c => c.Value != null);

			tssl_Status.Text = $"{columnCount} columns detected. Column mapping information has been detected for {mappedColumnCount} columns and {newMapCounter} new column mappings were added automatically.";

			if (mappedColumnCount != columnCount)
			{
				MessageBox.Show(
					"Not all columns were automatically mapped. You must manually map the remaining columns before the file can be imported.",
					"MANUAL COLUMN MAPPING REQUIRED", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}

			return columns;
		}

		private void PopulateFileInformationGrid(SpecEditorContext db, FileInfo fileInfo)
		{
			dgv_UnmappedColumns.DataSource = null;
			dgv_MappedColumns.DataSource = null;

			int? tableID = (int?)ddl_Table.SelectedValue;

			if (tableID == null || !(tableID > 0))
			{
				Message("No table is selected or the selected table has an invalid ID. Unable to populate the Column Mapping grids.", "Please select a table", true);
				return;
			}

			if (fileInfo == null || !fileInfo.Exists)
			{
				Message("No file is selected or the file does not exist. Unable to process file.", "Please select a file.", true);
				return;
			}

			Dictionary<string, ColumnMap> columns = GetColumnMappings(db, fileInfo);

			if (columns == null || !columns.Any())
			{
				tssl_Status.Text =
					"No columns were returned from the mapping process. Unable to process file without column information.";
				return;
			}

			Dictionary<string, ColumnMap> mappedColumns = columns.Where(w => w.Value != null).ToDictionary(a => a.Key, a => a.Value);
			IReadOnlyCollection<string> unmappedColumns = columns.Where(w => w.Value == null).Select(s => s.Key).ToArray();

			if (mappedColumns.Any())
			{
				var mappedDataSource =
					mappedColumns.Select(s => new { s.Value.ColumnID, ColumnName = s.Value.Column.Name, Identifier = s.Key }).ToList();
				dgv_MappedColumns.DataSource = mappedDataSource;
				dgv_MappedColumns.Refresh();
			}

			if (unmappedColumns.Any())
			{
				dgv_UnmappedColumns.DataSource = null;
				dgv_UnmappedColumns.Rows.Clear();
				dgv_UnmappedColumns.Columns.Clear();

				IList<Column> columnsDataSource = db.Columns.Where(w => w.TableID == tableID).ToList();

				DataGridViewTextBoxColumn identifierColumn = new DataGridViewTextBoxColumn
				{
					Name = "Identifier",
					ValueType = typeof(string),
					DataPropertyName = "Identifier",
					HeaderText = "Import File Column"
				};

				DataGridViewComboBoxColumn columnColumn = new DataGridViewComboBoxColumn
				{
					Name = "ColumnID",
					ValueType = typeof(int?),
					DataPropertyName = "ColumnID",
					HeaderText = "Import File Column",
					DataSource = columnsDataSource,
					ValueMember = "ID",
					DisplayMember = "Name"
				};

				dgv_UnmappedColumns.Columns.AddRange(identifierColumn, columnColumn);

				foreach (string unmappedColumn in unmappedColumns)
				{
					DataGridViewRow row = new DataGridViewRow();
					row.CreateCells(dgv_UnmappedColumns);
					row.SetValues(unmappedColumn, null);
					dgv_UnmappedColumns.Rows.Add(row);
				}

				dgv_UnmappedColumns.Refresh();
			}

			if (columns.All(a => a.Value != null))
				PopulateTestDataGrid(columns, fileInfo);
		}

		private void PopulateTestDataGrid(Dictionary<string, ColumnMap> columns, FileSystemInfo fileInfo, bool hasHeader = true, int? recordLimit = 20)
		{
			if (columns.Any(a => a.Value == null))
			{
				tssl_Status.Text =
					"Not all columns have been mapped properly. Unable to populate test data grid. Please map all columps properly.";
				return;
			}

			DataTable results = PopulateDataTable(columns, fileInfo, hasHeader, recordLimit);
			dgv_TestData.DataSource = results;
			dgv_TestData.Refresh();
		}

		private DataTable PopulateDataTable(Dictionary<string, ColumnMap> columns,
			FileSystemInfo fileInfo, bool hasHeader = true, int? recordLimit = null, Import import = null)
		{
			//try
			//{
			DataTable results = SqlHelper.BuildDataTable(columns, import);

			using (StreamReader sr = new StreamReader(new FileStream(fileInfo.FullName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)))
			{
				if (hasHeader)
					sr.ReadLine(); // Column information is passed. We don't need to process the header again

				int recordCount = 0;
				while (sr.Peek() > -1)
				{
					if (recordLimit != null && recordLimit.Value > 0 && recordCount > recordLimit)
						break;

					string recordString = sr.ReadLine();

					if (recordString.IsNullOrWhiteSpace())
						continue; // Ignore blank/empty lines

					// Increment the record count after the empty string check. Don't want empty strings adding to our record count
					recordCount++;

					IReadOnlyCollection<string> recordValues = recordString.SplitCSV(",").ToArray();

					if (recordValues.Count != columns.Count)
					{
						int difference = columns.Count - recordValues.Count;
						string differenceString = difference > 0 ? "is missing" : "has an extra";
						string message = $"Record number {recordCount} {differenceString} {difference} columns. Unable to parse record.\r\nWould you like to continue parsing the file?";

						if (!Message(message, "INVALID COLUMN COUNT DETECTED", true, MessageBoxButtons.YesNo, MessageBoxIcon.Error))
						{
							sr.Close();
							return results;
						}

						continue;
					}

					List<object> valueObjects = new List<object>();

					if (import != null && import.ID > 0)
						valueObjects.Add(import.ID);

					foreach (var column in columns.Select((s, i) => new { Index = i, Value = s }))
					{
						int index = column.Index;
						ColumnMap columnMap = column.Value.Value;
						Column columnMapColumn = columnMap.Column;
						ColumnCast columnCast = columnMapColumn.ColumnCast;
						string typeString = columnCast.DotNetTypeName;
						Type type = Type.GetType(typeString);
						string valueString = recordValues.Skip(index).FirstOrDefault();
						
						object safeValue = null;

						if (type == null)
						{
							string message = $"Unable to retrieve datatype of Column {index} in record number {recordCount}.\r\nThe type of '{typeString}' returned nothing from Type.GetType().\r\nUnable to parse record.\r\nWould you like to continue parsing the file?";

							if (!Message(message, "INVALID COLUMN DATATYPE DETECTED", true, MessageBoxButtons.YesNo, MessageBoxIcon.Error))
							{
								sr.Close();
								return results;
							}

							continue;
						}

						if (!string.IsNullOrWhiteSpace(valueString))
						{
							Type underlyingType = Nullable.GetUnderlyingType(type) ?? type;

							// Data has 0 and 1 for false and true values
							// Normally not needed but is in this circumstance
							if (underlyingType == typeof(bool))
								valueString = (valueString != "0" && valueString.ToLower() != "false").ToString();

							// Data may include scientific notation in decimals.
							// We need to make sure all decimals are clean before parsing
							if (underlyingType == typeof(decimal))
								valueString = decimal.Parse(valueString, NumberStyles.Any).ToString(CultureInfo.InvariantCulture);

							safeValue = Convert.ChangeType(valueString, underlyingType, CultureInfo.InvariantCulture);
						}

						valueObjects.Add(safeValue);
					}

					results.Rows.Add(valueObjects.ToArray());
				}

				tssl_Status.Text = $"{recordCount} records were retrieved from {fileInfo.FullName}";

				sr.Close();
			}

			return results;
			//}
			//catch (Exception e)
			//{
			//	MessageBox.Show(e.Message, "UNABLE TO POPULATE TEST DATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
			//	return;
			//}
		}

		#endregion Methods
	}
}
