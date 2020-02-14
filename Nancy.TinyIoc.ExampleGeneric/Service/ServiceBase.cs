using Nancy.TinyIoc.Example.Interfaces;
using Nancy.TinyIoc.ExampleGeneric.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nancy.TinyIoc.ExampleGeneric.Service
{
    public class ServiceBase<T> : IService<T> where T : EntityBase
    {
        public readonly IDbContext<T> _dbContext;

        public ServiceBase(IDbContext<T> dbContext)
        {
            _dbContext = dbContext;
        }

        public T FindById(Guid id)
        {
            return _dbContext.FindById(id);
        }
    }
}
