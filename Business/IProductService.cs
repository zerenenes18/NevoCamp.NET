using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public interface IProductService
    {

        public void AddProduct(Product product);
        public void UpdateProduct(Product entity);
        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null );
        public void DeleteProduct(Product entity); 


        public Product Get(Expression<Func<Product,bool>> filter);
    }
}
