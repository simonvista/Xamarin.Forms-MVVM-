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
	public partial class Entries : ContentPage
	{
		public Entries ()
		{
			InitializeComponent ();
            enterAppName.Text = "Curious drive";
        }

        private void Entry_OnCompleted(object sender, EventArgs e)
        {
            lblCompleted.Text=((Entry) sender).Text;
        }

        private void InputView_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            lblTextChangedPre.Text=e.OldTextValue;
            lblTextChangedCur.Text = e.NewTextValue;
        }
    }
}