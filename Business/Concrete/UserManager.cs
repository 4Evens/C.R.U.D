using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstrack;
using DataAccess.Abstrack;
using Entities.Concrete;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        private IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public List<User> GetAll()
        {
            return _userDal.GetAll();
        }

        public List<User> GetProductsByCategory(int categoryId)
        {
            return _userDal.GetAll();
        }

        public List<User> GetProductName(string userName)
        {
            return _userDal.GetAll();
        }

        public void Add(User user)
        {
            _userDal.Add(user);
        }

        public void Update(User user)
        {
            _userDal.Update(user);
        }

        public void Delete(User user)
        {
            _userDal.Delete(user);
        }

        public bool IsUser(string FirstName, string Password)
        {
            return _userDal.IsExist(p => p.Email == FirstName && p.Password.Equals(Password));
        }

        public bool IsExist(string userName, string password)
        {
            return _userDal.IsExist(p => p.Email == userName && p.Password == password);
        }

        public bool CheckLogin(string userName, string password)
        {
            var result = _userDal.GetAll(p => p.Email == userName && p.Password == password);
            if (result.Count > 0)
            {
                return true;

            }
            else
            {
                return false;
            }
        }
    }
}
