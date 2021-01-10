// 
// Created by letih on 01/09/2021
// 

using System;
using System.Linq.Expressions;
using EmployeesWork.Utility;

namespace EmployeesWork.Specification.JobTitleSpecifications {
    public class JobTitleEqualsSpecification<T> : Specification<T> where T : Employee.Employee {
        private readonly string _jobTitle;

        public JobTitleEqualsSpecification(string jobTitle) {
            Guard.AgainstNull(jobTitle, nameof(jobTitle));

            _jobTitle = jobTitle;
        }

        public override Expression<Func<T, bool>> ToExpression() {
            return employee => employee.JobTitle == _jobTitle;
        }
    }
}
