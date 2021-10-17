using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tutorial
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Buttons : ContentPage
    {
        public ICommand CommandClicked => new Command(OnClicked);
        public ICommand CommandParamClicked => new Command<string>(OnParamClick);

        public Buttons()
        {
            InitializeComponent();
            BindingContext = this;
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            lblSBC.Text="simple button clicked";
        }

        private void OnClicked()
        {
            lblCBC.Text = "Command button clicked";
        }

        private void OnParamClick(string str)
        {
            lblCPBC.Text = "Command parameter button clicked by " + str;
        }
    }
}