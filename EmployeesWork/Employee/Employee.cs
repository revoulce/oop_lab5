// 
// Created by letih on 01/08/2021
//

using System.ComponentModel;
using System.Runtime.CompilerServices;
using EmployeesWork.Specification;

namespace EmployeesWork.Employee {
    /// <summary>
    /// Representation of Employee
    /// </summary>
    public class Employee : INotifyPropertyChanged {
        private string _gender;
        private string _jobTitle;
        private string _name;
        private int _yearOfBirth;
        private int _yearOfEmployment;

        public Employee() {
            Id = default;
            Name = default;
            JobTitle = default;
            Gender = default;
            YearOfBirth = default;
            YearOfEmployment = default;
        }

        public Employee(int id, string name, string jobTitle, string gender, int yearOfBirth, int yearOfEmployment) {
            Id = id;
            Name = name;
            JobTitle = jobTitle;
            Gender = gender;
            YearOfBirth = yearOfBirth;
            YearOfEmployment = yearOfEmployment;
        }

        public int Id { get; init; }

        public string Name {
            get => _name;

            set {
                _name = value;
                NotifyPropertyChanged(nameof(Name));
            }
        }

        public string JobTitle {
            get => _jobTitle;

            set {
                _jobTitle = value;
                NotifyPropertyChanged(nameof(JobTitle));
            }
        }

        public string Gender {
            get => _gender;

            set {
                _gender = value;
                NotifyPropertyChanged(nameof(Gender));
            }
        }

        public int YearOfBirth {
            get => _yearOfBirth;

            set {
                _yearOfBirth = value;
                NotifyPropertyChanged(nameof(YearOfBirth));
            }
        }

        public int YearOfEmployment {
            get => _yearOfEmployment;

            set {
                _yearOfEmployment = value;
                NotifyPropertyChanged(nameof(YearOfEmployment));
            }
        }

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        /// <summary>
        /// Оповещает систему об изменившемся поле.
        /// </summary>
        /// <param name="propertyName">Название изменившегося поля.</param>
        [NotifyPropertyChangedInvocator]
        private void NotifyPropertyChanged([CallerMemberName] [CanBeNull] string propertyName = null) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
