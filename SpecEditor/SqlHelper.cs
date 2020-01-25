using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Microsoft.SqlServer.Types;
using SpecEditor.Models;
using SpecEditor.Models.Binding;
using SpecEditor.Models.Context;

namespace SpecEditor
{
    public class SqlHelper
    {
        #region ColumnCast Collection

        public readonly ColumnCast[] DefaultColumnCasts =
        {
            new ColumnCast
            {
                SystemTypeID = 127,
                UserTypeID = 127,
                SQLTypeName = "BIGINT",
                CLRTypeName = "SqlInt64",
                DotNetTypeName = "System.Int64",
                MaxLength = 8,
                Precision = 19,
                Scale = 0,
                IsNullable = true
            },
            new ColumnCast
            {
                SystemTypeID = 173,
                UserTypeID = 173,
                SQLTypeName = "BINARY",
                CLRTypeName = "SqlBinary",
                DotNetTypeName = "System.Byte[]",
                MaxLength = 8000,
                Precision = 0,
                Scale = 0,
                IsNullable = true
            },
            new ColumnCast
            {
                SystemTypeID = 104,
                UserTypeID = 104,
                SQLTypeName = "BIT",
                CLRTypeName = "SqlBoolean",
                DotNetTypeName = "System.Boolean",
                MaxLength = 1,
                Precision = 1,
                Scale = 0,
                IsNullable = true
            },
            new ColumnCast
            {
                SystemTypeID = 175,
                UserTypeID = 175,
                SQLTypeName = "CHAR",
                CLRTypeName = "SqlChars",
                DotNetTypeName = "System.Char[]",
                MaxLength = 8000,
                Precision = 0,
                Scale = 0,
                IsNullable = true
            },
            new ColumnCast
            {
                SystemTypeID = 40,
                UserTypeID = 40,
                SQLTypeName = "DATE",
                CLRTypeName = "SqlDateTime",
                DotNetTypeName = "System.DateTime",
                MaxLength = 3,
                Precision = 10,
                Scale = 0,
                IsNullable = true
            },
            new ColumnCast
            {
                SystemTypeID = 61,
                UserTypeID = 61,
                SQLTypeName = "DATETIME",
                CLRTypeName = "SqlDateTime",
                DotNetTypeName = "System.DateTime",
                MaxLength = 8,
                Precision = 23,
                Scale = 3,
                IsNullable = true
            },
            new ColumnCast
            {
                SystemTypeID = 42,
                UserTypeID = 42,
                SQLTypeName = "DATETIME2",
                CLRTypeName = null,
                DotNetTypeName = "System.DateTime",
                MaxLength = 8,
                Precision = 27,
                Scale = 7,
                IsNullable = true
            },
            new ColumnCast
            {
                SystemTypeID = 43,
                UserTypeID = 43,
                SQLTypeName = "DATETIMEOFFSET",
                CLRTypeName = null,
                DotNetTypeName = "System.DateTimeOffset",
                MaxLength = 10,
                Precision = 34,
                Scale = 7,
                IsNullable = true
            },
            new ColumnCast
            {
                SystemTypeID = 106,
                UserTypeID = 106,
                SQLTypeName = "DECIMAL",
                CLRTypeName = "SqlDecimal",
                DotNetTypeName = "System.Decimal",
                MaxLength = 17,
                Precision = 38,
                Scale = 38,
                IsNullable = true
            },
            new ColumnCast
            {
                SystemTypeID = 62,
                UserTypeID = 62,
                SQLTypeName = "FLOAT",
                CLRTypeName = "SqlDouble",
                DotNetTypeName = "System.Double",
                MaxLength = 8,
                Precision = 53,
                Scale = 0,
                IsNullable = true
            },
            new ColumnCast
            {
                SystemTypeID = 240,
                UserTypeID = 130,
                SQLTypeName = "GEOGRAPHY",
                CLRTypeName = "DbGeography",
                DotNetTypeName = "Microsoft.SqlServer.Types.SqlGeography",
                MaxLength = -1,
                Precision = 0,
                Scale = 0,
                IsNullable = true
            },
            new ColumnCast
            {
                SystemTypeID = 240,
                UserTypeID = 129,
                SQLTypeName = "GEOMETRY",
                CLRTypeName = "DbGeometry",
                DotNetTypeName = "Microsoft.SqlServer.Types.SqlGeometry",
                MaxLength = -1,
                Precision = 0,
                Scale = 0,
                IsNullable = true
            },
            new ColumnCast
            {
                SystemTypeID = 240,
                UserTypeID = 128,
                SQLTypeName = "HIERARCHYID",
                CLRTypeName = "DbHierarchyId",
                DotNetTypeName = "Microsoft.SqlServer.Types.SqlHierarchyId",
                MaxLength = 892,
                Precision = 0,
                Scale = 0,
                IsNullable = true
            },
            new ColumnCast
            {
                SystemTypeID = 34,
                UserTypeID = 34,
                SQLTypeName = "IMAGE",
                CLRTypeName = null,
                DotNetTypeName = "System.Byte[]",
                MaxLength = 16,
                Precision = 0,
                Scale = 0,
                IsNullable = true
            },
            new ColumnCast
            {
                SystemTypeID = 56,
                UserTypeID = 56,
                SQLTypeName = "INT",
                CLRTypeName = "SqlInt32",
                DotNetTypeName = "System.Int32",
                MaxLength = 4,
                Precision = 10,
                Scale = 0,
                IsNullable = true
            },
            new ColumnCast
            {
                SystemTypeID = 60,
                UserTypeID = 60,
                SQLTypeName = "MONEY",
                CLRTypeName = "SqlDecimal",
                DotNetTypeName = "System.Decimal",
                MaxLength = 8,
                Precision = 19,
                Scale = 4,
                IsNullable = true
            },
            new ColumnCast
            {
                SystemTypeID = 239,
                UserTypeID = 239,
                SQLTypeName = "NCHAR",
                CLRTypeName = "SqlChars",
                DotNetTypeName = "System.String",
                MaxLength = 8000,
                Precision = 0,
                Scale = 0,
                IsNullable = true
            },
            new ColumnCast
            {
                SystemTypeID = 99,
                UserTypeID = 99,
                SQLTypeName = "NTEXT",
                CLRTypeName = "SqlString",
                DotNetTypeName = "System.String",
                MaxLength = 16,
                Precision = 0,
                Scale = 0,
                IsNullable = true
            },
            new ColumnCast
            {
                SystemTypeID = 108,
                UserTypeID = 108,
                SQLTypeName = "NUMERIC",
                CLRTypeName = "decimal",
                DotNetTypeName = "System.Decimal",
                MaxLength = 17,
                Precision = 38,
                Scale = 38,
                IsNullable = true
            },
            new ColumnCast
            {
                SystemTypeID = 231,
                UserTypeID = 231,
                SQLTypeName = "NVARCHAR",
                CLRTypeName = "SqlString",
                DotNetTypeName = "System.String",
                MaxLength = 8000,
                Precision = 0,
                Scale = 0,
                IsNullable = true
            },
            new ColumnCast
            {
                SystemTypeID = 59,
                UserTypeID = 59,
                SQLTypeName = "REAL",
                CLRTypeName = "SqlSingle",
                DotNetTypeName = "System.Single",
                MaxLength = 4,
                Precision = 24,
                Scale = 0,
                IsNullable = true
            },
            new ColumnCast
            {
                SystemTypeID = 58,
                UserTypeID = 58,
                SQLTypeName = "SMALLDATETIME",
                CLRTypeName = null,
                DotNetTypeName = "System.DateTime",
                MaxLength = 4,
                Precision = 16,
                Scale = 0,
                IsNullable = true
            },
            new ColumnCast
            {
                SystemTypeID = 52,
                UserTypeID = 52,
                SQLTypeName = "SMALLINT",
                CLRTypeName = "SqlShort",
                DotNetTypeName = "System.Short",
                MaxLength = 2,
                Precision = 5,
                Scale = 0,
                IsNullable = true
            },
            new ColumnCast
            {
                SystemTypeID = 122,
                UserTypeID = 122,
                SQLTypeName = "SMALLMONEY",
                CLRTypeName = "SqlDecimal",
                DotNetTypeName = "System.Decimal",
                MaxLength = 4,
                Precision = 10,
                Scale = 4,
                IsNullable = true
            },
            new ColumnCast
            {
                SystemTypeID = 98,
                UserTypeID = 98,
                SQLTypeName = "SQL_VARIANT",
                CLRTypeName = null,
                DotNetTypeName = "System.Object",
                MaxLength = 8016,
                Precision = 0,
                Scale = 0,
                IsNullable = true
            },
            new ColumnCast
            {
                SystemTypeID = 231,
                UserTypeID = 256,
                SQLTypeName = "SYSNAME",
                CLRTypeName = null,
                DotNetTypeName = "System.String",
                MaxLength = 256,
                Precision = 0,
                Scale = 0,
                IsNullable = false
            },
            new ColumnCast
            {
                SystemTypeID = 35,
                UserTypeID = 35,
                SQLTypeName = "TEXT",
                CLRTypeName = "SqlString",
                DotNetTypeName = "System.String",
                MaxLength = 16,
                Precision = 0,
                Scale = 0,
                IsNullable = true
            },
            new ColumnCast
            {
                SystemTypeID = 41,
                UserTypeID = 41,
                SQLTypeName = "TIME",
                CLRTypeName = null,
                DotNetTypeName = "System.TimeSpan",
                MaxLength = 5,
                Precision = 16,
                Scale = 7,
                IsNullable = true
            },
            new ColumnCast
            {
                SystemTypeID = 189,
                UserTypeID = 189,
                SQLTypeName = "TIMESTAMP",
                CLRTypeName = "SqlInt64",
                DotNetTypeName = "System.Int64",
                MaxLength = 8,
                Precision = 0,
                Scale = 0,
                IsNullable = false
            },
            new ColumnCast
            {
                SystemTypeID = 48,
                UserTypeID = 48,
                SQLTypeName = "TINYINT",
                CLRTypeName = "SqlByte",
                DotNetTypeName = "System.Byte",
                MaxLength = 1,
                Precision = 3,
                Scale = 0,
                IsNullable = true
            },
            new ColumnCast
            {
                SystemTypeID = 36,
                UserTypeID = 36,
                SQLTypeName = "UNIQUEIDENTIFIER",
                CLRTypeName = "SqlGuid",
                DotNetTypeName = "System.Guid",
                MaxLength = 16,
                Precision = 0,
                Scale = 0,
                IsNullable = true
            },
            new ColumnCast
            {
                SystemTypeID = 165,
                UserTypeID = 165,
                SQLTypeName = "VARBINARY",
                CLRTypeName = "SqlBinary",
                DotNetTypeName = "System.Byte[]",
                MaxLength = 8000,
                Precision = 0,
                Scale = 0,
                IsNullable = true
            },
            new ColumnCast
            {
                SystemTypeID = 167,
                UserTypeID = 167,
                SQLTypeName = "VARCHAR",
                CLRTypeName = "SqlString",
                DotNetTypeName = "System.String",
                MaxLength = 8000,
                Precision = 0,
                Scale = 0,
                IsNullable = true
            },
            new ColumnCast
            {
                SystemTypeID = 241,
                UserTypeID = 241,
                SQLTypeName = "XML",
                CLRTypeName = "SqlXml",
                DotNetTypeName = "System.Xml.XmlDocument",
                MaxLength = -1,
                Precision = 0,
                Scale = 0,
                IsNullable = true
            }
        };

