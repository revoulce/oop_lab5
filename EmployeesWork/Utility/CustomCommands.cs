// 
// Created by letih on 01/10/2021
// 

using System.Windows.Input;

namespace EmployeesWork.Utility {
    public static class CustomCommands {
        public static readonly RoutedUICommand Exit = new(
            "Exit",
            "Exit",
            typeof(CustomCommands),
            new InputGestureCollection {
                new KeyGesture(Key.F4, ModifierKeys.Alt),
            }
        );

        public static readonly RoutedUICommand AddEmployee = new(
            "Add Employee",
            "Add Employee",
            typeof(CustomCommands)
        );

        public static readonly RoutedUICommand RemoveEmployee = new(
            "Remove Employee",
            "Remove Employee",
            typeof(CustomCommands),
            new InputGestureCollection {
                new KeyGesture(Key.Delete),
            }
        );

        public static readonly RoutedUICommand FilterByName = new(
            "Filter by Name Part",
            "Filter by Name Part",
            typeof(CustomCommands));

        public static readonly RoutedUICommand FilterByJobTitle = new(
            "Filter by Job Title Part",
            "Filter by Job Title Part",
            typeof(CustomCommands));

        public static readonly RoutedUICommand FilterByGender = new(
            "Filter by Gender Equals to...",
            "Filter by Gender Equals to...",
            typeof(CustomCommands));

        public static readonly RoutedUICommand FilterByYearOfBirth = new(
            "Filter by Year of Birth Equals to...",
            "Filter by Year of Birth Equals to...",
            typeof(CustomCommands));

        public static readonly RoutedUICommand FilterByYearOfEmployment = new(
            "Filter by Year of Employment Equals to...",
            "Filter by Year of Employment Equals to...",
            typeof(CustomCommands));
    }
}
