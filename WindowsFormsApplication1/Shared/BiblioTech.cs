using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Shared
{
    public class Database
    {
        public static readonly string DatabaseName = "Biblioteca.accdb";

        public static readonly string ConnectionString = "Provider = {0}; Data Source = {1}";

        public static string ConnectionStringDefinition => string.Format("{0} {1} {2}", Application.StartupPath, Path.PathSeparator, Database.DatabaseName);
    }
}
