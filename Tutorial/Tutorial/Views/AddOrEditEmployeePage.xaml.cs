using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tutorial
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AddOrEditEmployeePage : ContentPage
	{
		public AddOrEditEmployeePage ()
		{
			InitializeComponent ();
		}

        private void Button_OnClicked(object sender, EventArgs e)
        {
            Employee employee = ((AddOrEditEmployeeViewModel) BindingContext).Employee;
            //use MassagingCenter to pass employee to EmployeeListViewModel. Publisher send message to subscriber.
            if (employee.EmployeeId==0)
            {
                employee.PictureUrl = "img7.jpg";
            }
            MessagingCenter.Send(this, "AddOrEditEmployee", employee);
            Navigation.PopAsync();
        }
    }
}