namespace SpecEditor
{
    partial class frm_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
			this.tc_Main = new System.Windows.Forms.TabControl();
			this.tp_ClientAdministration = new System.Windows.Forms.TabPage();
			this.gb_ClientAdministration = new System.Windows.Forms.GroupBox();
			this.sc_ClientAdministration = new System.Windows.Forms.SplitContainer();
			this.gb_ClientList = new System.Windows.Forms.GroupBox();
			this.dgv_Client = new System.Windows.Forms.DataGridView();
			this.sc_ClientModification = new System.Windows.Forms.SplitContainer();
			this.gb_AddClient = new System.Windows.Forms.GroupBox();
			this.tb_AddClientName = new System.Windows.Forms.TextBox();
			this.btn_AddClient = new System.Windows.Forms.Button();
			this.lbl_AddClientName = new System.Windows.Forms.Label();
			this.btn_AddClientClear = new System.Windows.Forms.Button();
			this.lbl_AddClientDescription = new System.Windows.Forms.Label();
			this.tb_AddClientDescription = new System.Windows.Forms.TextBox();
			this.gb_EditClient = new System.Windows.Forms.GroupBox();
			this.tb_EditClientName = new System.Windows.Forms.TextBox();
			this.btn_EditClient = new System.Windows.Forms.Button();
			this.lbl_EditClientName = new System.Windows.Forms.Label();
			this.btn_EditClientReset = new System.Windows.Forms.Button();
			this.lbl_EditClientDescription = new System.Windows.Forms.Label();
			this.tb_EditClientDescription = new System.Windows.Forms.TextBox();
			this.tp_ImportConfiguration = new System.Windows.Forms.TabPage();
			this.gb_SQLCredentialsClientSelection = new System.Windows.Forms.GroupBox();
			this.sc_SQLCredentialsClientSelection = new System.Windows.Forms.SplitContainer();
			this.gb_UserConfiguration = new System.Windows.Forms.GroupBox();
			this.lbl_Password = new System.Windows.Forms.Label();
			this.btn_RefreshSqlObjects = new System.Windows.Forms.Button();
			this.tb_Password = new System.Windows.Forms.TextBox();
			this.tb_Username = new System.Windows.Forms.TextBox();
			this.lbl_Username = new System.Windows.Forms.Label();
			this.gb_ClientSelect = new System.Windows.Forms.GroupBox();
			this.ddl_Client = new System.Windows.Forms.ComboBox();
			this.gb_FileSelection = new System.Windows.Forms.GroupBox();
			this.ckb_HasHeader = new System.Windows.Forms.CheckBox();
			this.tb_SelectedFile = new System.Windows.Forms.TextBox();
			this.btn_SelectFile = new System.Windows.Forms.Button();
			this.gb_SQLObjectSelection = new System.Windows.Forms.GroupBox();
			this.sc_DestinationSelection = new System.Windows.Forms.SplitContainer();
			this.sc_ServerDatabaseSelection = new System.Windows.Forms.SplitContainer();
			this.gb_ServerSelection = new System.Windows.Forms.GroupBox();
			this.ddl_Server = new System.Windows.Forms.ComboBox();
			this.gb_DatabaseSelection = new System.Windows.Forms.GroupBox();
			this.ddl_Database = new System.Windows.Forms.ComboBox();
			this.sc_SchemaTableSelection = new System.Windows.Forms.SplitContainer();
			this.gb_SchemaSelection = new System.Windows.Forms.GroupBox();
			this.ddl_Schema = new System.Windows.Forms.ComboBox();
			this.gb_TableSelection = new System.Windows.Forms.GroupBox();
			this.ddl_Table = new System.Windows.Forms.ComboBox();
			this.tp_SchemaAdmin = new System.Windows.Forms.TabPage();
			this.gb_Column = new System.Windows.Forms.GroupBox();
			this.dgv_Columns = new System.Windows.Forms.DataGridView();
			this.tp_ColumnMapping = new System.Windows.Forms.TabPage();
			this.gb_ColumnImportMapping = new System.Windows.Forms.GroupBox();
			this.sc_ColumnImports = new System.Windows.Forms.SplitContainer();
			this.gb_ColumnMapList = new System.Windows.Forms.GroupBox();
			this.dgv_ColumnMap = new System.Windows.Forms.DataGridView();
			this.sc_ColumnMappingInformation = new System.Windows.Forms.SplitContainer();
			this.gb_AddColumnMap = new System.Windows.Forms.GroupBox();
			this.sc_AddColumnMapping = new System.Windows.Forms.SplitContainer();
			this.sc_AddColumnMappingInformation = new System.Windows.Forms.SplitContainer();
			this.gb_AddColumnMapSelection = new System.Windows.Forms.GroupBox();
			this.ddl_AddColumnMapColumn = new System.Windows.Forms.ComboBox();
			this.gb_MapNewIdentifier = new System.Windows.Forms.GroupBox();
			this.tb_AddColumnMapIdentifier = new System.Windows.Forms.TextBox();
			this.btn_AddColumnMapClear = new System.Windows.Forms.Button();
			this.btn_AddColumnMap = new System.Windows.Forms.Button();
			this.gb_EditColumnMap = new System.Windows.Forms.GroupBox();
			this.sc_EditColumnMapping = new System.Windows.Forms.SplitContainer();
			this.sc_EditColumnMappingInformation = new System.Windows.Forms.SplitContainer();
			this.gb_EditColumnMapColumn = new System.Windows.Forms.GroupBox();
			this.ddl_EditColumnMapColumn = new System.Windows.Forms.ComboBox();
			this.gb_EditColumnMapIdentifier = new System.Windows.Forms.GroupBox();
			this.tb_EditColumnMapIdentifier = new System.Windows.Forms.TextBox();
			this.btn_EditColumnMapClear = new System.Windows.Forms.Button();
			this.btn_EditColumnMap = new System.Windows.Forms.Button();
			this.tp_Import = new System.Windows.Forms.TabPage();
			this.gb_TestData = new System.Windows.Forms.GroupBox();
			this.dgv_TestData = new System.Windows.Forms.DataGridView();
			this.gb_ImportColumns = new System.Windows.Forms.GroupBox();
			this.btn_SaveImportTemplate = new System.Windows.Forms.Button();
			this.sc_ImportColumnMapping = new System.Windows.Forms.SplitContainer();
			this.gb_UnmappedColumns = new System.Windows.Forms.GroupBox();
			this.dgv_UnmappedColumns = new System.Windows.Forms.DataGridView();
			this.gb_MappedColumns = new System.Windows.Forms.GroupBox();
			this.dgv_MappedColumns = new System.Windows.Forms.DataGridView();
			this.btn_FileRescan = new System.Windows.Forms.Button();
			this.btn_ImportFile = new System.Windows.Forms.Button();
			this.btn_SaveColumnMapUpdates = new System.Windows.Forms.Button();
			this.ms_Main = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.refreshServerListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.stsr_Main = new System.Windows.Forms.StatusStrip();
			this.tsp_Progress = new System.Windows.Forms.ToolStripProgressBar();
			this.tssl_Status = new System.Windows.Forms.ToolStripStatusLabel();
			this.ofd_ImportFile = new System.Windows.Forms.OpenFileDialog();
			this.gb_ImportTemplateSelection = new System.Windows.Forms.GroupBox();
			this.lbl_SelectImportTemplate = new System.Windows.Forms.Label();
			this.ddl_ImportTemplate = new System.Windows.Forms.ComboBox();
			this.tc_Main.SuspendLayout();
			this.tp_ClientAdministration.SuspendLayout();
			this.gb_ClientAdministration.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.sc_ClientAdministration)).BeginInit();
			this.sc_ClientAdministration.Panel1.SuspendLayout();
			this.sc_ClientAdministration.Panel2.SuspendLayout();
			this.sc_ClientAdministration.SuspendLayout();
			this.gb_ClientList.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_Client)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sc_ClientModification)).BeginInit();
			this.sc_ClientModification.Panel1.SuspendLayout();
			this.sc_ClientModification.Panel2.SuspendLayout();
			this.sc_ClientModification.SuspendLayout();
			this.gb_AddClient.SuspendLayout();
			this.gb_EditClient.SuspendLayout();
			this.tp_ImportConfiguration.SuspendLayout();
			this.gb_SQLCredentialsClientSelection.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.sc_SQLCredentialsClientSelection)).BeginInit();
			this.sc_SQLCredentialsClientSelection.Panel1.SuspendLayout();
			this.sc_SQLCredentialsClientSelection.Panel2.SuspendLayout();
			this.sc_SQLCredentialsClientSelection.SuspendLayout();
			this.gb_UserConfiguration.SuspendLayout();
			this.gb_ClientSelect.SuspendLayout();
			this.gb_FileSelection.SuspendLayout();
			this.gb_SQLObjectSelection.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.sc_DestinationSelection)).BeginInit();
			this.sc_DestinationSelection.Panel1.SuspendLayout();
			this.sc_DestinationSelection.Panel2.SuspendLayout();
			this.sc_DestinationSelection.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.sc_ServerDatabaseSelection)).BeginInit();
			this.sc_ServerDatabaseSelection.Panel1.SuspendLayout();
			this.sc_ServerDatabaseSelection.Panel2.SuspendLayout();
			this.sc_ServerDatabaseSelection.SuspendLayout();
			this.gb_ServerSelection.SuspendLayout();
			this.gb_DatabaseSelection.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.sc_SchemaTableSelection)).BeginInit();
			this.sc_SchemaTableSelection.Panel1.SuspendLayout();
			this.sc_SchemaTableSelection.Panel2.SuspendLayout();
			this.sc_SchemaTableSelection.SuspendLayout();
			this.gb_SchemaSelection.SuspendLayout();
			this.gb_TableSelection.SuspendLayout();
			this.tp_SchemaAdmin.SuspendLayout();
			this.gb_Column.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_Columns)).BeginInit();
			this.tp_ColumnMapping.SuspendLayout();
			this.gb_ColumnImportMapping.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.sc_ColumnImports)).BeginInit();
			this.sc_ColumnImports.Panel1.SuspendLayout();
			this.sc_ColumnImports.Panel2.SuspendLayout();
			this.sc_ColumnImports.SuspendLayout();
			this.gb_ColumnMapList.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_ColumnMap)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sc_ColumnMappingInformation)).BeginInit();
			this.sc_ColumnMappingInformation.Panel1.SuspendLayout();
			this.sc_ColumnMappingInformation.Panel2.SuspendLayout();
			this.sc_ColumnMappingInformation.SuspendLayout();
			this.gb_AddColumnMap.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.sc_AddColumnMapping)).BeginInit();
			this.sc_AddColumnMapping.Panel1.SuspendLayout();
			this.sc_AddColumnMapping.Panel2.SuspendLayout();
			this.sc_AddColumnMapping.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.sc_AddColumnMappingInformation)).BeginInit();
			this.sc_AddColumnMappingInformation.Panel1.SuspendLayout();
			this.sc_AddColumnMappingInformation.Panel2.SuspendLayout();
			this.sc_AddColumnMappingInformation.SuspendLayout();
			this.gb_AddColumnMapSelection.SuspendLayout();
			this.gb_MapNewIdentifier.SuspendLayout();
			this.gb_EditColumnMap.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.sc_EditColumnMapping)).BeginInit();
			this.sc_EditColumnMapping.Panel1.SuspendLayout();
			this.sc_EditColumnMapping.Panel2.SuspendLayout();
			this.sc_EditColumnMapping.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.sc_EditColumnMappingInformation)).BeginInit();
			this.sc_EditColumnMappingInformation.Panel1.SuspendLayout();
			this.sc_EditColumnMappingInformation.Panel2.SuspendLayout();
			this.sc_EditColumnMappingInformation.SuspendLayout();
			this.gb_EditColumnMapColumn.SuspendLayout();
			this.gb_EditColumnMapIdentifier.SuspendLayout();
			this.tp_Import.SuspendLayout();
			this.gb_TestData.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_TestData)).BeginInit();
			this.gb_ImportColumns.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.sc_ImportColumnMapping)).BeginInit();
			this.sc_ImportColumnMapping.Panel1.SuspendLayout();
			this.sc_ImportColumnMapping.Panel2.SuspendLayout();
			this.sc_ImportColumnMapping.SuspendLayout();
			this.gb_UnmappedColumns.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_UnmappedColumns)).BeginInit();
			this.gb_MappedColumns.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_MappedColumns)).BeginInit();
			this.ms_Main.SuspendLayout();
			this.stsr_Main.SuspendLayout();
			this.gb_ImportTemplateSelection.SuspendLayout();
			this.SuspendLayout();
			// 
			// tc_Main
			// 
			this.tc_Main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tc_Main.Controls.Add(this.tp_ClientAdministration);
			this.tc_Main.Controls.Add(this.tp_ImportConfiguration);
			this.tc_Main.Controls.Add(this.tp_SchemaAdmin);
			this.tc_Main.Controls.Add(this.tp_ColumnMapping);
			this.tc_Main.Controls.Add(this.tp_Import);
			this.tc_Main.Location = new System.Drawing.Point(12, 80);
			this.tc_Main.Name = "tc_Main";
			this.tc_Main.SelectedIndex = 0;
			this.tc_Main.Size = new System.Drawing.Size(984, 624);
			this.tc_Main.TabIndex = 1;
			// 
			// tp_ClientAdministration
			// 
			this.tp_ClientAdministration.Controls.Add(this.gb_ClientAdministration);
			this.tp_ClientAdministration.Location = new System.Drawing.Point(4, 22);
			this.tp_ClientAdministration.Name = "tp_ClientAdministration";
			this.tp_ClientAdministration.Size = new System.Drawing.Size(976, 598);
			this.tp_ClientAdministration.TabIndex = 3;
			this.tp_ClientAdministration.Text = "Client Administration";
			this.tp_ClientAdministration.UseVisualStyleBackColor = true;
			// 
			// gb_ClientAdministration
			// 
			this.gb_ClientAdministration.Controls.Add(this.sc_ClientAdministration);
			this.gb_ClientAdministration.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gb_ClientAdministration.Location = new System.Drawing.Point(0, 0);
			this.gb_ClientAdministration.Name = "gb_ClientAdministration";
			this.gb_ClientAdministration.Size = new System.Drawing.Size(976, 598);
			this.gb_ClientAdministration.TabIndex = 10;
			this.gb_ClientAdministration.TabStop = false;
			this.gb_ClientAdministration.Text = "Client Administration";
			// 
			// sc_ClientAdministration
			// 
			this.sc_ClientAdministration.Dock = System.Windows.Forms.DockStyle.Fill;
			this.sc_ClientAdministration.Location = new System.Drawing.Point(3, 16);
			this.sc_ClientAdministration.Name = "sc_ClientAdministration";
			// 
			// sc_ClientAdministration.Panel1
			// 
			this.sc_ClientAdministration.Panel1.Controls.Add(this.gb_ClientList);
			// 
			// sc_ClientAdministration.Panel2
			// 
			this.sc_ClientAdministration.Panel2.Controls.Add(this.sc_ClientModification);
			this.sc_ClientAdministration.Size = new System.Drawing.Size(970, 579);
			this.sc_ClientAdministration.SplitterDistance = 485;
			this.sc_ClientAdministration.TabIndex = 9;
			// 
			// gb_ClientList
			// 
			this.gb_ClientList.Controls.Add(this.dgv_Client);
			this.gb_ClientList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gb_ClientList.Location = new System.Drawing.Point(0, 0);
			this.gb_ClientList.Name = "gb_ClientList";
			this.gb_ClientList.Size = new System.Drawing.Size(485, 579);
			this.gb_ClientList.TabIndex = 0;
			this.gb_ClientList.TabStop = false;
			this.gb_ClientList.Text = "Clients";
			// 
			// dgv_Client
			// 
			this.dgv_Client.AllowUserToAddRows = false;
			this.dgv_Client.AllowUserToDeleteRows = false;
			this.dgv_Client.AllowUserToOrderColumns = true;
			this.dgv_Client.AllowUserToResizeRows = false;
			this.dgv_Client.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgv_Client.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgv_Client.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgv_Client.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgv_Client.DefaultCellStyle = dataGridViewCellStyle2;
			this.dgv_Client.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgv_Client.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.dgv_Client.Location = new System.Drawing.Point(3, 16);
			this.dgv_Client.MultiSelect = false;
			this.dgv_Client.Name = "dgv_Client";
			this.dgv_Client.ReadOnly = true;
			this.dgv_Client.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgv_Client.Size = new System.Drawing.Size(479, 560);
			this.dgv_Client.TabIndex = 0;
			this.dgv_Client.VirtualMode = true;
			this.dgv_Client.SelectionChanged += new System.EventHandler(this.dgv_Client_SelectionChanged);
			// 
			// sc_ClientModification
			// 
			this.sc_ClientModification.Dock = System.Windows.Forms.DockStyle.Fill;
			this.sc_ClientModification.Location = new System.Drawing.Point(0, 0);
			this.sc_ClientModification.Name = "sc_ClientModification";
			this.sc_ClientModification.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// sc_ClientModification.Panel1
			// 
			this.sc_ClientModification.Panel1.Controls.Add(this.gb_AddClient);
			// 
			// sc_ClientModification.Panel2
			// 
			this.sc_ClientModification.Panel2.Controls.Add(this.gb_EditClient);
			this.sc_ClientModification.Size = new System.Drawing.Size(481, 579);
			this.sc_ClientModification.SplitterDistance = 165;
			this.sc_ClientModification.TabIndex = 0;
			// 
			// gb_AddClient
			// 
			this.gb_AddClient.Controls.Add(this.tb_AddClientName);
			this.gb_AddClient.Controls.Add(this.btn_AddClient);
			this.gb_AddClient.Controls.Add(this.lbl_AddClientName);
			this.gb_AddClient.Controls.Add(this.btn_AddClientClear);
			this.gb_AddClient.Controls.Add(this.lbl_AddClientDescription);
			this.gb_AddClient.Controls.Add(this.tb_AddClientDescription);
			this.gb_AddClient.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gb_AddClient.Location = new System.Drawing.Point(0, 0);
			this.gb_AddClient.Name = "gb_AddClient";
			this.gb_AddClient.Size = new System.Drawing.Size(481, 165);
			this.gb_AddClient.TabIndex = 8;
			this.gb_AddClient.TabStop = false;
			this.gb_AddClient.Text = "Add New Client";
			// 
			// tb_AddClientName
			// 
			this.tb_AddClientName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tb_AddClientName.Location = new System.Drawing.Point(75, 19);
			this.tb_AddClientName.Name = "tb_AddClientName";
			this.tb_AddClientName.Size = new System.Drawing.Size(400, 20);
			this.tb_AddClientName.TabIndex = 2;
			// 
			// btn_AddClient
			// 
			this.btn_AddClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_AddClient.Location = new System.Drawing.Point(229, 130);
			this.btn_AddClient.Name = "btn_AddClient";
			this.btn_AddClient.Size = new System.Drawing.Size(120, 23);
			this.btn_AddClient.TabIndex = 6;
			this.btn_AddClient.Text = "Add Client";
			this.btn_AddClient.UseVisualStyleBackColor = true;
			this.btn_AddClient.Click += new System.EventHandler(this.btn_AddClient_Click);
			// 
			// lbl_AddClientName
			// 
			this.lbl_AddClientName.AutoSize = true;
			this.lbl_AddClientName.Location = new System.Drawing.Point(31, 26);
			this.lbl_AddClientName.Name = "lbl_AddClientName";
			this.lbl_AddClientName.Size = new System.Drawing.Size(38, 13);
			this.lbl_AddClientName.TabIndex = 1;
			this.lbl_AddClientName.Text = "Name:";
			// 
			// btn_AddClientClear
			// 
			this.btn_AddClientClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_AddClientClear.Location = new System.Drawing.Point(355, 130);
			this.btn_AddClientClear.Name = "btn_AddClientClear";
			this.btn_AddClientClear.Size = new System.Drawing.Size(120, 23);
			this.btn_AddClientClear.TabIndex = 5;
			this.btn_AddClientClear.Text = "Clear Input";
			this.btn_AddClientClear.UseVisualStyleBackColor = true;
			this.btn_AddClientClear.Click += new System.EventHandler(this.btn_AddClientClear_Click);
			// 
			// lbl_AddClientDescription
			// 
			this.lbl_AddClientDescription.AutoSize = true;
			this.lbl_AddClientDescription.Location = new System.Drawing.Point(6, 111);
			this.lbl_AddClientDescription.Name = "lbl_AddClientDescription";
			this.lbl_AddClientDescription.Size = new System.Drawing.Size(63, 13);
			this.lbl_AddClientDescription.TabIndex = 3;
			this.lbl_AddClientDescription.Text = "Description:";
			// 
			// tb_AddClientDescription
			// 
			this.tb_AddClientDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tb_AddClientDescription.Location = new System.Drawing.Point(75, 62);
			this.tb_AddClientDescription.Multiline = true;
			this.tb_AddClientDescription.Name = "tb_AddClientDescription";
			this.tb_AddClientDescription.Size = new System.Drawing.Size(400, 62);
			this.tb_AddClientDescription.TabIndex = 4;
			// 
			// gb_EditClient
			// 
			this.gb_EditClient.Controls.Add(this.tb_EditClientName);
			this.gb_EditClient.Controls.Add(this.btn_EditClient);
			this.gb_EditClient.Controls.Add(this.lbl_EditClientName);
			this.gb_EditClient.Controls.Add(this.btn_EditClientReset);
			this.gb_EditClient.Controls.Add(this.lbl_EditClientDescription);
			this.gb_EditClient.Controls.Add(this.tb_EditClientDescription);
			this.gb_EditClient.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gb_EditClient.Location = new System.Drawing.Point(0, 0);
			this.gb_EditClient.Name = "gb_EditClient";
			this.gb_EditClient.Size = new System.Drawing.Size(481, 410);
			this.gb_EditClient.TabIndex = 7;
			this.gb_EditClient.TabStop = false;
			this.gb_EditClient.Text = "Edit Existing Client";
			// 
			// tb_EditClientName
			// 
			this.tb_EditClientName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tb_EditClientName.Location = new System.Drawing.Point(75, 19);
			this.tb_EditClientName.Name = "tb_EditClientName";
			this.tb_EditClientName.Size = new System.Drawing.Size(400, 20);
			this.tb_EditClientName.TabIndex = 2;
			// 
			// btn_EditClient
			// 
			this.btn_EditClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_EditClient.Location = new System.Drawing.Point(229, 130);
			this.btn_EditClient.Name = "btn_EditClient";
			this.btn_EditClient.Size = new System.Drawing.Size(120, 23);
			this.btn_EditClient.TabIndex = 6;
			this.btn_EditClient.Text = "Save Changes";
			this.btn_EditClient.UseVisualStyleBackColor = true;
			this.btn_EditClient.Click += new System.EventHandler(this.btn_EditClient_Click);
			// 
			// lbl_EditClientName
			// 
			this.lbl_EditClientName.AutoSize = true;
			this.lbl_EditClientName.Location = new System.Drawing.Point(31, 26);
			this.lbl_EditClientName.Name = "lbl_EditClientName";
			this.lbl_EditClientName.Size = new System.Drawing.Size(38, 13);
			this.lbl_EditClientName.TabIndex = 1;
			this.lbl_EditClientName.Text = "Name:";
			// 
			// btn_EditClientReset
			// 
			this.btn_EditClientReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_EditClientReset.Location = new System.Drawing.Point(355, 130);
			this.btn_EditClientReset.Name = "btn_EditClientReset";
			this.btn_EditClientReset.Size = new System.Drawing.Size(120, 23);
			this.btn_EditClientReset.TabIndex = 5;
			this.btn_EditClientReset.Text = "Reset Changes";
			this.btn_EditClientReset.UseVisualStyleBackColor = true;
			this.btn_EditClientReset.Click += new System.EventHandler(this.btn_EditClientReset_Click);
			// 
			// lbl_EditClientDescription
			// 
			this.lbl_EditClientDescription.AutoSize = true;
			this.lbl_EditClientDescription.Location = new System.Drawing.Point(6, 111);
			this.lbl_EditClientDescription.Name = "lbl_EditClientDescription";
			this.lbl_EditClientDescription.Size = new System.Drawing.Size(63, 13);
			this.lbl_EditClientDescription.TabIndex = 3;
			this.lbl_EditClientDescription.Text = "Description:";
			// 
			// tb_EditClientDescription
			// 
			this.tb_EditClientDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tb_EditClientDescription.Location = new System.Drawing.Point(75, 62);
			this.tb_EditClientDescription.Multiline = true;
			this.tb_EditClientDescription.Name = "tb_EditClientDescription";
			this.tb_EditClientDescription.Size = new System.Drawing.Size(400, 62);
			this.tb_EditClientDescription.TabIndex = 4;
			// 
			// tp_ImportConfiguration
			// 
			this.tp_ImportConfiguration.Controls.Add(this.gb_SQLCredentialsClientSelection);
			this.tp_ImportConfiguration.Controls.Add(this.gb_FileSelection);
			this.tp_ImportConfiguration.Controls.Add(this.gb_SQLObjectSelection);
			this.tp_ImportConfiguration.Location = new System.Drawing.Point(4, 22);
			this.tp_ImportConfiguration.Name = "tp_ImportConfiguration";
			this.tp_ImportConfiguration.Size = new System.Drawing.Size(976, 598);
			this.tp_ImportConfiguration.TabIndex = 4;
			this.tp_ImportConfiguration.Text = "Import Configuration";
			this.tp_ImportConfiguration.UseVisualStyleBackColor = true;
			// 
			// gb_SQLCredentialsClientSelection
			// 
			this.gb_SQLCredentialsClientSelection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gb_SQLCredentialsClientSelection.Controls.Add(this.sc_SQLCredentialsClientSelection);
			this.gb_SQLCredentialsClientSelection.Location = new System.Drawing.Point(3, 3);
			this.gb_SQLCredentialsClientSelection.Name = "gb_SQLCredentialsClientSelection";
			this.gb_SQLCredentialsClientSelection.Size = new System.Drawing.Size(970, 122);
			this.gb_SQLCredentialsClientSelection.TabIndex = 15;
			this.gb_SQLCredentialsClientSelection.TabStop = false;
			this.gb_SQLCredentialsClientSelection.Text = "Specify SQL Credentials and Select a Client";
			// 
			// sc_SQLCredentialsClientSelection
			// 
			this.sc_SQLCredentialsClientSelection.Dock = System.Windows.Forms.DockStyle.Fill;
			this.sc_SQLCredentialsClientSelection.Location = new System.Drawing.Point(3, 16);
			this.sc_SQLCredentialsClientSelection.Name = "sc_SQLCredentialsClientSelection";
			// 
			// sc_SQLCredentialsClientSelection.Panel1
			// 
			this.sc_SQLCredentialsClientSelection.Panel1.Controls.Add(this.gb_UserConfiguration);
			// 
			// sc_SQLCredentialsClientSelection.Panel2
			// 
			this.sc_SQLCredentialsClientSelection.Panel2.Controls.Add(this.gb_ClientSelect);
			this.sc_SQLCredentialsClientSelection.Size = new System.Drawing.Size(964, 103);
			this.sc_SQLCredentialsClientSelection.SplitterDistance = 321;
			this.sc_SQLCredentialsClientSelection.TabIndex = 13;
			// 
			// gb_UserConfiguration
			// 
			this.gb_UserConfiguration.Controls.Add(this.lbl_Password);
			this.gb_UserConfiguration.Controls.Add(this.btn_RefreshSqlObjects);
			this.gb_UserConfiguration.Controls.Add(this.tb_Password);
			this.gb_UserConfiguration.Controls.Add(this.tb_Username);
			this.gb_UserConfiguration.Controls.Add(this.lbl_Username);
			this.gb_UserConfiguration.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gb_UserConfiguration.Location = new System.Drawing.Point(0, 0);
			this.gb_UserConfiguration.Name = "gb_UserConfiguration";
			this.gb_UserConfiguration.Size = new System.Drawing.Size(321, 103);
			this.gb_UserConfiguration.TabIndex = 9;
			this.gb_UserConfiguration.TabStop = false;
			this.gb_UserConfiguration.Text = "SQL User Configuration";
			// 
			// lbl_Password
			// 
			this.lbl_Password.AutoSize = true;
			this.lbl_Password.Location = new System.Drawing.Point(8, 49);
			this.lbl_Password.Name = "lbl_Password";
			this.lbl_Password.Size = new System.Drawing.Size(56, 13);
			this.lbl_Password.TabIndex = 3;
			this.lbl_Password.Text = "Password:";
			// 
			// btn_RefreshSqlObjects
			// 
			this.btn_RefreshSqlObjects.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_RefreshSqlObjects.Location = new System.Drawing.Point(70, 72);
			this.btn_RefreshSqlObjects.Name = "btn_RefreshSqlObjects";
			this.btn_RefreshSqlObjects.Size = new System.Drawing.Size(238, 24);
			this.btn_RefreshSqlObjects.TabIndex = 12;
			this.btn_RefreshSqlObjects.Text = "Refresh SQL Objects";
			this.btn_RefreshSqlObjects.UseVisualStyleBackColor = true;
			// 
			// tb_Password
			// 
			this.tb_Password.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tb_Password.Location = new System.Drawing.Point(70, 46);
			this.tb_Password.Name = "tb_Password";
			this.tb_Password.PasswordChar = '*';
			this.tb_Password.Size = new System.Drawing.Size(238, 20);
			this.tb_Password.TabIndex = 2;
			// 
			// tb_Username
			// 
			this.tb_Username.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tb_Username.Location = new System.Drawing.Point(70, 19);
			this.tb_Username.Name = "tb_Username";
			this.tb_Username.Size = new System.Drawing.Size(238, 20);
			this.tb_Username.TabIndex = 1;
			// 
			// lbl_Username
			// 
			this.lbl_Username.AutoSize = true;
			this.lbl_Username.Location = new System.Drawing.Point(6, 22);
			this.lbl_Username.Name = "lbl_Username";
			this.lbl_Username.Size = new System.Drawing.Size(58, 13);
			this.lbl_Username.TabIndex = 0;
			this.lbl_Username.Text = "Username:";
			// 
			// gb_ClientSelect
			// 
			this.gb_ClientSelect.Controls.Add(this.ddl_Client);
			this.gb_ClientSelect.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gb_ClientSelect.Location = new System.Drawing.Point(0, 0);
			this.gb_ClientSelect.Name = "gb_ClientSelect";
			this.gb_ClientSelect.Size = new System.Drawing.Size(639, 103);
			this.gb_ClientSelect.TabIndex = 0;
			this.gb_ClientSelect.TabStop = false;
			this.gb_ClientSelect.Text = "Client Selection";
			// 
			// ddl_Client
			// 
			this.ddl_Client.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ddl_Client.DisplayMember = "Name";
			this.ddl_Client.FormattingEnabled = true;
			this.ddl_Client.Location = new System.Drawing.Point(7, 20);
			this.ddl_Client.Name = "ddl_Client";
			this.ddl_Client.Size = new System.Drawing.Size(623, 21);
			this.ddl_Client.TabIndex = 0;
			this.ddl_Client.ValueMember = "ID";
			this.ddl_Client.SelectedIndexChanged += new System.EventHandler(this.ddl_Client_SelectedIndexChanged);
			// 
			// gb_FileSelection
			// 
			this.gb_FileSelection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gb_FileSelection.Controls.Add(this.ckb_HasHeader);
			this.gb_FileSelection.Controls.Add(this.tb_SelectedFile);
			this.gb_FileSelection.Controls.Add(this.btn_SelectFile);
			this.gb_FileSelection.Location = new System.Drawing.Point(3, 212);
			this.gb_FileSelection.Name = "gb_FileSelection";
			this.gb_FileSelection.Size = new System.Drawing.Size(970, 50);
			this.gb_FileSelection.TabIndex = 11;
			this.gb_FileSelection.TabStop = false;
			this.gb_FileSelection.Text = "File Selection";
			// 
			// ckb_HasHeader
			// 
			this.ckb_HasHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ckb_HasHeader.AutoSize = true;
			this.ckb_HasHeader.Checked = true;
			this.ckb_HasHeader.CheckState = System.Windows.Forms.CheckState.Checked;
			this.ckb_HasHeader.Location = new System.Drawing.Point(881, 21);
			this.ckb_HasHeader.Name = "ckb_HasHeader";
			this.ckb_HasHeader.Size = new System.Drawing.Size(83, 17);
			this.ckb_HasHeader.TabIndex = 2;
			this.ckb_HasHeader.Text = "Has Header";
			this.ckb_HasHeader.UseVisualStyleBackColor = true;
			// 
			// tb_SelectedFile
			// 
			this.tb_SelectedFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tb_SelectedFile.Location = new System.Drawing.Point(87, 19);
			this.tb_SelectedFile.Name = "tb_SelectedFile";
			this.tb_SelectedFile.Size = new System.Drawing.Size(786, 20);
			this.tb_SelectedFile.TabIndex = 1;
			this.tb_SelectedFile.Text = "No File Selected";
			this.tb_SelectedFile.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// btn_SelectFile
			// 
			this.btn_SelectFile.Location = new System.Drawing.Point(6, 20);
			this.btn_SelectFile.Name = "btn_SelectFile";
			this.btn_SelectFile.Size = new System.Drawing.Size(75, 23);
			this.btn_SelectFile.TabIndex = 0;
			this.btn_SelectFile.Text = "Select File";
			this.btn_SelectFile.UseVisualStyleBackColor = true;
			this.btn_SelectFile.Click += new System.EventHandler(this.btn_SelectFile_Click);
			// 
			// gb_SQLObjectSelection
			// 
			this.gb_SQLObjectSelection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gb_SQLObjectSelection.Controls.Add(this.sc_DestinationSelection);
			this.gb_SQLObjectSelection.Location = new System.Drawing.Point(3, 131);
			this.gb_SQLObjectSelection.Name = "gb_SQLObjectSelection";
			this.gb_SQLObjectSelection.Size = new System.Drawing.Size(970, 75);
			this.gb_SQLObjectSelection.TabIndex = 10;
			this.gb_SQLObjectSelection.TabStop = false;
			this.gb_SQLObjectSelection.Text = "Specify which SQL Object to utilize:";
			// 
			// sc_DestinationSelection
			// 
			this.sc_DestinationSelection.Dock = System.Windows.Forms.DockStyle.Fill;
			this.sc_DestinationSelection.Location = new System.Drawing.Point(3, 16);
			this.sc_DestinationSelection.Name = "sc_DestinationSelection";
			// 
			// sc_DestinationSelection.Panel1
			// 
			this.sc_DestinationSelection.Panel1.Controls.Add(this.sc_ServerDatabaseSelection);
			// 
			// sc_DestinationSelection.Panel2
			// 
			this.sc_DestinationSelection.Panel2.Controls.Add(this.sc_SchemaTableSelection);
			this.sc_DestinationSelection.Size = new System.Drawing.Size(964, 56);
			this.sc_DestinationSelection.SplitterDistance = 482;
			this.sc_DestinationSelection.TabIndex = 11;
			// 
			// sc_ServerDatabaseSelection
			// 
			this.sc_ServerDatabaseSelection.Dock = System.Windows.Forms.DockStyle.Fill;
			this.sc_ServerDatabaseSelection.Location = new System.Drawing.Point(0, 0);
			this.sc_ServerDatabaseSelection.Name = "sc_ServerDatabaseSelection";
			// 
			// sc_ServerDatabaseSelection.Panel1
			// 
			this.sc_ServerDatabaseSelection.Panel1.Controls.Add(this.gb_ServerSelection);
			// 
			// sc_ServerDatabaseSelection.Panel2
			// 
			this.sc_ServerDatabaseSelection.Panel2.Controls.Add(this.gb_DatabaseSelection);
			this.sc_ServerDatabaseSelection.Size = new System.Drawing.Size(482, 56);
			this.sc_ServerDatabaseSelection.SplitterDistance = 241;
			this.sc_ServerDatabaseSelection.TabIndex = 0;
			// 
			// gb_ServerSelection
			// 
			this.gb_ServerSelection.Controls.Add(this.ddl_Server);
			this.gb_ServerSelection.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gb_ServerSelection.Location = new System.Drawing.Point(0, 0);
			this.gb_ServerSelection.Name = "gb_ServerSelection";
			this.gb_ServerSelection.Size = new System.Drawing.Size(241, 56);
			this.gb_ServerSelection.TabIndex = 6;
			this.gb_ServerSelection.TabStop = false;
			this.gb_ServerSelection.Text = "Server";
			// 
			// ddl_Server
			// 
			this.ddl_Server.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ddl_Server.FormattingEnabled = true;
			this.ddl_Server.Items.AddRange(new object[] {
            ""});
			this.ddl_Server.Location = new System.Drawing.Point(6, 19);
			this.ddl_Server.Name = "ddl_Server";
			this.ddl_Server.Size = new System.Drawing.Size(229, 21);
			this.ddl_Server.TabIndex = 1;
			this.ddl_Server.SelectedIndexChanged += new System.EventHandler(this.ddl_Server_SelectedIndexChanged);
			// 
			// gb_DatabaseSelection
			// 
			this.gb_DatabaseSelection.Controls.Add(this.ddl_Database);
			this.gb_DatabaseSelection.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gb_DatabaseSelection.Location = new System.Drawing.Point(0, 0);
			this.gb_DatabaseSelection.Name = "gb_DatabaseSelection";
			this.gb_DatabaseSelection.Size = new System.Drawing.Size(237, 56);
			this.gb_DatabaseSelection.TabIndex = 7;
			this.gb_DatabaseSelection.TabStop = false;
			this.gb_DatabaseSelection.Text = "Database";
			// 
			// ddl_Database
			// 
			this.ddl_Database.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ddl_Database.FormattingEnabled = true;
			this.ddl_Database.Location = new System.Drawing.Point(6, 19);
			this.ddl_Database.Name = "ddl_Database";
			this.ddl_Database.Size = new System.Drawing.Size(225, 21);
			this.ddl_Database.TabIndex = 2;
			this.ddl_Database.SelectedIndexChanged += new System.EventHandler(this.ddl_Database_SelectedIndexChanged);
			// 
			// sc_SchemaTableSelection
			// 
			this.sc_SchemaTableSelection.Dock = System.Windows.Forms.DockStyle.Fill;
			this.sc_SchemaTableSelection.Location = new System.Drawing.Point(0, 0);
			this.sc_SchemaTableSelection.Name = "sc_SchemaTableSelection";
			// 
			// sc_SchemaTableSelection.Panel1
			// 
			this.sc_SchemaTableSelection.Panel1.Controls.Add(this.gb_SchemaSelection);
			// 
			// sc_SchemaTableSelection.Panel2
			// 
			this.sc_SchemaTableSelection.Panel2.Controls.Add(this.gb_TableSelection);
			this.sc_SchemaTableSelection.Size = new System.Drawing.Size(478, 56);
			this.sc_SchemaTableSelection.SplitterDistance = 241;
			this.sc_SchemaTableSelection.TabIndex = 0;
			// 
			// gb_SchemaSelection
			// 
			this.gb_SchemaSelection.Controls.Add(this.ddl_Schema);
			this.gb_SchemaSelection.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gb_SchemaSelection.Location = new System.Drawing.Point(0, 0);
			this.gb_SchemaSelection.Name = "gb_SchemaSelection";
			this.gb_SchemaSelection.Size = new System.Drawing.Size(241, 56);
			this.gb_SchemaSelection.TabIndex = 9;
			this.gb_SchemaSelection.TabStop = false;
			this.gb_SchemaSelection.Text = "Schema";
			// 
			// ddl_Schema
			// 
			this.ddl_Schema.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ddl_Schema.FormattingEnabled = true;
			this.ddl_Schema.Location = new System.Drawing.Point(6, 19);
			this.ddl_Schema.Name = "ddl_Schema";
			this.ddl_Schema.Size = new System.Drawing.Size(229, 21);
			this.ddl_Schema.TabIndex = 5;
			this.ddl_Schema.SelectedIndexChanged += new System.EventHandler(this.ddl_Schema_SelectedIndexChanged);
			// 
			// gb_TableSelection
			// 
			this.gb_TableSelection.Controls.Add(this.ddl_Table);
			this.gb_TableSelection.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gb_TableSelection.Location = new System.Drawing.Point(0, 0);
			this.gb_TableSelection.Name = "gb_TableSelection";
			this.gb_TableSelection.Size = new System.Drawing.Size(233, 56);
			this.gb_TableSelection.TabIndex = 8;
			this.gb_TableSelection.TabStop = false;
			this.gb_TableSelection.Text = "Table";
			// 
			// ddl_Table
			// 
			this.ddl_Table.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ddl_Table.FormattingEnabled = true;
			this.ddl_Table.Location = new System.Drawing.Point(6, 19);
			this.ddl_Table.Name = "ddl_Table";
			this.ddl_Table.Size = new System.Drawing.Size(221, 21);
			this.ddl_Table.TabIndex = 5;
			this.ddl_Table.SelectedIndexChanged += new System.EventHandler(this.ddl_Table_SelectedIndexChanged);
			// 
			// tp_SchemaAdmin
			// 
			this.tp_SchemaAdmin.Controls.Add(this.gb_Column);
			this.tp_SchemaAdmin.Location = new System.Drawing.Point(4, 22);
			this.tp_SchemaAdmin.Name = "tp_SchemaAdmin";
			this.tp_SchemaAdmin.Padding = new System.Windows.Forms.Padding(3);
			this.tp_SchemaAdmin.Size = new System.Drawing.Size(976, 598);
			this.tp_SchemaAdmin.TabIndex = 0;
			this.tp_SchemaAdmin.Text = "Schema Administration";
			this.tp_SchemaAdmin.UseVisualStyleBackColor = true;
			// 
			// gb_Column
			// 
			this.gb_Column.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gb_Column.Controls.Add(this.dgv_Columns);
			this.gb_Column.Location = new System.Drawing.Point(8, 6);
			this.gb_Column.Name = "gb_Column";
			this.gb_Column.Size = new System.Drawing.Size(960, 248);
			this.gb_Column.TabIndex = 12;
			this.gb_Column.TabStop = false;
			this.gb_Column.Text = "Columns";
			// 
			// dgv_Columns
			// 
			this.dgv_Columns.AllowUserToOrderColumns = true;
			this.dgv_Columns.AllowUserToResizeRows = false;
			this.dgv_Columns.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgv_Columns.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgv_Columns.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dgv_Columns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgv_Columns.DefaultCellStyle = dataGridViewCellStyle4;
			this.dgv_Columns.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgv_Columns.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.dgv_Columns.Location = new System.Drawing.Point(3, 16);
			this.dgv_Columns.MultiSelect = false;
			this.dgv_Columns.Name = "dgv_Columns";
			this.dgv_Columns.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgv_Columns.Size = new System.Drawing.Size(954, 229);
			this.dgv_Columns.TabIndex = 11;
			this.dgv_Columns.VirtualMode = true;
			this.dgv_Columns.SelectionChanged += new System.EventHandler(this.dgv_Columns_SelectionChanged);
			// 
			// tp_ColumnMapping
			// 
			this.tp_ColumnMapping.Controls.Add(this.gb_ColumnImportMapping);
			this.tp_ColumnMapping.Location = new System.Drawing.Point(4, 22);
			this.tp_ColumnMapping.Name = "tp_ColumnMapping";
			this.tp_ColumnMapping.Padding = new System.Windows.Forms.Padding(3);
			this.tp_ColumnMapping.Size = new System.Drawing.Size(976, 598);
			this.tp_ColumnMapping.TabIndex = 1;
			this.tp_ColumnMapping.Text = "Column Import Mapping";
			this.tp_ColumnMapping.UseVisualStyleBackColor = true;
			// 
			// gb_ColumnImportMapping
			// 
			this.gb_ColumnImportMapping.Controls.Add(this.sc_ColumnImports);
			this.gb_ColumnImportMapping.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gb_ColumnImportMapping.Location = new System.Drawing.Point(3, 3);
			this.gb_ColumnImportMapping.Margin = new System.Windows.Forms.Padding(0);
			this.gb_ColumnImportMapping.Name = "gb_ColumnImportMapping";
			this.gb_ColumnImportMapping.Padding = new System.Windows.Forms.Padding(0);
			this.gb_ColumnImportMapping.Size = new System.Drawing.Size(970, 592);
			this.gb_ColumnImportMapping.TabIndex = 5;
			this.gb_ColumnImportMapping.TabStop = false;
			// 
			// sc_ColumnImports
			// 
			this.sc_ColumnImports.Dock = System.Windows.Forms.DockStyle.Fill;
			this.sc_ColumnImports.Location = new System.Drawing.Point(0, 13);
			this.sc_ColumnImports.Name = "sc_ColumnImports";
			// 
			// sc_ColumnImports.Panel1
			// 
			this.sc_ColumnImports.Panel1.Controls.Add(this.gb_ColumnMapList);
			// 
			// sc_ColumnImports.Panel2
			// 
			this.sc_ColumnImports.Panel2.Controls.Add(this.sc_ColumnMappingInformation);
			this.sc_ColumnImports.Size = new System.Drawing.Size(970, 579);
			this.sc_ColumnImports.SplitterDistance = 300;
			this.sc_ColumnImports.TabIndex = 0;
			// 
			// gb_ColumnMapList
			// 
			this.gb_ColumnMapList.Controls.Add(this.dgv_ColumnMap);
			this.gb_ColumnMapList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gb_ColumnMapList.Location = new System.Drawing.Point(0, 0);
			this.gb_ColumnMapList.Name = "gb_ColumnMapList";
			this.gb_ColumnMapList.Size = new System.Drawing.Size(300, 579);
			this.gb_ColumnMapList.TabIndex = 0;
			this.gb_ColumnMapList.TabStop = false;
			this.gb_ColumnMapList.Text = "Column Maps";
			// 
			// dgv_ColumnMap
			// 
			this.dgv_ColumnMap.AllowUserToAddRows = false;
			this.dgv_ColumnMap.AllowUserToDeleteRows = false;
			this.dgv_ColumnMap.AllowUserToOrderColumns = true;
			this.dgv_ColumnMap.AllowUserToResizeRows = false;
			this.dgv_ColumnMap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgv_ColumnMap.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgv_ColumnMap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
			this.dgv_ColumnMap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgv_ColumnMap.DefaultCellStyle = dataGridViewCellStyle6;
			this.dgv_ColumnMap.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgv_ColumnMap.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.dgv_ColumnMap.Location = new System.Drawing.Point(3, 16);
			this.dgv_ColumnMap.MultiSelect = false;
			this.dgv_ColumnMap.Name = "dgv_ColumnMap";
			this.dgv_ColumnMap.ReadOnly = true;
			this.dgv_ColumnMap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgv_ColumnMap.Size = new System.Drawing.Size(294, 560);
			this.dgv_ColumnMap.TabIndex = 0;
			this.dgv_ColumnMap.VirtualMode = true;
			this.dgv_ColumnMap.SelectionChanged += new System.EventHandler(this.dgv_ColumnMap_SelectionChanged);
			this.dgv_ColumnMap.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgv_ColumnMap_KeyDown);
			// 
			// sc_ColumnMappingInformation
			// 
			this.sc_ColumnMappingInformation.Dock = System.Windows.Forms.DockStyle.Fill;
			this.sc_ColumnMappingInformation.Location = new System.Drawing.Point(0, 0);
			this.sc_ColumnMappingInformation.Name = "sc_ColumnMappingInformation";
			this.sc_ColumnMappingInformation.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// sc_ColumnMappingInformation.Panel1
			// 
			this.sc_ColumnMappingInformation.Panel1.Controls.Add(this.gb_AddColumnMap);
			// 
			// sc_ColumnMappingInformation.Panel2
			// 
			this.sc_ColumnMappingInformation.Panel2.Controls.Add(this.gb_EditColumnMap);
			this.sc_ColumnMappingInformation.Size = new System.Drawing.Size(666, 579);
			this.sc_ColumnMappingInformation.SplitterDistance = 105;
			this.sc_ColumnMappingInformation.TabIndex = 0;
			// 
			// gb_AddColumnMap
			// 
			this.gb_AddColumnMap.Controls.Add(this.sc_AddColumnMapping);
			this.gb_AddColumnMap.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gb_AddColumnMap.Location = new System.Drawing.Point(0, 0);
			this.gb_AddColumnMap.Name = "gb_AddColumnMap";
			this.gb_AddColumnMap.Size = new System.Drawing.Size(666, 105);
			this.gb_AddColumnMap.TabIndex = 1;
			this.gb_AddColumnMap.TabStop = false;
			this.gb_AddColumnMap.Text = "Add Column Mapping";
			// 
			// sc_AddColumnMapping
			// 
			this.sc_AddColumnMapping.Dock = System.Windows.Forms.DockStyle.Fill;
			this.sc_AddColumnMapping.Location = new System.Drawing.Point(3, 16);
			this.sc_AddColumnMapping.Name = "sc_AddColumnMapping";
			this.sc_AddColumnMapping.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// sc_AddColumnMapping.Panel1
			// 
			this.sc_AddColumnMapping.Panel1.Controls.Add(this.sc_AddColumnMappingInformation);
			// 
			// sc_AddColumnMapping.Panel2
			// 
			this.sc_AddColumnMapping.Panel2.Controls.Add(this.btn_AddColumnMapClear);
			this.sc_AddColumnMapping.Panel2.Controls.Add(this.btn_AddColumnMap);
			this.sc_AddColumnMapping.Size = new System.Drawing.Size(660, 86);
			this.sc_AddColumnMapping.SplitterDistance = 43;
			this.sc_AddColumnMapping.TabIndex = 4;
			// 
			// sc_AddColumnMappingInformation
			// 
			this.sc_AddColumnMappingInformation.Dock = System.Windows.Forms.DockStyle.Fill;
			this.sc_AddColumnMappingInformation.Location = new System.Drawing.Point(0, 0);
			this.sc_AddColumnMappingInformation.Name = "sc_AddColumnMappingInformation";
			// 
			// sc_AddColumnMappingInformation.Panel1
			// 
			this.sc_AddColumnMappingInformation.Panel1.Controls.Add(this.gb_AddColumnMapSelection);
			// 
			// sc_AddColumnMappingInformation.Panel2
			// 
			this.sc_AddColumnMappingInformation.Panel2.Controls.Add(this.gb_MapNewIdentifier);
			this.sc_AddColumnMappingInformation.Size = new System.Drawing.Size(660, 43);
			this.sc_AddColumnMappingInformation.SplitterDistance = 330;
			this.sc_AddColumnMappingInformation.TabIndex = 0;
			// 
			// gb_AddColumnMapSelection
			// 
			this.gb_AddColumnMapSelection.Controls.Add(this.ddl_AddColumnMapColumn);
			this.gb_AddColumnMapSelection.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gb_AddColumnMapSelection.Location = new System.Drawing.Point(0, 0);
			this.gb_AddColumnMapSelection.Name = "gb_AddColumnMapSelection";
			this.gb_AddColumnMapSelection.Size = new System.Drawing.Size(330, 43);
			this.gb_AddColumnMapSelection.TabIndex = 0;
			this.gb_AddColumnMapSelection.TabStop = false;
			this.gb_AddColumnMapSelection.Text = "Column Selection";
			// 
			// ddl_AddColumnMapColumn
			// 
			this.ddl_AddColumnMapColumn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ddl_AddColumnMapColumn.DisplayMember = "Name";
			this.ddl_AddColumnMapColumn.FormattingEnabled = true;
			this.ddl_AddColumnMapColumn.Location = new System.Drawing.Point(6, 19);
			this.ddl_AddColumnMapColumn.Name = "ddl_AddColumnMapColumn";
			this.ddl_AddColumnMapColumn.Size = new System.Drawing.Size(318, 21);
			this.ddl_AddColumnMapColumn.TabIndex = 0;
			this.ddl_AddColumnMapColumn.ValueMember = "ID";
			this.ddl_AddColumnMapColumn.SelectedIndexChanged += new System.EventHandler(this.ddl_AddColumnMapColumn_SelectedIndexChanged);
			// 
			// gb_MapNewIdentifier
			// 
			this.gb_MapNewIdentifier.Controls.Add(this.tb_AddColumnMapIdentifier);
			this.gb_MapNewIdentifier.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gb_MapNewIdentifier.Location = new System.Drawing.Point(0, 0);
			this.gb_MapNewIdentifier.Name = "gb_MapNewIdentifier";
			this.gb_MapNewIdentifier.Size = new System.Drawing.Size(326, 43);
			this.gb_MapNewIdentifier.TabIndex = 1;
			this.gb_MapNewIdentifier.TabStop = false;
			this.gb_MapNewIdentifier.Text = "New Identifier";
			// 
			// tb_AddColumnMapIdentifier
			// 
			this.tb_AddColumnMapIdentifier.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tb_AddColumnMapIdentifier.Location = new System.Drawing.Point(6, 19);
			this.tb_AddColumnMapIdentifier.Name = "tb_AddColumnMapIdentifier";
			this.tb_AddColumnMapIdentifier.Size = new System.Drawing.Size(314, 20);
			this.tb_AddColumnMapIdentifier.TabIndex = 0;
			// 
			// btn_AddColumnMapClear
			// 
			this.btn_AddColumnMapClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_AddColumnMapClear.Location = new System.Drawing.Point(350, 3);
			this.btn_AddColumnMapClear.Name = "btn_AddColumnMapClear";
			this.btn_AddColumnMapClear.Size = new System.Drawing.Size(149, 26);
			this.btn_AddColumnMapClear.TabIndex = 3;
			this.btn_AddColumnMapClear.Text = "Clear Input";
			this.btn_AddColumnMapClear.UseVisualStyleBackColor = true;
			this.btn_AddColumnMapClear.Click += new System.EventHandler(this.btn_ColumnMapMapClear_Click);
			// 
			// btn_AddColumnMap
			// 
			this.btn_AddColumnMap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_AddColumnMap.Location = new System.Drawing.Point(505, 3);
			this.btn_AddColumnMap.Name = "btn_AddColumnMap";
			this.btn_AddColumnMap.Size = new System.Drawing.Size(149, 26);
			this.btn_AddColumnMap.TabIndex = 2;
			this.btn_AddColumnMap.Text = "Add Column Map";
			this.btn_AddColumnMap.UseVisualStyleBackColor = true;
			this.btn_AddColumnMap.Click += new System.EventHandler(this.btn_AddColumnMap_Click);
			// 
			// gb_EditColumnMap
			// 
			this.gb_EditColumnMap.Controls.Add(this.sc_EditColumnMapping);
			this.gb_EditColumnMap.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gb_EditColumnMap.Location = new System.Drawing.Point(0, 0);
			this.gb_EditColumnMap.Name = "gb_EditColumnMap";
			this.gb_EditColumnMap.Size = new System.Drawing.Size(666, 470);
			this.gb_EditColumnMap.TabIndex = 4;
			this.gb_EditColumnMap.TabStop = false;
			this.gb_EditColumnMap.Text = "Edit Column Mapping";
			// 
			// sc_EditColumnMapping
			// 
			this.sc_EditColumnMapping.Dock = System.Windows.Forms.DockStyle.Fill;
			this.sc_EditColumnMapping.Location = new System.Drawing.Point(3, 16);
			this.sc_EditColumnMapping.Name = "sc_EditColumnMapping";
			this.sc_EditColumnMapping.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// sc_EditColumnMapping.Panel1
			// 
			this.sc_EditColumnMapping.Panel1.Controls.Add(this.sc_EditColumnMappingInformation);
			// 
			// sc_EditColumnMapping.Panel2
			// 
			this.sc_EditColumnMapping.Panel2.Controls.Add(this.btn_EditColumnMapClear);
			this.sc_EditColumnMapping.Panel2.Controls.Add(this.btn_EditColumnMap);
			this.sc_EditColumnMapping.Size = new System.Drawing.Size(660, 451);
			this.sc_EditColumnMapping.SplitterDistance = 225;
			this.sc_EditColumnMapping.TabIndex = 4;
			// 
			// sc_EditColumnMappingInformation
			// 
			this.sc_EditColumnMappingInformation.Dock = System.Windows.Forms.DockStyle.Fill;
			this.sc_EditColumnMappingInformation.Location = new System.Drawing.Point(0, 0);
			this.sc_EditColumnMappingInformation.Name = "sc_EditColumnMappingInformation";
			// 
			// sc_EditColumnMappingInformation.Panel1
			// 
			this.sc_EditColumnMappingInformation.Panel1.Controls.Add(this.gb_EditColumnMapColumn);
			// 
			// sc_EditColumnMappingInformation.Panel2
			// 
			this.sc_EditColumnMappingInformation.Panel2.Controls.Add(this.gb_EditColumnMapIdentifier);
			this.sc_EditColumnMappingInformation.Size = new System.Drawing.Size(660, 225);
			this.sc_EditColumnMappingInformation.SplitterDistance = 330;
			this.sc_EditColumnMappingInformation.TabIndex = 0;
			// 
			// gb_EditColumnMapColumn
			// 
			this.gb_EditColumnMapColumn.Controls.Add(this.ddl_EditColumnMapColumn);
			this.gb_EditColumnMapColumn.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gb_EditColumnMapColumn.Location = new System.Drawing.Point(0, 0);
			this.gb_EditColumnMapColumn.Name = "gb_EditColumnMapColumn";
			this.gb_EditColumnMapColumn.Size = new System.Drawing.Size(330, 225);
			this.gb_EditColumnMapColumn.TabIndex = 0;
			this.gb_EditColumnMapColumn.TabStop = false;
			this.gb_EditColumnMapColumn.Text = "Selected Column";
			// 
			// ddl_EditColumnMapColumn
			// 
			this.ddl_EditColumnMapColumn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ddl_EditColumnMapColumn.DisplayMember = "Name";
			this.ddl_EditColumnMapColumn.FormattingEnabled = true;
			this.ddl_EditColumnMapColumn.Location = new System.Drawing.Point(6, 19);
			this.ddl_EditColumnMapColumn.Name = "ddl_EditColumnMapColumn";
			this.ddl_EditColumnMapColumn.Size = new System.Drawing.Size(318, 21);
			this.ddl_EditColumnMapColumn.TabIndex = 0;
			this.ddl_EditColumnMapColumn.ValueMember = "ID";
			this.ddl_EditColumnMapColumn.SelectedIndexChanged += new System.EventHandler(this.ddl_EditColumnMapColumn_SelectedIndexChanged);
			// 
			// gb_EditColumnMapIdentifier
			// 
			this.gb_EditColumnMapIdentifier.Controls.Add(this.tb_EditColumnMapIdentifier);
			this.gb_EditColumnMapIdentifier.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gb_EditColumnMapIdentifier.Location = new System.Drawing.Point(0, 0);
			this.gb_EditColumnMapIdentifier.Name = "gb_EditColumnMapIdentifier";
			this.gb_EditColumnMapIdentifier.Size = new System.Drawing.Size(326, 225);
			this.gb_EditColumnMapIdentifier.TabIndex = 1;
			this.gb_EditColumnMapIdentifier.TabStop = false;
			this.gb_EditColumnMapIdentifier.Text = "Custom Identifier";
			// 
			// tb_EditColumnMapIdentifier
			// 
			this.tb_EditColumnMapIdentifier.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tb_EditColumnMapIdentifier.Location = new System.Drawing.Point(6, 19);
			this.tb_EditColumnMapIdentifier.Name = "tb_EditColumnMapIdentifier";
			this.tb_EditColumnMapIdentifier.Size = new System.Drawing.Size(314, 20);
			this.tb_EditColumnMapIdentifier.TabIndex = 0;
			// 
			// btn_EditColumnMapClear
			// 
			this.btn_EditColumnMapClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_EditColumnMapClear.Location = new System.Drawing.Point(350, 3);
			this.btn_EditColumnMapClear.Name = "btn_EditColumnMapClear";
			this.btn_EditColumnMapClear.Size = new System.Drawing.Size(149, 26);
			this.btn_EditColumnMapClear.TabIndex = 3;
			this.btn_EditColumnMapClear.Text = "Reset Changes";
			this.btn_EditColumnMapClear.UseVisualStyleBackColor = true;
			// 
			// btn_EditColumnMap
			// 
			this.btn_EditColumnMap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_EditColumnMap.Location = new System.Drawing.Point(505, 3);
			this.btn_EditColumnMap.Name = "btn_EditColumnMap";
			this.btn_EditColumnMap.Size = new System.Drawing.Size(149, 26);
			this.btn_EditColumnMap.TabIndex = 2;
			this.btn_EditColumnMap.Text = "Save Changes";
			this.btn_EditColumnMap.UseVisualStyleBackColor = true;
			// 
			// tp_Import
			// 
			this.tp_Import.Controls.Add(this.gb_TestData);
			this.tp_Import.Controls.Add(this.gb_ImportColumns);
			this.tp_Import.Location = new System.Drawing.Point(4, 22);
			this.tp_Import.Name = "tp_Import";
			this.tp_Import.Size = new System.Drawing.Size(976, 598);
			this.tp_Import.TabIndex = 2;
			this.tp_Import.Text = "CSV File Import";
			this.tp_Import.UseVisualStyleBackColor = true;
			// 
			// gb_TestData
			// 
			this.gb_TestData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gb_TestData.Controls.Add(this.dgv_TestData);
			this.gb_TestData.Location = new System.Drawing.Point(8, 283);
			this.gb_TestData.Name = "gb_TestData";
			this.gb_TestData.Size = new System.Drawing.Size(960, 312);
			this.gb_TestData.TabIndex = 4;
			this.gb_TestData.TabStop = false;
			this.gb_TestData.Text = "Test Data loaded from Import file";
			// 
			// dgv_TestData
			// 
			this.dgv_TestData.AllowUserToAddRows = false;
			this.dgv_TestData.AllowUserToDeleteRows = false;
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgv_TestData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
			this.dgv_TestData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgv_TestData.DefaultCellStyle = dataGridViewCellStyle8;
			this.dgv_TestData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgv_TestData.Location = new System.Drawing.Point(3, 16);
			this.dgv_TestData.Name = "dgv_TestData";
			this.dgv_TestData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgv_TestData.Size = new System.Drawing.Size(954, 293);
			this.dgv_TestData.TabIndex = 2;
			// 
			// gb_ImportColumns
			// 
			this.gb_ImportColumns.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gb_ImportColumns.Controls.Add(this.btn_SaveImportTemplate);
			this.gb_ImportColumns.Controls.Add(this.sc_ImportColumnMapping);
			this.gb_ImportColumns.Controls.Add(this.btn_FileRescan);
			this.gb_ImportColumns.Controls.Add(this.btn_ImportFile);
			this.gb_ImportColumns.Controls.Add(this.btn_SaveColumnMapUpdates);
			this.gb_ImportColumns.Location = new System.Drawing.Point(8, 3);
			this.gb_ImportColumns.Name = "gb_ImportColumns";
			this.gb_ImportColumns.Size = new System.Drawing.Size(960, 274);
			this.gb_ImportColumns.TabIndex = 3;
			this.gb_ImportColumns.TabStop = false;
			this.gb_ImportColumns.Text = "Columns Detected from Import File";
			// 
			// btn_SaveImportTemplate
			// 
			this.btn_SaveImportTemplate.Location = new System.Drawing.Point(454, 245);
			this.btn_SaveImportTemplate.Name = "btn_SaveImportTemplate";
			this.btn_SaveImportTemplate.Size = new System.Drawing.Size(151, 23);
			this.btn_SaveImportTemplate.TabIndex = 8;
			this.btn_SaveImportTemplate.Text = "Save Import As Template";
			this.btn_SaveImportTemplate.UseVisualStyleBackColor = true;
			// 
			// sc_ImportColumnMapping
			// 
			this.sc_ImportColumnMapping.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.sc_ImportColumnMapping.Location = new System.Drawing.Point(6, 19);
			this.sc_ImportColumnMapping.Name = "sc_ImportColumnMapping";
			// 
			// sc_ImportColumnMapping.Panel1
			// 
			this.sc_ImportColumnMapping.Panel1.Controls.Add(this.gb_UnmappedColumns);
			// 
			// sc_ImportColumnMapping.Panel2
			// 
			this.sc_ImportColumnMapping.Panel2.Controls.Add(this.gb_MappedColumns);
			this.sc_ImportColumnMapping.Size = new System.Drawing.Size(948, 223);
			this.sc_ImportColumnMapping.SplitterDistance = 444;
			this.sc_ImportColumnMapping.TabIndex = 7;
			// 
			// gb_UnmappedColumns
			// 
			this.gb_UnmappedColumns.Controls.Add(this.dgv_UnmappedColumns);
			this.gb_UnmappedColumns.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gb_UnmappedColumns.Location = new System.Drawing.Point(0, 0);
			this.gb_UnmappedColumns.Name = "gb_UnmappedColumns";
			this.gb_UnmappedColumns.Size = new System.Drawing.Size(444, 223);
			this.gb_UnmappedColumns.TabIndex = 0;
			this.gb_UnmappedColumns.TabStop = false;
			this.gb_UnmappedColumns.Text = "Unmapped Columns";
			// 
			// dgv_UnmappedColumns
			// 
			this.dgv_UnmappedColumns.AllowUserToAddRows = false;
			this.dgv_UnmappedColumns.AllowUserToOrderColumns = true;
			this.dgv_UnmappedColumns.AllowUserToResizeRows = false;
			dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgv_UnmappedColumns.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
			this.dgv_UnmappedColumns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgv_UnmappedColumns.DefaultCellStyle = dataGridViewCellStyle10;
			this.dgv_UnmappedColumns.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgv_UnmappedColumns.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
			this.dgv_UnmappedColumns.Location = new System.Drawing.Point(3, 16);
			this.dgv_UnmappedColumns.MultiSelect = false;
			this.dgv_UnmappedColumns.Name = "dgv_UnmappedColumns";
			this.dgv_UnmappedColumns.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.dgv_UnmappedColumns.Size = new System.Drawing.Size(438, 204);
			this.dgv_UnmappedColumns.TabIndex = 0;
			// 
			// gb_MappedColumns
			// 
			this.gb_MappedColumns.Controls.Add(this.dgv_MappedColumns);
			this.gb_MappedColumns.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gb_MappedColumns.Location = new System.Drawing.Point(0, 0);
			this.gb_MappedColumns.Name = "gb_MappedColumns";
			this.gb_MappedColumns.Size = new System.Drawing.Size(500, 223);
			this.gb_MappedColumns.TabIndex = 1;
			this.gb_MappedColumns.TabStop = false;
			this.gb_MappedColumns.Text = "Mapped Columns";
			// 
			// dgv_MappedColumns
			// 
			this.dgv_MappedColumns.AllowUserToAddRows = false;
			this.dgv_MappedColumns.AllowUserToDeleteRows = false;
			this.dgv_MappedColumns.AllowUserToResizeRows = false;
			this.dgv_MappedColumns.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgv_MappedColumns.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgv_MappedColumns.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
			this.dgv_MappedColumns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgv_MappedColumns.DefaultCellStyle = dataGridViewCellStyle12;
			this.dgv_MappedColumns.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgv_MappedColumns.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.dgv_MappedColumns.Location = new System.Drawing.Point(3, 16);
			this.dgv_MappedColumns.MultiSelect = false;
			this.dgv_MappedColumns.Name = "dgv_MappedColumns";
			this.dgv_MappedColumns.ReadOnly = true;
			this.dgv_MappedColumns.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgv_MappedColumns.Size = new System.Drawing.Size(494, 204);
			this.dgv_MappedColumns.TabIndex = 0;
			this.dgv_MappedColumns.VirtualMode = true;
			// 
			// btn_FileRescan
			// 
			this.btn_FileRescan.Location = new System.Drawing.Point(6, 245);
			this.btn_FileRescan.Name = "btn_FileRescan";
			this.btn_FileRescan.Size = new System.Drawing.Size(151, 23);
			this.btn_FileRescan.TabIndex = 6;
			this.btn_FileRescan.Text = "Rescan File";
			this.btn_FileRescan.UseVisualStyleBackColor = true;
			this.btn_FileRescan.Click += new System.EventHandler(this.btn_FileRescan_Click);
			// 
			// btn_ImportFile
			// 
			this.btn_ImportFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_ImportFile.Location = new System.Drawing.Point(803, 245);
			this.btn_ImportFile.Name = "btn_ImportFile";
			this.btn_ImportFile.Size = new System.Drawing.Size(151, 23);
			this.btn_ImportFile.TabIndex = 1;
			this.btn_ImportFile.Text = "Import Selected File";
			this.btn_ImportFile.UseVisualStyleBackColor = true;
			this.btn_ImportFile.Click += new System.EventHandler(this.btn_ImportFile_Click);
			// 
			// btn_SaveColumnMapUpdates
			// 
			this.btn_SaveColumnMapUpdates.Location = new System.Drawing.Point(163, 245);
			this.btn_SaveColumnMapUpdates.Name = "btn_SaveColumnMapUpdates";
			this.btn_SaveColumnMapUpdates.Size = new System.Drawing.Size(151, 23);
			this.btn_SaveColumnMapUpdates.TabIndex = 5;
			this.btn_SaveColumnMapUpdates.Text = "Save Column Map Updates";
			this.btn_SaveColumnMapUpdates.UseVisualStyleBackColor = true;
			this.btn_SaveColumnMapUpdates.Click += new System.EventHandler(this.btn_SaveColumnMapUpdates_Click);
			// 
			// ms_Main
			// 
			this.ms_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
			this.ms_Main.Location = new System.Drawing.Point(0, 0);
			this.ms_Main.Name = "ms_Main";
			this.ms_Main.Size = new System.Drawing.Size(1008, 24);
			this.ms_Main.TabIndex = 1;
			this.ms_Main.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshServerListToolStripMenuItem,
            this.exitApplicationToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// refreshServerListToolStripMenuItem
			// 
			this.refreshServerListToolStripMenuItem.Name = "refreshServerListToolStripMenuItem";
			this.refreshServerListToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
			this.refreshServerListToolStripMenuItem.Text = "Refresh Server List";
			this.refreshServerListToolStripMenuItem.Click += new System.EventHandler(this.refreshServerListToolStripMenuItem_Click);
			// 
			// exitApplicationToolStripMenuItem
			// 
			this.exitApplicationToolStripMenuItem.Name = "exitApplicationToolStripMenuItem";
			this.exitApplicationToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
			this.exitApplicationToolStripMenuItem.Text = "Exit Application";
			this.exitApplicationToolStripMenuItem.Click += new System.EventHandler(this.exitApplicationToolStripMenuItem_Click);
			// 
			// stsr_Main
			// 
			this.stsr_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsp_Progress,
            this.tssl_Status});
			this.stsr_Main.Location = new System.Drawing.Point(0, 707);
			this.stsr_Main.Name = "stsr_Main";
			this.stsr_Main.Size = new System.Drawing.Size(1008, 22);
			this.stsr_Main.TabIndex = 2;
			this.stsr_Main.Text = "ststr_Main";
			// 
			// tsp_Progress
			// 
			this.tsp_Progress.AutoToolTip = true;
			this.tsp_Progress.Name = "tsp_Progress";
			this.tsp_Progress.Size = new System.Drawing.Size(100, 16);
			this.tsp_Progress.Step = 1;
			// 
			// tssl_Status
			// 
			this.tssl_Status.Name = "tssl_Status";
			this.tssl_Status.Size = new System.Drawing.Size(157, 17);
			this.tssl_Status.Text = "Status messages will go here";
			// 
			// ofd_ImportFile
			// 
			this.ofd_ImportFile.Filter = "Comma-Separated Values|*.csv";
			this.ofd_ImportFile.Title = "Select a Comma-Separated Value File";
			// 
			// gb_ImportTemplateSelection
			// 
			this.gb_ImportTemplateSelection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gb_ImportTemplateSelection.Controls.Add(this.lbl_SelectImportTemplate);
			this.gb_ImportTemplateSelection.Controls.Add(this.ddl_ImportTemplate);
			this.gb_ImportTemplateSelection.Location = new System.Drawing.Point(12, 27);
			this.gb_ImportTemplateSelection.Name = "gb_ImportTemplateSelection";
			this.gb_ImportTemplateSelection.Size = new System.Drawing.Size(984, 47);
			this.gb_ImportTemplateSelection.TabIndex = 12;
			this.gb_ImportTemplateSelection.TabStop = false;
			this.gb_ImportTemplateSelection.Text = "Import Template Selection";
			// 
			// lbl_SelectImportTemplate
			// 
			this.lbl_SelectImportTemplate.AutoSize = true;
			this.lbl_SelectImportTemplate.Location = new System.Drawing.Point(8, 22);
			this.lbl_SelectImportTemplate.Name = "lbl_SelectImportTemplate";
			this.lbl_SelectImportTemplate.Size = new System.Drawing.Size(192, 13);
			this.lbl_SelectImportTemplate.TabIndex = 1;
			this.lbl_SelectImportTemplate.Text = "Select Pre-Configured Import Template:";
			// 
			// ddl_ImportTemplate
			// 
			this.ddl_ImportTemplate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ddl_ImportTemplate.FormattingEnabled = true;
			this.ddl_ImportTemplate.Location = new System.Drawing.Point(203, 19);
			this.ddl_ImportTemplate.Name = "ddl_ImportTemplate";
			this.ddl_ImportTemplate.Size = new System.Drawing.Size(775, 21);
			this.ddl_ImportTemplate.TabIndex = 0;
			// 
			// frm_Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1008, 729);
			this.Controls.Add(this.gb_ImportTemplateSelection);
			this.Controls.Add(this.stsr_Main);
			this.Controls.Add(this.tc_Main);
			this.Controls.Add(this.ms_Main);
			this.MainMenuStrip = this.ms_Main;
			this.Name = "frm_Main";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Emids - Experience Partnership - Spec Editor Proof of Concept";
			this.Load += new System.EventHandler(this.frm_Main_Load);
			this.Shown += new System.EventHandler(this.frm_Main_Shown);
			this.tc_Main.ResumeLayout(false);
			this.tp_ClientAdministration.ResumeLayout(false);
			this.gb_ClientAdministration.ResumeLayout(false);
			this.sc_ClientAdministration.Panel1.ResumeLayout(false);
			this.sc_ClientAdministration.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.sc_ClientAdministration)).EndInit();
			this.sc_ClientAdministration.ResumeLayout(false);
			this.gb_ClientList.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgv_Client)).EndInit();
			this.sc_ClientModification.Panel1.ResumeLayout(false);
			this.sc_ClientModification.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.sc_ClientModification)).EndInit();
			this.sc_ClientModification.ResumeLayout(false);
			this.gb_AddClient.ResumeLayout(false);
			this.gb_AddClient.PerformLayout();
			this.gb_EditClient.ResumeLayout(false);
			this.gb_EditClient.PerformLayout();
			this.tp_ImportConfiguration.ResumeLayout(false);
			this.gb_SQLCredentialsClientSelection.ResumeLayout(false);
			this.sc_SQLCredentialsClientSelection.Panel1.ResumeLayout(false);
			this.sc_SQLCredentialsClientSelection.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.sc_SQLCredentialsClientSelection)).EndInit();
			this.sc_SQLCredentialsClientSelection.ResumeLayout(false);
			this.gb_UserConfiguration.ResumeLayout(false);
			this.gb_UserConfiguration.PerformLayout();
			this.gb_ClientSelect.ResumeLayout(false);
			this.gb_FileSelection.ResumeLayout(false);
			this.gb_FileSelection.PerformLayout();
			this.gb_SQLObjectSelection.ResumeLayout(false);
			this.sc_DestinationSelection.Panel1.ResumeLayout(false);
			this.sc_DestinationSelection.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.sc_DestinationSelection)).EndInit();
			this.sc_DestinationSelection.ResumeLayout(false);
			this.sc_ServerDatabaseSelection.Panel1.ResumeLayout(false);
			this.sc_ServerDatabaseSelection.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.sc_ServerDatabaseSelection)).EndInit();
			this.sc_ServerDatabaseSelection.ResumeLayout(false);
			this.gb_ServerSelection.ResumeLayout(false);
			this.gb_DatabaseSelection.ResumeLayout(false);
			this.sc_SchemaTableSelection.Panel1.ResumeLayout(false);
			this.sc_SchemaTableSelection.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.sc_SchemaTableSelection)).EndInit();
			this.sc_SchemaTableSelection.ResumeLayout(false);
			this.gb_SchemaSelection.ResumeLayout(false);
			this.gb_TableSelection.ResumeLayout(false);
			this.tp_SchemaAdmin.ResumeLayout(false);
			this.gb_Column.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgv_Columns)).EndInit();
			this.tp_ColumnMapping.ResumeLayout(false);
			this.gb_ColumnImportMapping.ResumeLayout(false);
			this.sc_ColumnImports.Panel1.ResumeLayout(false);
			this.sc_ColumnImports.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.sc_ColumnImports)).EndInit();
			this.sc_ColumnImports.ResumeLayout(false);
			this.gb_ColumnMapList.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgv_ColumnMap)).EndInit();
			this.sc_ColumnMappingInformation.Panel1.ResumeLayout(false);
			this.sc_ColumnMappingInformation.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.sc_ColumnMappingInformation)).EndInit();
			this.sc_ColumnMappingInformation.ResumeLayout(false);
			this.gb_AddColumnMap.ResumeLayout(false);
			this.sc_AddColumnMapping.Panel1.ResumeLayout(false);
			this.sc_AddColumnMapping.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.sc_AddColumnMapping)).EndInit();
			this.sc_AddColumnMapping.ResumeLayout(false);
			this.sc_AddColumnMappingInformation.Panel1.ResumeLayout(false);
			this.sc_AddColumnMappingInformation.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.sc_AddColumnMappingInformation)).EndInit();
			this.sc_AddColumnMappingInformation.ResumeLayout(false);
			this.gb_AddColumnMapSelection.ResumeLayout(false);
			this.gb_MapNewIdentifier.ResumeLayout(false);
			this.gb_MapNewIdentifier.PerformLayout();
			this.gb_EditColumnMap.ResumeLayout(false);
			this.sc_EditColumnMapping.Panel1.ResumeLayout(false);
			this.sc_EditColumnMapping.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.sc_EditColumnMapping)).EndInit();
			this.sc_EditColumnMapping.ResumeLayout(false);
			this.sc_EditColumnMappingInformation.Panel1.ResumeLayout(false);
			this.sc_EditColumnMappingInformation.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.sc_EditColumnMappingInformation)).EndInit();
			this.sc_EditColumnMappingInformation.ResumeLayout(false);
			this.gb_EditColumnMapColumn.ResumeLayout(false);
			this.gb_EditColumnMapIdentifier.ResumeLayout(false);
			this.gb_EditColumnMapIdentifier.PerformLayout();
			this.tp_Import.ResumeLayout(false);
			this.gb_TestData.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgv_TestData)).EndInit();
			this.gb_ImportColumns.ResumeLayout(false);
			this.sc_ImportColumnMapping.Panel1.ResumeLayout(false);
			this.sc_ImportColumnMapping.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.sc_ImportColumnMapping)).EndInit();
			this.sc_ImportColumnMapping.ResumeLayout(false);
			this.gb_UnmappedColumns.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgv_UnmappedColumns)).EndInit();
			this.gb_MappedColumns.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgv_MappedColumns)).EndInit();
			this.ms_Main.ResumeLayout(false);
			this.ms_Main.PerformLayout();
			this.stsr_Main.ResumeLayout(false);
			this.stsr_Main.PerformLayout();
			this.gb_ImportTemplateSelection.ResumeLayout(false);
			this.gb_ImportTemplateSelection.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tc_Main;
        private System.Windows.Forms.TabPage tp_SchemaAdmin;
        private System.Windows.Forms.TabPage tp_ColumnMapping;
        private System.Windows.Forms.MenuStrip ms_Main;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitApplicationToolStripMenuItem;
        private System.Windows.Forms.StatusStrip stsr_Main;
        private System.Windows.Forms.ToolStripProgressBar tsp_Progress;
        private System.Windows.Forms.ToolStripStatusLabel tssl_Status;
        private System.Windows.Forms.TabPage tp_Import;
        private System.Windows.Forms.TextBox tb_SelectedFile;
        private System.Windows.Forms.Button btn_SelectFile;
        private System.Windows.Forms.GroupBox gb_TableSelection;
        private System.Windows.Forms.ComboBox ddl_Table;
        private System.Windows.Forms.GroupBox gb_DatabaseSelection;
        private System.Windows.Forms.ComboBox ddl_Database;
        private System.Windows.Forms.GroupBox gb_ServerSelection;
        private System.Windows.Forms.ComboBox ddl_Server;
        private System.Windows.Forms.GroupBox gb_Column;
        private System.Windows.Forms.GroupBox gb_SQLObjectSelection;
        private System.Windows.Forms.GroupBox gb_SchemaSelection;
        private System.Windows.Forms.ComboBox ddl_Schema;
        private System.Windows.Forms.GroupBox gb_UserConfiguration;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.TextBox tb_Username;
        private System.Windows.Forms.Label lbl_Username;
		private System.Windows.Forms.GroupBox gb_ClientSelect;
		private System.Windows.Forms.ComboBox ddl_Client;
		private System.Windows.Forms.GroupBox gb_FileSelection;
		private System.Windows.Forms.DataGridView dgv_Columns;
		private System.Windows.Forms.GroupBox gb_ColumnMapList;
		private System.Windows.Forms.DataGridView dgv_ColumnMap;
		private System.Windows.Forms.TabPage tp_ClientAdministration;
		private System.Windows.Forms.GroupBox gb_ClientList;
		private System.Windows.Forms.DataGridView dgv_Client;
		private System.Windows.Forms.Button btn_EditClient;
		private System.Windows.Forms.Button btn_EditClientReset;
		private System.Windows.Forms.TextBox tb_EditClientDescription;
		private System.Windows.Forms.Label lbl_EditClientDescription;
		private System.Windows.Forms.TextBox tb_EditClientName;
		private System.Windows.Forms.Label lbl_EditClientName;
		private System.Windows.Forms.GroupBox gb_AddColumnMap;
		private System.Windows.Forms.Button btn_AddColumnMapClear;
		private System.Windows.Forms.Button btn_AddColumnMap;
		private System.Windows.Forms.GroupBox gb_MapNewIdentifier;
		private System.Windows.Forms.TextBox tb_AddColumnMapIdentifier;
		private System.Windows.Forms.GroupBox gb_AddColumnMapSelection;
		private System.Windows.Forms.ComboBox ddl_AddColumnMapColumn;
		private System.Windows.Forms.GroupBox gb_EditClient;
		private System.Windows.Forms.GroupBox gb_AddClient;
		private System.Windows.Forms.TextBox tb_AddClientName;
		private System.Windows.Forms.Button btn_AddClient;
		private System.Windows.Forms.Label lbl_AddClientName;
		private System.Windows.Forms.Button btn_AddClientClear;
		private System.Windows.Forms.Label lbl_AddClientDescription;
		private System.Windows.Forms.TextBox tb_AddClientDescription;
		private System.Windows.Forms.OpenFileDialog ofd_ImportFile;
		private System.Windows.Forms.Button btn_ImportFile;
		private System.Windows.Forms.GroupBox gb_EditColumnMap;
		private System.Windows.Forms.Button btn_EditColumnMapClear;
		private System.Windows.Forms.Button btn_EditColumnMap;
		private System.Windows.Forms.GroupBox gb_EditColumnMapIdentifier;
		private System.Windows.Forms.TextBox tb_EditColumnMapIdentifier;
		private System.Windows.Forms.GroupBox gb_EditColumnMapColumn;
		private System.Windows.Forms.ComboBox ddl_EditColumnMapColumn;
		private System.Windows.Forms.GroupBox gb_ImportColumns;
		private System.Windows.Forms.ToolStripMenuItem refreshServerListToolStripMenuItem;
		private System.Windows.Forms.GroupBox gb_TestData;
		private System.Windows.Forms.DataGridView dgv_TestData;
		private System.Windows.Forms.Button btn_SaveColumnMapUpdates;
		private System.Windows.Forms.Button btn_FileRescan;
		private System.Windows.Forms.GroupBox gb_MappedColumns;
		private System.Windows.Forms.GroupBox gb_UnmappedColumns;
		private System.Windows.Forms.DataGridView dgv_UnmappedColumns;
		private System.Windows.Forms.DataGridView dgv_MappedColumns;
		private System.Windows.Forms.CheckBox ckb_HasHeader;
		private System.Windows.Forms.GroupBox gb_ImportTemplateSelection;
		private System.Windows.Forms.Label lbl_SelectImportTemplate;
		private System.Windows.Forms.ComboBox ddl_ImportTemplate;
		private System.Windows.Forms.Button btn_SaveImportTemplate;
		private System.Windows.Forms.SplitContainer sc_ImportColumnMapping;
		private System.Windows.Forms.TabPage tp_ImportConfiguration;
		private System.Windows.Forms.Button btn_RefreshSqlObjects;
		private System.Windows.Forms.SplitContainer sc_DestinationSelection;
		private System.Windows.Forms.SplitContainer sc_ServerDatabaseSelection;
		private System.Windows.Forms.SplitContainer sc_SchemaTableSelection;
		private System.Windows.Forms.GroupBox gb_SQLCredentialsClientSelection;
		private System.Windows.Forms.SplitContainer sc_SQLCredentialsClientSelection;
		private System.Windows.Forms.SplitContainer sc_ClientAdministration;
		private System.Windows.Forms.SplitContainer sc_ClientModification;
		private System.Windows.Forms.GroupBox gb_ClientAdministration;
		private System.Windows.Forms.GroupBox gb_ColumnImportMapping;
		private System.Windows.Forms.SplitContainer sc_ColumnImports;
		private System.Windows.Forms.SplitContainer sc_ColumnMappingInformation;
		private System.Windows.Forms.SplitContainer sc_AddColumnMapping;
		private System.Windows.Forms.SplitContainer sc_AddColumnMappingInformation;
		private System.Windows.Forms.SplitContainer sc_EditColumnMapping;
		private System.Windows.Forms.SplitContainer sc_EditColumnMappingInformation;
	}
}

