using System;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

using DssData.Models;
using System.Web;
using DssData.Contexts;

namespace DssData.Repository
{
	public class Repository<T> : IRepository<T> where T : class
	{
		protected DssDataContext _dssContext;
		private readonly DbSet<T> _dbSet;

		public Repository(DbContext dbContext)
		{
			_dssContext = (DssDataContext)dbContext;
			_dbSet = _dssContext.Set<T>();
		}

		public Repository()
		{
			_dssContext = new Contexts.DssDataContext();
			_dbSet = _dssContext.Set<T>();
		}

		public T GetById(object id)
		{
			return _dbSet.Find(id);
		}

		public IQueryable<T> GetAll(params string[] navigationProperties)
		{
			IQueryable<T> dbQuery = _dssContext.Set<T>();
			foreach (string navigationProperty in navigationProperties)
			{
				dbQuery = dbQuery.Include(navigationProperty);
			}
			return dbQuery;
		}

		public virtual void Add(T item)
		{

			_dbSet.Add(item);
			_dssContext.Entry(item).State = EntityState.Added;
			_dssContext.SaveChangesAsync();
		}

		public virtual void Delete(object id)
		{
			T deleteItem = _dbSet.Find(id);

			//TODO - Check for null object????
			Delete(deleteItem);
			_dssContext.Entry(deleteItem).State = EntityState.Deleted;
			_dssContext.SaveChangesAsync();

			//TODO - Update state ??
		}

		public virtual void Delete(T item)
		{
			// More here check if item state is detached. If it is, attach it.
			_dbSet.Remove(item);
			_dssContext.Entry(item).State = EntityState.Deleted;
			_dssContext.SaveChangesAsync();
		}

		public virtual void Update(T item)
		{
			//TODO - null checks on item????
			_dbSet.Attach(item);
			_dssContext.Entry(item).State = EntityState.Modified;
			_dssContext.SaveChangesAsync();
		}
	}
}
