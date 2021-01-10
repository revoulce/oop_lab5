// 
// Created by letih on 01/08/2021
// 

using System;
using System.Runtime.CompilerServices;

namespace EmployeesWork.Utility {
    public class Guard {
        public static void AgainstNull(object argument, [CallerMemberName] string argumentName = "") {
            if (argument == null) {
                throw new ArgumentNullException(argumentName);
            }
        }

        public static void AgainstInvalidGenders(string gender, [CallerMemberName] string argumentName = "") {
            AgainstNull(gender, argumentName);

            if (gender != "Male" && gender != "Female") {
                throw new ArgumentException(argumentName);
            }
        }
    }
}
