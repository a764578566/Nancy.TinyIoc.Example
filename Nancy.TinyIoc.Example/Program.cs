using Nancy.TinyIoc.Example.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nancy.TinyIoc.Example
{
    class Program
    {
        static void Main(string[] args)
        {
            TinyIoCContainer container = new TinyIoCContainer();

            container.Register<IPerson, Man>();//单例模式获取

            IPerson person = container.Resolve<IPerson>();//这里的person跟下面在worker获取的是一个对象

            Worker worker1 = container.Resolve<Worker>();

            Worker worker2 = container.Resolve<Worker>();

            worker1.SayHello();
            Console.WriteLine("worker1:" + worker1.GetHashCode());

            worker2.SayHello();
            Console.WriteLine("worker2:" + worker2.GetHashCode());//worker1跟worker2为两个不同的对象，他们里面的IPerson为一个对象

            person.Introduce();

            Console.ReadKey();
        }
    }
}
