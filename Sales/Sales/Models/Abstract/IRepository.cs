﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sales.Models.Abstract
{
    public interface IRepository<T> where T:class
    {
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        T GetSingle(T entity);
        List<T> GetAll();
    }
}
