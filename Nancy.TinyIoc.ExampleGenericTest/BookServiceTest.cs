using Nancy.TinyIoc.Example.Interfaces;
using Nancy.TinyIoc.Example.Interfaces.Fakes;
using Nancy.TinyIoc.ExampleGeneric;
using Nancy.TinyIoc.ExampleGeneric.Entity;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nancy.TinyIoc.ExampleGenericTest
{
    [TestFixture]
    public class BookServiceTest
    {
        private BookService _bookService;

        private readonly StubIDbContext<Book> stubIDbContextBook;

        public BookServiceTest()
        {
            TinyIoCContainer tiny = new TinyIoCContainer();
            stubIDbContextBook = new StubIDbContext<Book>();
            tiny.Register<IDbContext<Book>, StubIDbContext<Book>>(stubIDbContextBook);
            _bookService = tiny.Resolve<BookService>();
        }

        [Test]
        public void FindByIdTest()
        {
            stubIDbContextBook.FindByIdGuid = id =>
            {
                Console.WriteLine("Test");
                return new Book() { Id = id, Name = "TestName" };
            };

            Guid guid = Guid.NewGuid();
            var book = _bookService.FindById(guid);

            Assert.IsTrue(book.Id == guid);
            Assert.IsTrue(book.Name == "TestName");
        }
    }
}
