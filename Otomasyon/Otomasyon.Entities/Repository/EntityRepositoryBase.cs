﻿using FluentValidation;
using Otomasyon.Entities.Interface;
using Otomasyon.Entities.Tools;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Otomasyon.Entities.Repository
{
    public class EntityRepositoryBase<TContext, TEntity,TValidator> : IEntityRepository<TContext, TEntity>

         where TContext : DbContext, new()
        where TEntity : class,IEntity , new()
        where TValidator : IValidator, new()

    {
        public bool AddOrUpdate(TContext context, TEntity entity)
        {
            TValidator validator = new TValidator();
            bool ValidationResult = ValidatorTools.Validates(validator, entity);
            if (ValidationResult)
            {
                context.Set<TEntity>().AddOrUpdate(entity);

            }
            return ValidationResult;
        }

        public void Delete(TContext context, Expression<Func<TEntity, bool>> filter)
        {
            context.Set<TEntity>().Remove(context.Set<TEntity>().FirstOrDefault(filter));
        }

        public List<TEntity> GetAll(TContext context, Expression<Func<TEntity, bool>> filter = null)
        {
            return filter == null ? context.Set<TEntity>().ToList() : context.Set<TEntity>().Where(filter).ToList();
        }

        public TEntity GetByFilter(TContext context, Expression<Func<TEntity, bool>> filter)
        {
            return context.Set<TEntity>().FirstOrDefault(filter);

        }

        public void Save(TContext context)
        {
            try
            {
                context.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                
                Console.WriteLine($"Hata: {ex.InnerException?.Message}");
                throw; 
            }
        }

    }
}
