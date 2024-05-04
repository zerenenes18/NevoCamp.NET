using Entities;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO.Pipes;


using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ProductDal : IProductDal
    {
        public int products { get; set; }  // => propertyleri başka classlarda kullansın diye oluşturuyoruz.
        List<Product> _products; // fields kendimiz kullanmak için oluşturuyoruz.
        List<Product> _list1;
        public ProductDal()
        {

            List<Product> products = new List<Product>();
            products.Add(new Product {CategoryId = 1,ProductId = 1,ProductName ="Bardak",UnitPrice = 10,UnitsInStock =3 });
            products.Add(new Product { CategoryId = 2, ProductId = 2, ProductName = "Telefon", UnitPrice = 1000, UnitsInStock = 1 });
            products.Add(new Product { CategoryId = 2, ProductId = 3, ProductName = "Kamera", UnitPrice = 100, UnitsInStock = 2 });
            _products = products;

        }
        //public Product GetProduct(Func<Product, bool> filter)
        //{
        //    return _products.FirstOrDefault(filter);
        //}

        //public Product GetProductByName(string name)
        //{

        //    foreach (var item in _products)
        //    {
        //        if (item.ProductName == name) return item;
        //    }
        //    return new Product();
        //}


        //public Product GetProductById(int id)
        //{
            
        //    foreach (var item in _products)
        //    {
        //        if(item.ProductId == id) return item;   
        //    }
        //    return new Product(); 
        //}
        public List<Product> GetProducts(Func<Product,bool> filter = null)
        {
            return _products.Where(filter).ToList();
        }

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

       
        public Product Get(Func<Product,bool> filter)
        {
            return  _products.FirstOrDefault(filter);
        }

        public Product GetProductByName(string name)
        {
            var result = new Product();
            foreach (var product in _products)
            {
                if (product.ProductName == name)
                {
                    return product;
                }
            }

            //return result;

            return _products.FirstOrDefault(p => p.ProductName == name);
        }

        public Product GetProductById(int id)
        {   
            
            return  _products.FirstOrDefault(p => p.ProductId == id);
           
         
        }


    }
}
