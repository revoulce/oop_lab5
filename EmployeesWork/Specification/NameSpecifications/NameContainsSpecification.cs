// 
// Created by letih on 01/09/2021
// 

using System;
using System.Linq.Expressions;
using EmployeesWork.Utility;

namespace EmployeesWork.Specification.NameSpecifications {
    public class NameContainsSpecification<T> : Specification<T> where T : Employee.Employee {
        private readonly string _namePart;

        public NameContainsSpecification(string namePart) {
            Guard.AgainstNull(namePart, nameof(namePart));

            _namePart = namePart;
        }

        public override Expression<Func<T, bool>> ToExpression() {
            return employee => employee.Name.Contains(_namePart);
        }
    }
}