        #endregion

        #region String Constants

        public const string ConnectionStringTemplate =
            "Data Source={0};Initial Catalog={1};Integrated Security=True;App=Spec Editor;";

        public const string LoginConnectionStringTemplate =
            "Data Source={0};Initial Catalog={1};User ID={2};Password={3};App=Spec Editor;";

        public const string ColumnCastRetrievalQuery = "SELECT A.system_type_id AS SystemTypeID, A.user_type_id AS UserTypeID, UPPER(A.[name]) AS SQLTypeName, A.[name] AS CLRTypeName, A.[name] AS NETTypeName, A.max_length AS [MaxLength], A.[precision] AS [Precision], A.scale AS Scale, A.is_nullable AS IsNullable FROM sys.types A ORDER BY A.[name]";

        public const string DatabaseRetrievalQuery =
            "SELECT A.[dbid] AS DatabaseID, A.name AS [Name] FROM sys.sysdatabases A WHERE A.[name] NOT IN ('master','tempdb','model','msdb','ReportServer','ReportServer$' + @@SERVICENAME, 'ReportServer$' + @@SERVICENAME + 'TempDB', 'DWDiagnostics', 'DWConfiguration', 'DWQueue')";

        public const string SchemaRetrievalQuery =
            "SELECT	A.[schema_id] AS [SchemaID], A.[name] AS [Name] FROM sys.schemas A";

