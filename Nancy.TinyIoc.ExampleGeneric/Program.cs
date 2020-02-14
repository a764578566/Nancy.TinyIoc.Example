using Nancy.TinyIoc;
using Nancy.TinyIoc.Example.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nancy.TinyIoc.ExampleGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            TinyIoCContainer container = new TinyIoCContainer();
            container.Register(typeof(IDbContext<>), typeof(DbContext<>)).AsMultiInstance();

            BookService bookService = container.Resolve<BookService>();

            UserService userService = container.Resolve<UserService>();

            var book = bookService.FindById(Guid.NewGuid());

            var user = userService.FindById(Guid.NewGuid());

            Console.ReadKey();
        }
    }
}
