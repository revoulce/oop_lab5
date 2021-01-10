// 
// Created by letih on 01/09/2021
// 

using System;
using System.Linq.Expressions;
using EmployeesWork.Utility;

namespace EmployeesWork.Specification.JobTitleSpecifications {
    public class JobTitleContainsSpecification<T> : Specification<T> where T : Employee.Employee {
        private readonly string _jobTitlePart;

        public JobTitleContainsSpecification(string jobTitlePart) {
            Guard.AgainstNull(jobTitlePart, nameof(jobTitlePart));

            _jobTitlePart = jobTitlePart;
        }

        public override Expression<Func<T, bool>> ToExpression() {
            return employee => employee.JobTitle.Contains(_jobTitlePart);
        }
    }
}
