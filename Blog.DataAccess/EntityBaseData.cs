
namespace Blog.DataAccess
{

    using Blog.Entity.Entities;
    using Blog.Entity.Results;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Text;
    using System.Threading.Tasks;
    using Blog.Entity;
    using Realms;
    using Blog.Entity.Entities;

    public class EntityBaseData<T> : IData<T> where T : class, IEntity, new()
    {
        protected readonly DbContext _context;
        public EntityBaseData(DbContext context)
        {
            _context = context;
        }

        public DataResult Delete(T t)
        {
            throw new NotImplementedException();
        }

        public DataResult DeleteByKey(int id)
        {
            throw new NotImplementedException();
        }

        public void DetachAllEntities()
        {
            throw new NotImplementedException();
        }

        public T FirstOrDeafult(Expression<Func<T, bool>> predicate, bool asNoTracking = false)
        {
            throw new NotImplementedException();
        }

        public T FirstOrDeafult(Expression<Func<T, bool>> predicate, string orderBy = "Id", bool isDesc = false, bool asNoTracking = false)
        {
            throw new NotImplementedException();
        }

        public List<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<T> GetAll(string orderBy, bool isDesc = false)
        {
            throw new NotImplementedException();
        }

        public List<T> GetBy(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public List<T> GetBy(Expression<Func<T, bool>> predicate, string orderBy, bool isDesc = false)
        {
            throw new NotImplementedException();
        }

        public T GetByKey(int id)
        {
            throw new NotImplementedException();
        }

        public List<T> GetByPage(int pageNumber, int pageCount, string orderBy = "Id", bool isDesc = false)
        {
            throw new NotImplementedException();
        }

        public List<T> GetByPage(Expression<Func<T, bool>> predicate, int pageNumber, int pageCount, string orderBy = "Id", bool isDesc = false)
        {
            throw new NotImplementedException();
        }

        public int GetCount()
        {
            throw new NotImplementedException();
        }

        public int GetCount(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public DataResult Insert(T t)
        {
            throw new NotImplementedException();
        }

        public DataResult InsertBulk(List<T> ts, bool validateAndIngoreBefore = false)
        {
            throw new NotImplementedException();
        }

        public DataResult Update(T t)
        {
            throw new NotImplementedException();
        }
    }
}
