// 
// Created by letih on 01/09/2021
// 

using System;
using System.Linq.Expressions;

namespace EmployeesWork.Specification.YearOfBirthSpecifications {
    public class YearOfBirthSpanSpecification<T> : Specification<T> where T : Employee.Employee {
        private readonly int _leftCorner;
        private readonly int _rightCorner;

        public YearOfBirthSpanSpecification(int leftCorner, int rightCorner) {
            _leftCorner = leftCorner;
            _rightCorner = rightCorner;
        }

        public override Expression<Func<T, bool>> ToExpression() {
            return employee => _leftCorner <= employee.YearOfBirth && employee.YearOfBirth <= _rightCorner;
        }
    }
}
