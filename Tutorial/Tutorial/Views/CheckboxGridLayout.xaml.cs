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
	public partial class CheckboxGridLayout : ContentPage
	{
		public CheckboxGridLayout ()
		{
			InitializeComponent ();
		}

        private void CbXF_OnCheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            //lblCB.Text="checkbox value toggled";
            if (e.Value==true)
            {
                lblCB.Text = "checked - yes, I'm a Xamarin fan";
            }
            else
            {
                lblCB.Text = "unchecked - nope, I am not a Xamarin fan";
            }
        }
    }
}