        public const string TableRetrievalQuery = "SELECT A.[object_id] AS [ObjectID], A.[name] AS [Name] FROM sys.tables A WHERE A.[schema_id] = @SchemaID";

        public const string ColumnRetrievalQuery =
                "SELECT A.system_type_id AS [SystemTypeID], A.user_type_id AS [UserTypeID], A.column_id AS [Index], A.[name] AS [Name], A.max_length AS [MaxLength], A.[precision] AS [Precision], A.scale AS [Scale], A.is_nullable AS [IsNullable], CAST(ISNULL((SELECT 1 FROM sys.foreign_key_columns C WHERE C.[parent_object_id] = A.[object_id] AND C.parent_column_id = A.column_id), 0) AS BIT) AS IsLocked FROM sys.all_columns A INNER JOIN sys.all_objects B ON B.[object_id] = A.[object_id] WHERE A.[object_id] = @objectID AND A.is_computed = 0 AND A.is_identity = 0 ORDER BY A.[object_id] ASC, A.column_id ASC";

        public static readonly string[] BadStrings = { "001-01-01" };

        #endregion String Constants

        public static string DefaultUsername => ConfigurationManager.AppSettings["DefaultUsername"];
        public static string DefaultPassword => ConfigurationManager.AppSettings["DefaultPassword"];

