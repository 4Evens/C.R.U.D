using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace Business.Abstrack
{
    public interface ICategoryService
    {
        List<Category> GetAll();
    }
}
