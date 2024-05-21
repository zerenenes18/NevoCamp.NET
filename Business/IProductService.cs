using Core.Results;
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

        public IResult AddProduct(Product product);
        public IResult UpdateProduct(Product entity);
        public IDataResult<List<Product>> GetAll(Expression<Func<Product, bool>> filter = null );
        public IResult DeleteProduct(Product entity); 


        public IDataResult<Product> Get(Expression<Func<Product,bool>> filter);
    }
}