        public string Username { get; set; } = DefaultUsername;
        public string Password { get; set; } = DefaultPassword;

        public List<string> Messages { get; set; }

        public SqlHelper()
        {
            Messages = new List<string>();
        }

        public string GetConnectionString(string hostName, string databaseName = null)
        {
            if (hostName.IsNullOrWhiteSpace())
                throw new ArgumentNullException(nameof(hostName), "The provided host name is invalid or empty.");

            databaseName = databaseName.IfNullOrWhiteSpace("master");

            string connectionStringTemplate = Username.IsNullOrWhiteSpace() || Password.IsNullOrWhiteSpace()
                ? ConnectionStringTemplate.FormatWith(hostName, databaseName)
                : LoginConnectionStringTemplate.FormatWith(hostName, databaseName, Username, Password);

            return connectionStringTemplate;
        }

        public void RefreshDatabase(SpecEditorContext db)
        {
            AddColumnCasts(db);
            AddServers(db);

            db.SaveChanges();

            foreach (Server server in db.Servers.ToArray())
                AddDatabases(db, server.ID, false);

            db.SaveChanges();

            foreach (Database database in db.Databases.ToArray())
                AddSchemata(db, database.ID, false);

            db.SaveChanges();

            foreach (Schema schema in db.Schemata.ToArray())
                AddTables(db, schema.ID, false);

            db.SaveChanges();

            foreach (Table table in db.Tables.ToArray())
                AddColumns(db, table.ID, false);

            db.SaveChanges();
        }

        public void AddColumnCasts(SpecEditorContext db, bool saveChanges = true)
        {
            IReadOnlyCollection<ColumnCast> allColumnCasts = db.ColumnCasts.ToArray();
            IReadOnlyCollection<ColumnCast> availableColumnCasts = DefaultColumnCasts;

            foreach (ColumnCast availableColumnCast in availableColumnCasts)
            {
                ColumnCast columnCast = allColumnCasts.FirstOrDefault(f =>
                    f.SystemTypeID == availableColumnCast.SystemTypeID && f.UserTypeID == availableColumnCast.UserTypeID);

                if (columnCast != null)
                    availableColumnCast.ID = columnCast.ID;
            }

            db.AddRecords(availableColumnCasts, true);
        }

