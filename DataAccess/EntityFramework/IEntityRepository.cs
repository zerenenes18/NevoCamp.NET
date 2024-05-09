﻿using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityFramework
{
    public interface IEntityRepository<T> where T: class,IEntity, new()
    {

        public List<T> GetAll(Expression<Func<T,bool>> filter = null);
        public T Get(Expression<Func<T, bool>> filter);
        public void AddProduct(T entity);
        public void UpdateProduct(T entity);
        public void DeleteProduct(T entity);
        

    }
}
