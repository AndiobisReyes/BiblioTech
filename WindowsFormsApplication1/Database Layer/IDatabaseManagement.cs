using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Database_Layer
{
    public interface IDatabaseManagement<T> where T : class
    {
        Task Insert(T value);

        Task<T> Read();

        Task Update(T value);

        Task Delete();
    }
}
