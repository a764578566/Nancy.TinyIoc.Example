using Nancy.TinyIoc.Example.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nancy.TinyIoc.Example
{
    public class Worker
    {
        private readonly IPerson _person;

        public Worker(IPerson person)
        {
            this._person = person;
        }

        public void SayHello()
        {
            if (_person != null)
            {
                _person.Introduce();
            }
            else
            {
                Console.WriteLine("IPerson is Null");
            }
        }
    }
}
