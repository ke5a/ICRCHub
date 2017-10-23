using ICRC.Data.Infrastructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ICRC.ServicePattern
{
    public class Service<T> : IService<T> where T : class
    {
        UnitOfWork utw;

        public Service(UnitOfWork utw)
        {


            this.utw = utw;

        }

        public void Commit()
        {
            utw.Commit();
        }

        public virtual void Create(T entity)
        {
            utw.GetRepository<T>().Add(entity);
        }

        public virtual T GetById(string id)
        {
            return utw.GetRepository<T>().GetById(id);
        }

        public virtual T GetById(int id)
        {
            return utw.GetRepository<T>().GetById(id);
        }

        public virtual IEnumerable<T> GetMany(Expression<Func<T, bool>> condition = null, Expression<Func<T, bool>> orderBy = null)
        {
            return utw.GetRepository<T>().GetMany(condition, orderBy);
        }

        public virtual void Remove(Expression<Func<T, bool>> condition)
        {
            utw.GetRepository<T>().delete(condition);
        }

        public virtual void Remove(T entity)
        {
            utw.GetRepository<T>().Delete(entity);
        }

        public virtual void Update(T entity)
        {
            utw.GetRepository<T>().Update(entity);
        }
    }
}
