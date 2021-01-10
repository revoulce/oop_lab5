// 
// Created by letih on 01/10/2021
// 

using System;
using System.Windows.Input;
using EmployeesWork.Specification;

namespace EmployeesWork.Utility {
    public class RelayCommand : ICommand {
        private Func<object, bool> canExecute;
        private Action<object> execute;

        public RelayCommand(Action<object> execute, [CanBeNull] Func<object, bool> canExecute = null) {
            this.execute = execute;
            this.canExecute = canExecute;
        }

        #region ICommand Members

        public event EventHandler CanExecuteChanged {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }

        public bool CanExecute(object parameter) {
            return canExecute?.Invoke(parameter) != false;
        }

        public void Execute(object parameter) {
            execute(parameter);
        }

        #endregion
    }
}
