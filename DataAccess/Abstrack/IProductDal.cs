using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace DataAccess.Abstrack
{
    public interface IProductDal : IEntityRepository<Product>
    {
        
    }
}
