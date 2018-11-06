using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ContasPessoais2.Domain.Interfaces.Services.Common
{
    public interface IService<TEntity> where TEntity : class
    {
        TEntity Get(int id, bool @readonly = false);
        IEnumerable<TEntity> All(bool @readonly = false);
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate, bool @readonly = false);
        ValidationResult Add(TEntity entity, params IValidator<TEntity>[] validators);
        ValidationResult Update<TValidator>(TEntity entity, TValidator validator) where TValidator : IValidator<TEntity>;
        void Update(TEntity entity);
        ValidationResult Delete(TEntity entity);
    }
}
