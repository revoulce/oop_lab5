// 
// Created by letih on 01/08/2021
// 

using System;
using System.Linq.Expressions;

namespace EmployeesWork.Specification {
    public abstract class Specification<T> where T : Employee.Employee {
        public abstract Expression<Func<T, bool>> ToExpression();

        public bool IsSatisfiedBy(T entity) {
            var predicate = ToExpression().Compile();

            return predicate(entity);
        }

        [NotNull]
        public Specification<T> And(Specification<T> specification) {
            return new AndSpecification<T>(this, specification);
        }

        [NotNull]
        public Specification<T> Or(Specification<T> specification) {
            return new OrSpecification<T>(this, specification);
        }

        [NotNull]
        public Specification<T> Not(Specification<T> specification) {
            return new NotSpecification<T>(this, specification);
        }
    }
}
