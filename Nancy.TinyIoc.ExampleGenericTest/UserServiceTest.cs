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
    public class UserServiceTest
    {
        private UserService _userService;

        private readonly StubIDbContext<User> stubIDbContextUser;

        public UserServiceTest()
        {
            TinyIoCContainer tiny = new TinyIoCContainer();
            stubIDbContextUser = new StubIDbContext<User>();
            tiny.Register<IDbContext<User>, StubIDbContext<User>>(stubIDbContextUser);
            _userService = tiny.Resolve<UserService>();
        }

        [Test]
        public void FindByIdTest()
        {
            stubIDbContextUser.FindByIdGuid = id =>
            {
                Console.WriteLine("Test");
                return new User() { Id = id, Name = "TestName" };
            };

            Guid guid = Guid.NewGuid();
            var book = _userService.FindById(guid);

            Assert.IsTrue(book.Id == guid);
            Assert.IsTrue(book.Name == "TestName");
        }


        [Test]
        public void Test()
        {
            stubIDbContextUser.Test = () =>
            {
                Console.WriteLine("Test");
            };

            _userService.Test2();
        }
    }
}
