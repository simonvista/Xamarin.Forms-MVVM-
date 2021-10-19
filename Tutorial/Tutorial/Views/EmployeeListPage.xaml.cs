using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tutorial
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EmployeeListPage : ContentPage
    {
        public EmployeeListPage()
        {
            InitializeComponent();
            //1st approach: ItemsSource is not good
            //lvEmployees.ItemsSource = new string[]
            //{
            //    "Rob Finnerty", "Bill Wrestler","Geri-Beth Hooper","Keith Joyce-Purdy","Sheri Spruce","Burt Indybrick"
            //};
        }

        private void MenuItem_OnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AddOrEditEmployeePage());
        }
        //edit
        private void TapGestureRecognizer_OnTapped(object sender, EventArgs e)
        {
            var tappedEventArgs = (TappedEventArgs)e;
            //Debug.WriteLine("Hello "+tappedEventArgs.Parameter);  //employeeId
            Employee selectedEmployee = 
                ((EmployeeListViewModel) BindingContext).Employees.Where(
                    emp => emp.EmployeeId ==(int) tappedEventArgs.Parameter).FirstOrDefault();
            Navigation.PushAsync(new AddOrEditEmployeePage(selectedEmployee));
        }
        //delete
        private void TapGestureRecognizer_OnTapped2(object sender, EventArgs e)
        {
            var tappedEventArgs2 = (TappedEventArgs) e;
            Employee empToDelete=((EmployeeListViewModel) BindingContext).Employees.Where(
                amp => amp.EmployeeId == (int) tappedEventArgs2.Parameter).FirstOrDefault();
            ((EmployeeListViewModel) BindingContext).Employees.Remove(empToDelete);

        }
    }
}