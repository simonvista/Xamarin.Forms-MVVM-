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

        //public ObservableCollection<string> Employees { get; set; }
        public ObservableCollection<Employee> Employees { get; set; }

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

             //Employees = new ObservableCollection<string>();
             Employees = new ObservableCollection<Employee>();
             //Employees.Add("Rob Finnerty");
             //Employees.Add("Bill Wrestler");
             //Employees.Add("Geri-Beth Hooper");
             //Employees.Add("Keith Joyce-Purdy");
             //Employees.Add("Sheri Spruce");
             //Employees.Add("Burt Indybrick");
             Employees.Add(new Employee(1, "Rob Finnerty","CEO","img1.jpg"));
             Employees.Add(new Employee(2, "Bill Wrestler", "Director", "img2.jpg"));
             Employees.Add(new Employee(3, "Geri-Beth Hooper", "Delivery Manager", "img3.jpg"));
             Employees.Add(new Employee(4, "Keith Joyce-Purdy", "Project Manager", "img4.jpg"));
             Employees.Add(new Employee(5, "Sheri Spruce", "Sr. Software Engineer", "img5.jpg"));
             Employees.Add(new Employee(6, "Burt Indybrick", "Software Engineer", "img6.jpg"));
        }

        public void AddEmployee()
        {
            //Employees.Add(EmployeeName);
        }

        public void RemoveEmployee()
        {
            //Employees.Remove(SelectedEmpName);
        }

        public void UpdateEmployee()
        {
            //int selectedIdx = Employees.IndexOf(SelectedEmpName);
            //RemoveEmployee();
            //Employees.Add(EmployeeName);
            //int addedIdx = Employees.Count - 1;
            //Employees.Move(addedIdx,selectedIdx);
        }
    }
}
