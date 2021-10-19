using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Tutorial
{
    class EmployeeListViewModel
    {
        //approach 2: w/o model is not good-can not alter employeeList
        //public string[] Employees { get; set; }

        //approach 3: alter employeeList by ObservableCollection<string>
        //ObservableCollection<string> will update UI if new string is added to ObservableCollection<string> 
        //We don't need INotifyPropertyChange w/ ObservableCollection<string>!!!
        public ObservableCollection<string> Employees { get; set; }

        public string EmployeeName { get; set; }
        public ICommand AddEmployeeCommand => new Command(AddEmployee);

        public string SelectedEmpName { get; set; }
        public ICommand RemoveEmployeeCommand => new Command(RemoveEmployee);
        public ICommand UpdateEmployeeCommand => new Command(UpdateEmployee);

        public EmployeeListViewModel()
        {
             //Employees = new string[]
             //{
             //    "Rob Finnerty", "Bill Wrestler","Geri-Beth Hooper","Keith Joyce-Purdy","Sheri Spruce","Burt Indybrick"
             //};

             Employees = new ObservableCollection<string>();
             Employees.Add("Rob Finnerty");
             Employees.Add("Bill Wrestler");
             Employees.Add("Geri-Beth Hooper");
             Employees.Add("Keith Joyce-Purdy");
             Employees.Add("Sheri Spruce");
             Employees.Add("Burt Indybrick");
        }

        public void AddEmployee()
        {
            Employees.Add(EmployeeName);
        }

        public void RemoveEmployee()
        {
            Employees.Remove(SelectedEmpName);
        }

        public void UpdateEmployee()
        {
            int selectedIdx = Employees.IndexOf(SelectedEmpName);
            RemoveEmployee();
            Employees.Add(EmployeeName);
            int addedIdx = Employees.Count - 1;
            Employees.Move(addedIdx,selectedIdx);
        }
    }
}
