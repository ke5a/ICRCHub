using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICRC.Data.Infrastructures
{
    public class UnitOfWork : IUnitOfWork
    {
        private DataBaseFactory dbf;
        public DataBaseFactory Dbfactory
        {
            get
            {
                return dbf;
            }

        }
        public ApplicationDbContext MyContext { get { return dbf.MyContext; } }
        public UnitOfWork(DataBaseFactory databaseFact)
        {

            dbf = databaseFact;
        }
        public void Commit()
        {
            MyContext.SaveChanges();

        }

        public IRepositoryBase<T> GetRepository<T>() where T : class
        {
            return new RepositoryBase<T>(Dbfactory);
        }

        public void Dispose()
        {

            MyContext.Dispose();

        }


    }
}
