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
	public partial class Images : ContentPage
	{
		public Images ()
		{
			InitializeComponent ();
		}

        private void ImageButton_OnClicked(object sender, EventArgs e)
        {
            lblImg.Text="Image button was clicked";
        }
    }
}