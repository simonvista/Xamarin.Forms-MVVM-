using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Tutorial.Annotations;
using Xamarin.Forms;

namespace Tutorial
{
    public class EnrollStudentViewModel : INotifyPropertyChanged
    {
        //same properties as corresponding UI, EnrollStudentPage.xaml
        //we need to create properties as entName, entEmail, swFS
        public string FullName { get; set; }
        public string Email { get; set; }
        public bool IsForeign { get; set; }
        public string DisplayMsg { get; set; }
        public ICommand SubmitCommand => new Command(OnSubmit);
        public void OnSubmit()
        {
            DisplayMsg =
                FullName
                + "we've send you verification link to "
                + Email
                + " .Please check it in inbox and confirm";
            OnPropertyChanged(nameof(DisplayMsg));
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
