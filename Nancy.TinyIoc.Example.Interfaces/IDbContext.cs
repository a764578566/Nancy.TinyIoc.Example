using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nancy.TinyIoc.Example.Interfaces
{
    public interface IDbContext<T> where T : IEntityBase
    {
        T FindById(Guid id);

        void Test();
    }
}
