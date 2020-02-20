using Nancy.TinyIoc.Example.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nancy.TinyIoc.Example
{
    public class Man : IPerson
    {
        public void Introduce()
        {
            Console.WriteLine(this.GetHashCode());
            Console.WriteLine("Hello ,My Name is zhou");
        }
    }
}
