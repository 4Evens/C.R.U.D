using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace Business.Abstrack
{
    public interface IUserService
    {
        List<User> GetAll();
        List<User> GetProductsByCategory(int categoryId);
        List<User> GetProductName(string userName);
        void Add(User user);
        void Update(User user);
        void Delete(User user);
        bool IsUser(string FirstName, string Password);
        bool IsExist(string userName, string password);
        bool CheckLogin(string userName, string password);
    }
}
