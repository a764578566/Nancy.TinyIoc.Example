using Nancy.TinyIoc.Example.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nancy.TinyIoc.Example.PropertyInjection
{
    public class Woman : IPerson
    {
        public string Name { get; }

        public int Age { get; }

        public Woman()
        {

        }

        public Woman(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public void Introduce()
        {
            Console.WriteLine(this.GetHashCode());
            Console.WriteLine($"Hello ,My Name is {this.Name}");
        }
    }
}
