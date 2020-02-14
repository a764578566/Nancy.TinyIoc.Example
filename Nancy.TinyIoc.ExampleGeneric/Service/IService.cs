using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nancy.TinyIoc.ExampleGeneric.Service
{
    public interface IService<T>
    {
        T FindById(Guid id);
    }
}
