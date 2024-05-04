using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public interface IProductService
    {

        public void AddProduct(Product product);

        public void DeleteProduct(int id); 

        public Product Get(Func<Product,bool> filter);
    }
}
