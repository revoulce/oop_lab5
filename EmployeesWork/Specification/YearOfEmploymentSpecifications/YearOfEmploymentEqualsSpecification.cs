// 
// Created by letih on 01/09/2021
// 

using System;
using System.Linq.Expressions;

namespace EmployeesWork.Specification.YearOfEmploymentSpecifications {
    public class YearOfEmploymentEqualsSpecification<T> : Specification<T> where T : Employee.Employee {
        private readonly int _yearOfEmployment;

        public YearOfEmploymentEqualsSpecification(int yearOfEmployment) {
            _yearOfEmployment = yearOfEmployment;
        }

        public override Expression<Func<T, bool>> ToExpression() {
            return employee => employee.YearOfEmployment == _yearOfEmployment;
        }
    }
}