        public void AddServers(SpecEditorContext db, bool saveChanges = true)
        {
            // First call to get servers that are already awake and to awaken sleeping servers
            SqlDataSourceEnumerator.Instance.GetDataSources();
            Thread.Sleep(1000);
            // Second call should get awoken servers as well as current servers.
            DataTable serversTable = SqlDataSourceEnumerator.Instance.GetDataSources();

            IReadOnlyCollection<Server> allServers = db.Servers.ToArray();
            IReadOnlyCollection<Server> availableServers =
                serversTable.PopulateCollection<Server>().OrderBy(o => o.HostName).ToArray();

            foreach (Server availableServer in availableServers)
            {
                availableServer.FirstSeen = availableServer.LastSeen = DateTime.UtcNow;
                Server server = allServers.FirstOrDefault(f =>
                    f.ServerName == availableServer.ServerName && f.InstanceName == availableServer.InstanceName);

                if (server != null)
                {
                    availableServer.ID = server.ID;
                    availableServer.FirstSeen = server.FirstSeen;
                }
            }

            db.AddRecords(availableServers, saveChanges);
        }

        public void AddDatabases(SpecEditorContext db, int serverID, bool saveChanges = true)
        {
            Server server = db.Servers.Find(serverID);

            if (server == null)
                return;

            string hostName = server.HostName;
            //string initialCatalog = "master"; // GetConnectionString will use master for the default catalog if no databaseName is passed.
            string connectionString = GetConnectionString(hostName);

            DataTable resultTable = new DataTable();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = DatabaseRetrievalQuery;

                    try
                    {
                        conn.Open();
                    }
                    catch (SqlException e)
                    {
                        Messages.Add(e.Message);
                        return;
                    }
                    catch (Exception e)
                    {
                        Messages.Add(e.Message);
                        MessageBox.Show(e.ToString());
                        throw;
                    }

                    SqlDataReader sdr = cmd.ExecuteReader();
                    resultTable.Load(sdr);

                    conn.Close();
                }
            }

            IReadOnlyCollection<Database> allDatabases = db.Databases.Where(w => w.ServerID == serverID).ToArray();
            IReadOnlyCollection<Database> availableDatabases =
                resultTable.PopulateCollection<Database>().OrderBy(o => o.DatabaseID).ToArray();

            foreach (Database availableDatabase in availableDatabases)
            {
                availableDatabase.ServerID = server.ID;
                availableDatabase.FirstSeen = availableDatabase.LastSeen = DateTime.UtcNow;
                Database database = allDatabases.FirstOrDefault(f =>
                    f.DatabaseID == availableDatabase.DatabaseID || f.Name == availableDatabase.Name);

                if (database != null)
                {
                    availableDatabase.ID = database.ID;
                    availableDatabase.FirstSeen = database.FirstSeen;
                }
            }

