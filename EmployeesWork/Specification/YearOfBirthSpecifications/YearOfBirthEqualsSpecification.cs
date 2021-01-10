// 
// Created by letih on 01/09/2021
// 

using System;
using System.Linq.Expressions;

namespace EmployeesWork.Specification.YearOfBirthSpecifications {
    public class YearOfBirthEqualsSpecification<T> : Specification<T> where T : Employee.Employee {
        private readonly int _yearOfBirth;

        public YearOfBirthEqualsSpecification(int yearOfBirth) {
            _yearOfBirth = yearOfBirth;
        }

        public override Expression<Func<T, bool>> ToExpression() {
            return employee => employee.YearOfBirth == _yearOfBirth;
        }
    }
}
