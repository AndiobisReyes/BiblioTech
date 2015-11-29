using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Database_Layer
{
    public interface IDatabase<T>
    {
        string DatabaseModel { get; }

        Task OpenConnection();

        T GetConnection();
    }
}
