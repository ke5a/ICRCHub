using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICRC.Data.Infrastructures
{
    public interface IDataBaseFactory : IDisposable
    {

        ApplicationDbContext MyContext { get; }

    }
}
