using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class ProductManager : IProductService
    {
        ProductDal _productDal;
        public ProductManager()
        {
            _productDal = new ProductDal();
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

        public Product Get(Func<Product, bool> filter)
        {
            return _productDal.Get(filter);
        }
    }
}
