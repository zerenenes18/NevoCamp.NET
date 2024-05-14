using DataAccess.EntityFramework;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public interface IProductDal : IEntityRepository<Product>
    {
        //public Product Get(Func<Product, bool> filter);

        //public void AddProduct(Product product);
    }
}
