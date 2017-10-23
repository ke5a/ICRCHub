using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ICRC.Data.Infrastructures
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        private ApplicationDbContext context;
        public ApplicationDbContext Context { get; set; }

         static IDbSet<T> dbset; // static peut être modifié que du constructeur de la classe 

        public RepositoryBase(DataBaseFactory dbFactory)
        {
            Context = dbFactory.MyContext;
            dbset = Context.Set<T>();// remplire variable de dbset selon context
        }
        public void Commit()
        {
            Context.SaveChanges();
        }

        public void Add(T entity)
        {
            dbset.Add(entity);
        }

        public void Delete(Expression<Func<T, bool>> condition)
        {
            IEnumerable<T> MaListe = dbset.Where(condition);
            foreach (T item in MaListe)
                dbset.Remove(item);
        }

        public void Delete(T entity)
        {
            dbset.Remove(entity);
        }

        public T GetById(int id)
        {
            return dbset.Find(id);
        }

        public T GetById(string id)
        {
            return dbset.Find(id);
        }

        public IEnumerable<T> GetMany(Expression<Func<T, bool>> condition = null,
            Expression<Func<T, bool>> orderBy = null)
        {
            IQueryable<T> List = dbset;
            if ((condition != null) && (orderBy != null))
                return List.Where(condition).OrderBy(orderBy);
            else
                if ((condition != null) && (orderBy == null))
                return List.Where(condition);
            else
                if ((orderBy != null) && (condition == null))
                return List.OrderBy(orderBy);

            else return List;
        }

        public void Update(T entity)
        {
            dbset.Attach(entity); // Annoncer que c'est un objet existant pour le modifier
            Context.Entry(entity).State = EntityState.Modified;
        }

        public void delete(Expression<Func<T, bool>> condition)
        {
            IEnumerable<T> MaListe = dbset.Where(condition);
            foreach (T item in MaListe)
                dbset.Remove(item);
        }

        /*  public void delete(Expression<Func<T, bool>> condition)
          {
              throw new NotImplementedException();
          }*/
    }

}
