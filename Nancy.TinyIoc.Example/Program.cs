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

            Worker worker = container.Resolve<Worker>();

            worker.SayHello();

            person.Introduce();

            Console.ReadKey();
        }
    }
}
