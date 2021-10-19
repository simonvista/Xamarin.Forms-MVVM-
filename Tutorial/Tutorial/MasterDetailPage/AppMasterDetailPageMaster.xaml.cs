using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tutorial
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AppMasterDetailPageMaster : ContentPage
    {
        public ListView ListView;

        public AppMasterDetailPageMaster()
        {
            InitializeComponent();

            BindingContext = new AppMasterDetailPageMasterViewModel();
            ListView = MenuItemsListView;
        }

        class AppMasterDetailPageMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<AppMasterDetailPageMenuItem> MenuItems { get; set; }
            
            public AppMasterDetailPageMasterViewModel()
            {
                MenuItems = new ObservableCollection<AppMasterDetailPageMenuItem>(new[]
                {
                    new AppMasterDetailPageMenuItem { Id = 0, Title = "Labels",TargetType = typeof(Labels)},
                    new AppMasterDetailPageMenuItem { Id = 1, Title = "Entries",TargetType = typeof(Entries)},
                    new AppMasterDetailPageMenuItem { Id = 2, Title = "Buttons",TargetType = typeof(Buttons)},
                    new AppMasterDetailPageMenuItem { Id = 3, Title = "Images",TargetType = typeof(Images)},
                    //new AppMasterDetailPageMenuItem { Id = 4, Title = "Page 5" },
                    new AppMasterDetailPageMenuItem { Id = 4, Title = "EnrollStudentPage",TargetType = typeof(EnrollStudentPage)},
                    new AppMasterDetailPageMenuItem { Id = 5, Title = "EmployeeListPage", TargetType = typeof(EmployeeListPage)},
                    new AppMasterDetailPageMenuItem { Id = 6, Title = "BehaviorsPage",TargetType = typeof(BehaviorsPage)},
                });
            }
            
            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}