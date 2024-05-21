using Core.Results;
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
        public IResult AddProduct(Product product)
        {
            // iş kuralları 
            // okay... 
            _productDal.AddProduct(product);
            return new SuccessResult(Messages.AddedProduct);
        }


        public IResult DeleteProduct(int id)
        {
            throw new NotImplementedException();
        }

        public IResult DeleteProduct(Product entity)
        {
            if (entity.ProductName == null)
            {
                new ErrorResult(Messages.Error);
            }

            _productDal.DeleteProduct(entity);

            return new SuccessResult(Messages.DeletedProduct);

            
        }

        public IDataResult<Product> Get(Expression<Func<Product, bool>> filter)
        {
            var data =  _productDal.Get(filter);

            return new SuccessDataResult<Product>(data);

        }

        public IDataResult<List<Product>> GetAll(Expression<Func<Product, bool>> filter = null)
        {
           var data =  _productDal.GetAll(filter);

            return new SuccessDataResult<List<Product>>(data);
        }

        public IResult UpdateProduct(Product entity)
        {
            _productDal.UpdateProduct(entity);

            return new SuccessResult();
        }
    }
}
