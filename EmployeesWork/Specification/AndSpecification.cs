// 
// Created by letih on 01/09/2021
// 

using System;
using System.Linq.Expressions;
using EmployeesWork.Utility;

namespace EmployeesWork.Specification {
    public class AndSpecification<T> : Specification<T> where T : Employee.Employee {
        private readonly Specification<T> _leftSpecification;
        private readonly Specification<T> _rightSpecification;

        public AndSpecification(Specification<T> leftSpecification, Specification<T> rightSpecification) {
            Guard.AgainstNull(leftSpecification, nameof(leftSpecification));
            Guard.AgainstNull(rightSpecification, nameof(rightSpecification));

            _leftSpecification = leftSpecification;
            _rightSpecification = rightSpecification;
        }

        public override Expression<Func<T, bool>> ToExpression() {
            var leftExpression = _leftSpecification.ToExpression();
            var rightExpression = _rightSpecification.ToExpression();

            var parameterExpression = Expression.Parameter(typeof(T));
            var andExpression = Expression.AndAlso(leftExpression.Body, rightExpression.Body);
            andExpression = (BinaryExpression) new ParameterReplacer(parameterExpression).Visit(andExpression);

            return Expression.Lambda<Func<T, bool>>(andExpression, parameterExpression);
        }
    }
}
