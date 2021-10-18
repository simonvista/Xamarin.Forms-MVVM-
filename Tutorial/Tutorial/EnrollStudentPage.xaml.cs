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
    public partial class EnrollStudentPage : ContentPage
    {
        public EnrollStudentPage()
        {
            InitializeComponent();
        }

        private void BtnSubmit_OnClicked(object sender, EventArgs e)
        {
            lblDisplayMsg.Text = entName.Text
                                 + ", we sent verification link to "
                                 + entEmail.Text
                                 + ". Please verify your account";

        }
    }
}