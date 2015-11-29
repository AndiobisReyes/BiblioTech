using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Shared;

namespace WindowsFormsApplication1.Database_Layer
{
    public class SQLOleDbConnection : IDatabase<OleDbConnection>
    {
        public string DatabaseModel => "Microsoft.ACE.OLEDB.12.0";
        
        OleDbConnection _connection;
        
        public SQLOleDbConnection()
        {
            var connectionString = string.Format(Database.ConnectionString, Database.ConnectionStringDefinition);
            
            _connection = new OleDbConnection(connectionString);
        }
        
        public OleDbConnection GetConnection()
        {
            return _connection;
        }

        public async Task OpenConnection()
        {
            await _connection.OpenAsync();
        }
    }
}
