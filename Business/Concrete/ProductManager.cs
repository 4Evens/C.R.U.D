using DataAccess.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstrack;
using Business.Utilities;
using Business.ValidationRules.FluentValidation;
using DataAccess.Abstrack;
using DataAccess.Concrete.EntityFramework;
using FluentValidation;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Add(Product product)
        {
            ValidationTool.Validate(new ProductValidator(), product);
            _productDal.Add(product);
        }

        public void Update(Product product)
        {
            ValidationTool.Validate(new ProductValidator(), product);
            _productDal.Update(product);
        }

        public void Delete(Product product)
        {
            try
            {
                _productDal.Delete(product);
            }
            catch
            {
                throw new Exception("Silme Gercekleşemedi");
            }
        }

        public List<Product> GetAll()
        {
            return _productDal.GetAll();

        }

        public List<Product> GetProductName(string productName)
        {
            return _productDal.GetAll(p => p.ProductName.ToLower().Contains(productName.ToLower()));
        }

        public List<Product> GetProductsByCategory(int categoryId)
        {
            return _productDal.GetAll(p => p.CategoryId == categoryId);
        }
    }
}
