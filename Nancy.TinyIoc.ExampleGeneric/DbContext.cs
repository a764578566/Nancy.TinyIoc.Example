using Nancy.TinyIoc.Example.Interfaces;
using Nancy.TinyIoc.ExampleGeneric.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nancy.TinyIoc.ExampleGeneric
{
    public class DbContext<T> : IDbContext<T> where T : EntityBase, new()
    {
        public T FindById(Guid id)
        {
            Console.WriteLine($"{typeof(T).Name}'s Id is {id}");
            return new T() { Id = id, Name = typeof(T).Name };
        }
    }
}
