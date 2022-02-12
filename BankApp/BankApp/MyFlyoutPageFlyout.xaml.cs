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

namespace BankApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyFlyoutPageFlyout : ContentPage
    {
        public ListView ListView;

        public MyFlyoutPageFlyout()
        {
            InitializeComponent();

            BindingContext = new MyFlyoutPageFlyoutViewModel();
            ListView = MenuItemsListView;
        }

        class MyFlyoutPageFlyoutViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<MyFlyoutPageFlyoutMenuItem> MenuItems { get; set; }

            public MyFlyoutPageFlyoutViewModel()
            {
                MenuItems = new ObservableCollection<MyFlyoutPageFlyoutMenuItem>(new[]
                {
                    new MyFlyoutPageFlyoutMenuItem { Id = 0, Title = "Home Page", TargetType=typeof(HomePage)},
                    new MyFlyoutPageFlyoutMenuItem { Id = 1, Title = "Balans", TargetType=typeof(DetaljiNovca) },
                    new MyFlyoutPageFlyoutMenuItem { Id = 2, Title = "Transkacije", TargetType=typeof(Transakcije) },
                    new MyFlyoutPageFlyoutMenuItem { Id = 3, Title = "Konvektori Valuta", TargetType=typeof(konvektor)},
                    new MyFlyoutPageFlyoutMenuItem { Id = 4, Title = "Pomoć", TargetType=typeof(Pomoc)},
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