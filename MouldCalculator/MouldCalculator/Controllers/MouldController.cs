using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MouldCalculator.Models;
using System.Data.Entity;

namespace MouldCalculator.Controllers
{
    public class MouldController<T> where T : class
    {
        protected DbContext DbContext { get; set; }
        protected DbSet<T> DbSet { get; set; }

        public MouldController(DbContext dbContext)
        {
            if (dbContext == null)
                throw new ArgumentNullException("dbContext");
            DbContext = dbContext;
            DbSet = DbContext.Set<T>();
        }

        /// <summary>
        /// Insert a entity to DB
        /// </summary>
        /// <param name="entity">Type of model</param>
        public virtual void Add(T entity)
        {
            DbContext.Entry(entity).State = EntityState.Added;
            DbContext.SaveChanges();
        }
        /// <summary>
        /// Remove a entity from DB
        /// </summary>
        /// <param name="entity">Type of model</param>
        public virtual void Remove(T entity)
        {
            DbContext.Entry(entity).State = EntityState.Deleted;
            DbContext.SaveChanges();
        }
    }
}
