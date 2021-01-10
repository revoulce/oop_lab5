// 
// Created by letih on 01/09/2021
// 

using System;
using System.Linq.Expressions;
using EmployeesWork.Utility;

namespace EmployeesWork.Specification {
    public class NotSpecification<T> : Specification<T> where T : Employee.Employee {
        private readonly Specification<T> _leftSpecification;
        private readonly Specification<T> _rightSpecification;

        public NotSpecification(Specification<T> leftSpecification, Specification<T> rightSpecification) {
            Guard.AgainstNull(leftSpecification, nameof(leftSpecification));
            Guard.AgainstNull(rightSpecification, nameof(rightSpecification));

            _leftSpecification = leftSpecification;
            _rightSpecification = rightSpecification;
        }

        public override Expression<Func<T, bool>> ToExpression() {
            var leftExpression = _leftSpecification.ToExpression();
            var rightExpression = _rightSpecification.ToExpression();

            var parameterExpression = Expression.Parameter(typeof(T));
            var notExpression = Expression.NotEqual(leftExpression.Body, rightExpression.Body);
            notExpression = (BinaryExpression) new ParameterReplacer(parameterExpression).Visit(notExpression);

            return Expression.Lambda<Func<T, bool>>(notExpression, parameterExpression);
        }
    }
}