            db.AddRecords(availableDatabases, saveChanges);
        }

        public void AddSchemata(SpecEditorContext db, int databaseID, bool saveChanges = true)
        {
            Database database = db.Databases.Find(databaseID);

            if (database == null)
                return;

            string hostName = database.Server.HostName;
            string initialCatalog = database.Name;
            string connectionString = GetConnectionString(hostName, initialCatalog);

            DataTable resultTable = new DataTable();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = SchemaRetrievalQuery;

                    try
                    {
                        conn.Open();
                    }
                    catch (SqlException e)
                    {
                        Messages.Add(e.Message);
                        return;
                    }
                    catch (Exception e)
                    {
                        Messages.Add(e.Message);
                        MessageBox.Show(e.ToString());
                        throw;
                    }

                    SqlDataReader sdr = cmd.ExecuteReader();
                    resultTable.Load(sdr);

                    conn.Close();
                }
            }

            IReadOnlyCollection<Schema> allSchemata = db.Schemata.Where(w => w.DatabaseID == databaseID).ToArray();
            IReadOnlyCollection<Schema> availableSchemata =
                resultTable.PopulateCollection<Schema>().OrderBy(o => o.SchemaID).ToArray();

            foreach (Schema availableSchema in availableSchemata)
            {
                availableSchema.DatabaseID = databaseID;
                availableSchema.FirstSeen = availableSchema.LastSeen = DateTime.UtcNow;
                Schema schema =
                    allSchemata.FirstOrDefault(f => f.SchemaID == availableSchema.SchemaID || f.Name == availableSchema.Name);

                if (schema != null)
                {
                    availableSchema.ID = schema.ID;
                    availableSchema.FirstSeen = schema.FirstSeen;
                }
            }

            db.AddRecords(availableSchemata, saveChanges);
        }

        public void AddTables(SpecEditorContext db, int schemaID, bool saveChanges = true)
        {
            Schema schema = db.Schemata.Find(schemaID);

            if (schema == null)
                return;

            string hostName = schema.Database.Server.HostName;
            string initialCatalog = schema.Database.Name;
            string connectionString = GetConnectionString(hostName, initialCatalog);

            DataTable resultTable = new DataTable();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = TableRetrievalQuery;
                    cmd.Parameters.AddWithValue("SchemaID", schema.SchemaID);

                    try
                    {
                        conn.Open();
                    }
                    catch (SqlException e)
                    {
                        Messages.Add(e.Message);
                        return;
                    }
                    catch (Exception e)
                    {
                        Messages.Add(e.Message);
                        MessageBox.Show(e.ToString());
                        throw;
                    }

                    SqlDataReader sdr = cmd.ExecuteReader();
                    resultTable.Load(sdr);

                    conn.Close();
                }
            }

            IReadOnlyCollection<Table> allTables = db.Tables.Where(w => w.SchemaID == schemaID).ToArray();
            IReadOnlyCollection<Table> availableTables =
                resultTable.PopulateCollection<Table>().OrderBy(o => o.ObjectID).ToArray();

            foreach (Table availableTable in availableTables)
            {
                availableTable.SchemaID = schemaID;
                availableTable.FirstSeen = availableTable.LastSeen = DateTime.UtcNow;
                Table table = allTables.FirstOrDefault(f => f.Name == availableTable.Name);

                if (table != null)
                {
                    availableTable.ID = table.ID;
                    availableTable.FirstSeen = table.FirstSeen;
                }
            }

            db.AddRecords(availableTables, saveChanges);
        }

        public void AddColumns(SpecEditorContext db, int tableID, bool saveChanges = true)
        {
            Table table = db.Tables.Find(tableID);

            if (table == null)
                return;

            string hostName = table.Schema.Database.Server.HostName;
            string initialCatalog = table.Schema.Database.Name;
            string connectionString = GetConnectionString(hostName, initialCatalog);

            DataTable resultTable = new DataTable();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = ColumnRetrievalQuery;
                    cmd.Parameters.AddWithValue("objectID", table.ObjectID);

                    try
                    {
                        conn.Open();
                    }
                    catch (SqlException e)
                    {
                        Messages.Add(e.Message);
                        return;
                    }
                    catch (Exception e)
                    {
                        Messages.Add(e.Message);
                        MessageBox.Show(e.ToString());
                        throw;
                    }

                    SqlDataReader sdr = cmd.ExecuteReader();
                    resultTable.Load(sdr);

                    conn.Close();
                }
            }

            IReadOnlyCollection<Column> allColumns = db.Columns.Where(w => w.TableID == tableID).ToArray();
            IReadOnlyCollection<Column> availableColumns =
                resultTable.PopulateCollection<Column>().OrderBy(o => o.Index).ToArray();

            foreach (Column availableColumn in availableColumns)
            {
                availableColumn.TableID = tableID;
                availableColumn.FirstSeen = availableColumn.LastSeen = DateTime.UtcNow;
                Column column = allColumns.FirstOrDefault(f => f.Name == availableColumn.Name);

                if (column != null)
                {
                    availableColumn.ID = column.ID;
                    availableColumn.FirstSeen = column.FirstSeen;
                }
            }

            db.AddRecords(availableColumns, saveChanges);
        }

        public static DataTable BuildDataTable(Dictionary<string, ColumnMap> columns, Import import = null)
        {
            DataTable results = new DataTable("Results");

            if (import != null && import.ID > 0)
                results.Columns.Add("ImportID", typeof(int));

            foreach (KeyValuePair<string, ColumnMap> column in columns)
            {
                string name = column.Value.Column.Name;
                string typeName = column.Value.Column.ColumnCast.DotNetTypeName;
                Type type = Type.GetType(typeName) ?? typeof(object);

                results.Columns.Add(name, type);
            }
            return results;
        }


    }
}