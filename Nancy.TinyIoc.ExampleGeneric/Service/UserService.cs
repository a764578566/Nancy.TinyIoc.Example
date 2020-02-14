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
    public class UserService : ServiceBase<User>
    {
        public UserService(IDbContext<User> dbContext) : base(dbContext)
        {

        }
    }
}
