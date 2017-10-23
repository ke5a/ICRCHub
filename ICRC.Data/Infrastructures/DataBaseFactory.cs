using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICRC.Data.Infrastructures
{
    public class DataBaseFactory : Disposable, IDataBaseFactory


    {
        private ApplicationDbContext context;

        public DataBaseFactory()
        {

            context = new ApplicationDbContext();
        }
        public ApplicationDbContext MyContext
        {
            get
            {
                return context;
            }
        }

        protected override void DisposeCore()
        {
            if (MyContext != null)

                MyContext.Dispose();

        }
    }
}
