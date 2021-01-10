// 
// Created by letih on 01/09/2021
// 

using System;
using System.Linq.Expressions;
using EmployeesWork.Utility;

namespace EmployeesWork.Specification.NameSpecifications {
    public class NameEqualsSpecification<T> : Specification<T> where T : Employee.Employee {
        private readonly string _name;

        public NameEqualsSpecification(string name) {
            Guard.AgainstNull(name, nameof(name));

            _name = name;
        }

        public override Expression<Func<T, bool>> ToExpression() {
            return employee => employee.Name == _name;
        }
    }
}
