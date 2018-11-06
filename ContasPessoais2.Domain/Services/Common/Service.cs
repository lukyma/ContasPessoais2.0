using ContasPessoais2.Domain.Interfaces;
using ContasPessoais2.Domain.Interfaces.Services.Common;
using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ContasPessoais2.Domain.Services.Common
{
    public class Service<TEntity> : IService<TEntity> where TEntity : class
    {
        private readonly IRepository<TEntity> _repository;

        public Service(IRepository<TEntity> repository)
        {
            _repository = repository;
        }

        public ValidationResult Add(TEntity entity, params IValidator<TEntity>[] validators)
        {
            List<ValidationFailure> validationErrors = new List<ValidationFailure>();

            foreach(var itemValidator in validators)
            {
                ValidationResult validationResult = itemValidator.Validate(entity);
                if (!validationResult.IsValid)
                {
                    validationErrors.AddRange(validationResult.Errors);
                }
            }

            return new ValidationResult(validationErrors);
        }

        public virtual IEnumerable<TEntity> All(bool @readonly = false)
        {
            throw new NotImplementedException();
        }

        public virtual ValidationResult Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public virtual IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate, bool @readonly = false)
        {
            throw new NotImplementedException();
        }

        public virtual TEntity Get(int id, bool @readonly = false)
        {
            throw new NotImplementedException();
        }

        public virtual ValidationResult Update<TValidator>(TEntity entity, TValidator validator) where TValidator : IValidator<TEntity>
        {
            ValidationResult validationResult = validator.Validate(entity);
            if (validationResult.IsValid)
            {
                _repository.Update(entity);
            }

            return validationResult;
        }

        public void Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
