using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Sprout.DL.Repo
{
    public interface IRepository<TEntity> where TEntity : class
    {
        /// <summary>
        /// Get all data
        /// </summary>
        /// <returns></returns>
        IEnumerable<TEntity> All();

        /// <summary>
        /// Get DBset
        /// </summary>
        /// <returns></returns>
        DbSet<TEntity> GetDbSet();

        /// <summary>
        /// Get data by predicate
        /// </summary>
        /// <returns></returns>
        IEnumerable<TEntity> FindBy(Expression<Func<TEntity, bool>> predicate);
    }
}
