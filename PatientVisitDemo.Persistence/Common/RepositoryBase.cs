﻿using Microsoft.EntityFrameworkCore;
using PatientVisitDemo.Application.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PatientVisitDemo.Persistence.Common
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        //create a field variable
        protected RepositoryContext RepositoryContext;

        //Implementing Dependency Injection by Constructor.
        public RepositoryBase(RepositoryContext repositoryContext) => RepositoryContext = repositoryContext;

        public void Create(T entity) => RepositoryContext.Set<T>().Add(entity);

        public void Delete(T entity) => RepositoryContext.Set<T>().Remove(entity);

        public IQueryable<T> FindAll(bool trackChanges) => !trackChanges ?
                RepositoryContext.Set<T>()
                .AsNoTracking() :
                RepositoryContext.Set<T>();

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression, bool trackChanges) => !trackChanges ?
                RepositoryContext.Set<T>()
                .Where(expression)
                .AsNoTracking() :
                RepositoryContext.Set<T>()
                .Where(expression);

        public void Update(T entity)
        {
            RepositoryContext.Set<T>().Update(entity);
        }
    }
}
