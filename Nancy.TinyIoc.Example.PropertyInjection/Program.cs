using Nancy.TinyIoc.Example.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nancy.TinyIoc.Example.PropertyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            TinyIoCContainer container = new TinyIoCContainer();
            container.Register<IPerson, Woman>().AsMultiInstance();//每次获取都是一个新的对象

            IPerson woman1 = container.Resolve<IPerson>(new NamedParameterOverloads() { { "name", "zhou" }, { "age", 18 } });

            woman1.Introduce();

            IPerson woman2 = container.Resolve<IPerson>(new NamedParameterOverloads() { { "name", "feng" }, { "age", 16 } });

            woman2.Introduce();

            Console.ReadKey();
        }
    }
}
