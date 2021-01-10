using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Microsoft.Win32;

namespace EmployeesWork {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow {
        public MainWindow() {
            InitializeComponent();

            DataContext = new ApplicationViewModel();
        }

        private void Exit_OnExecuted(object sender, ExecutedRoutedEventArgs e) {
            Application.Current.Shutdown();
        }

        private void Open_OnExecuted(object sender, ExecutedRoutedEventArgs e) {
            var openFileDialog = new OpenFileDialog {
                Filter = "JSON file (*.json)|*.json|All files (*.*)|*.*",
                InitialDirectory = Environment.CurrentDirectory,
            };

            if (openFileDialog.ShowDialog() != true) {
                return;
            }

            var jsonSerializer = new DataContractJsonSerializer(typeof(List<Employee.Employee>));

            using var fileStream = new FileStream(openFileDialog.FileName, FileMode.OpenOrCreate);

            if (!(jsonSerializer.ReadObject(fileStream) is List<Employee.Employee> employees)) {
                return;
            }

            ((ApplicationViewModel) DataContext).Employees.Clear();

            foreach (var employee in employees) {
                ((ApplicationViewModel) DataContext).Employees.Add(employee);
            }
        }

        private void Save_OnExecuted(object sender, ExecutedRoutedEventArgs e) {
            var saveFileDialog = new SaveFileDialog {
                Filter = "JSON file (*.json)|*.json|All files (*.*)|*.*",
                InitialDirectory = Environment.CurrentDirectory,
            };

            if (saveFileDialog.ShowDialog() != true) {
                return;
            }

            var jsonSerializer = new DataContractJsonSerializer(typeof(List<Employee.Employee>));

            using var fileStream = new FileStream(saveFileDialog.FileName, FileMode.OpenOrCreate);

            jsonSerializer.WriteObject(fileStream, ((ApplicationViewModel) DataContext).Employees.ToList());
        }

        private void AddEmployee_OnExecuted(object sender, ExecutedRoutedEventArgs e) {
            var employee = new Employee.Employee();

            ((ApplicationViewModel) DataContext).Employees.Add(employee);
            ((ApplicationViewModel) DataContext).SelectedEmployee = employee;
        }

        private void RemoveEmployee_OnExecuted(object sender, ExecutedRoutedEventArgs e) {
            if (sender is Employee.Employee employee) {
                ((ApplicationViewModel) DataContext).Employees.Remove(employee);
            }
        }

        private void CommandBinding_OnCanExecute(object sender, CanExecuteRoutedEventArgs e) {
            e.CanExecute = true;
        }

        private void EmployeeDataGrid_OnSelectionChanged(object sender, SelectionChangedEventArgs e) {
            if (!(sender is DataGrid dataGrid) || dataGrid.SelectedItem == null) {
                return;
            }

            dataGrid.Dispatcher.InvokeAsync(() => {
                dataGrid.UpdateLayout();
                dataGrid.ScrollIntoView(dataGrid.SelectedItem, null);
            });
        }
    }
}
