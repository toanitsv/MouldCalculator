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
    
    public class SupplierController
    {
        public static void Add(Supplier model)
        {
            using (var db = new MouldEntities())
            {
                var supplierController = new Controller<Supplier>(db);
                supplierController.Add(model);
            }
        }
    }

    public class Controller<T> where T : class
    {
        protected DbContext DbContext { get; set; }
        protected DbSet<T> DbSet { get; set; }

        public Controller(DbContext dbContext)
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
            try
            {
                DbContext.Entry(entity).State = EntityState.Added;
                DbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        /// <summary>
        /// Remove a entity from DB
        /// </summary>
        /// <param name="entity">Type of model</param>
        public virtual void Remove(T entity)
        {
            try
            {
                DbContext.Entry(entity).State = EntityState.Deleted;
                DbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

    }
}
