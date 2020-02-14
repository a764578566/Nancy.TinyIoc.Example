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
            container.Register<IPerson, Man>();

            Worker worker = container.Resolve<Worker>();

            worker.SayHello();

            Console.ReadKey();
        }
    }
}
