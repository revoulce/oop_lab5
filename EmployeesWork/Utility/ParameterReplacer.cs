// 
// Created by letih on 01/09/2021
// 

using System.Linq.Expressions;

namespace EmployeesWork.Utility {
    public class ParameterReplacer : ExpressionVisitor {
        private readonly ParameterExpression _parameter;

        internal ParameterReplacer(ParameterExpression parameter) {
            _parameter = parameter;
        }

        protected override Expression VisitParameter(ParameterExpression node) {
            return base.VisitParameter(_parameter);
        }
    }
}
