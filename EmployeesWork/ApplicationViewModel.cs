// 
// Created by letih on 01/10/2021
// 

using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using EmployeesWork.Specification;

namespace EmployeesWork {
    public class ApplicationViewModel : INotifyPropertyChanged {
        private string _pattern;
        private Employee.Employee _selectedEmployee;

        public ApplicationViewModel() {
            Employees = new ObservableCollection<Employee.Employee>();
        }

        public ObservableCollection<Employee.Employee> Employees { get; set; }

        public string Pattern {
            get => _pattern;

            set {
                _pattern = value;
                OnPropertyChanged(nameof(Pattern));

                SelectedEmployee = Employees.FirstOrDefault(employee =>
                    employee.Name.StartsWith(Pattern, StringComparison.Ordinal));
            }
        }

        public Employee.Employee SelectedEmployee {
            get => _selectedEmployee;

            set {
                _selectedEmployee = value;
                OnPropertyChanged(nameof(SelectedEmployee));
            }
        }

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
