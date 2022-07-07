﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    public interface IRepository<T> where T : class
    {
        public void Insert(T entity);
        public void Update(T entity);
        public void Delete(T entity);
        public IEnumerable<T> GetAll();
        public T GetById(int id);

    }
}
