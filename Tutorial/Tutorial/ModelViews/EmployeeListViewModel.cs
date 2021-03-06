using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Tutorial.Annotations;
using Xamarin.Forms;

namespace Tutorial
{
    //public class EmployeeListViewModel
    public class EmployeeListViewModel : INotifyPropertyChanged
    {
        //approach 2: w/o model is not good-can not alter employeeList
        //public string[] Employees { get; set; }

        //approach 3: alter employeeList by ObservableCollection<string>
        //ObservableCollection<string> will update UI if new string is added to ObservableCollection<string> 
        //We don't need INotifyPropertyChange w/ ObservableCollection<string>!!!

        //public ObservableCollection<string> Employees { get; set; }
        //public ObservableCollection<Employee> Employees { get; set; }

        private ObservableCollection<Employee> _employees;
        public ObservableCollection<Employee> Employees
        {
            get { return _employees; }
            set
            {
                _employees = value;
                OnPropertyChanged();
            }
        }

        public string EmployeeName { get; set; }
        public ICommand AddEmployeeCommand => new Command(AddEmployee);

        public string SelectedEmpName { get; set; }
        public ICommand RemoveEmployeeCommand => new Command(RemoveEmployee);
        public ICommand UpdateEmployeeCommand => new Command(UpdateEmployee);

        public ICommand SearchCommand => new Command<string>(LoadEmployeesAsync1);

        private bool _isBusy;
        public bool IsBusy
        {
            get { return _isBusy; }
            set
            {
                _isBusy = value;
                OnPropertyChanged();
            }
        }

        public EmployeeListViewModel()
        {
            //Employees = new string[]
            //{
            //    "Rob Finnerty", "Bill Wrestler","Geri-Beth Hooper","Keith Joyce-Purdy","Sheri Spruce","Burt Indybrick"
            //};

            //Employees = new ObservableCollection<string>();
            //Employees.Add("Rob Finnerty");
            //Employees.Add("Bill Wrestler");
            //Employees.Add("Geri-Beth Hooper");
            //Employees.Add("Keith Joyce-Purdy");
            //Employees.Add("Sheri Spruce");
            //Employees.Add("Burt Indybrick");

            //Employees = new ObservableCollection<Employee>();
            //Employees.Add(new Employee(1, "Rob Finnerty","CEO","img1.jpg"));
            // Employees.Add(new Employee(2, "Bill Wrestler", "Director", "img2.jpg"));
            // Employees.Add(new Employee(3, "Geri-Beth Hooper", "Delivery Manager", "img3.jpg"));
            // Employees.Add(new Employee(4, "Keith Joyce-Purdy", "Project Manager", "img4.jpg"));
            // Employees.Add(new Employee(5, "Sheri Spruce", "Sr. Software Engineer", "img5.jpg"));
            // Employees.Add(new Employee(6, "Burt Indybrick", "Software Engineer", "img6.jpg"));

            //Employees = new EmployeeService().GetEmployees();
            //Task.Run(async () =>
            //{
            //    Employees= await new EmployeeService().GetEmployees();
            //});
            LoadEmplyeesAsync();

             MessagingCenter.Subscribe<AddOrEditEmployeePage,Employee>(
                 this, 
                 "AddOrEditEmployee",
                 (sender, employee) =>
                 {
                     //new employee
                     if (employee.EmployeeId == 0)
                     {
                         employee.EmployeeId = Employees.Count+1;
                         Employees.Add(employee);
                     }
                     //update employee
                     else
                     {
                        Employee empToEdit=Employees.Where(
                            emp=>emp.EmployeeId==employee.EmployeeId).FirstOrDefault();
                        int idxToEdit=Employees.IndexOf(empToEdit);
                        Employees.Remove(empToEdit);
                        Employees.Add(employee);
                        int oldIdx = Employees.IndexOf(employee);
                        Employees.Move(oldIdx,idxToEdit);
                     }
                 });
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

        public void LoadEmplyeesAsync()
        {
            IsBusy = true;
            Task.Run(async () =>
            {
                Employees = await new EmployeeService().GetEmployees();
                IsBusy = false;
            });
            
        }

        private void LoadEmployeesAsync1(string query)
        {
            IsBusy=true;
            Task.Run(async () =>
            {
                Employees = await new EmployeeService().GetEmployeesAsync(query);
                IsBusy = false;
            });
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
