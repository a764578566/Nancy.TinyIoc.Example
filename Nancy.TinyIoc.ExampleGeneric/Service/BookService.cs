using Nancy.TinyIoc.Example.Interfaces;
using Nancy.TinyIoc.ExampleGeneric.Entity;
using Nancy.TinyIoc.ExampleGeneric.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nancy.TinyIoc.ExampleGeneric
{
    public class BookService : ServiceBase<Book>
    {
        public BookService(IDbContext<Book> dbContext) : base(dbContext)
        {

        }

        /// <summary>
        /// 测试方法1
        /// </summary>
        public void Test1()
        {
            _dbContext.Test();
        }
    }
}
