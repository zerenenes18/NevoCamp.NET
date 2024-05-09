using DataAccess;
using DataAccess.EntityFramework;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
           // _productDal = new ProductDal();
            _productDal = productDal;
        }
        public void AddProduct(Product product)
        {
            // iş kuralları 
            // okay... 
            _productDal.AddProduct(product);
        }


        public void DeleteProduct(int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteProduct(Product entity)
        {
            _productDal.DeleteProduct(entity);
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            return _productDal.Get(filter);
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
           return _productDal.GetAll(filter);
        }

        public void UpdateProduct(Product entity)
        {
            _productDal.UpdateProduct(entity);
        }
    }
}
