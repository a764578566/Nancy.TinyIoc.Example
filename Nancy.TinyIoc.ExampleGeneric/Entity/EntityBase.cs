using Nancy.TinyIoc.Example.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nancy.TinyIoc.ExampleGeneric.Entity
{
    public class EntityBase : IEntityBase
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
