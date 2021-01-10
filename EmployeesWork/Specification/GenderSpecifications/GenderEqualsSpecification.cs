// 
// Created by letih on 01/09/2021
// 

using System;
using System.Linq.Expressions;
using EmployeesWork.Utility;

namespace EmployeesWork.Specification.GenderSpecifications {
    public class GenderEqualsSpecification<T> : Specification<T> where T : Employee.Employee {
        private readonly string _gender;

        public GenderEqualsSpecification(string gender) {
            Guard.AgainstInvalidGenders(gender);

            _gender = gender;
        }

        public override Expression<Func<T, bool>> ToExpression() {
            return employee => employee.Gender == _gender;
        }
    }
}
