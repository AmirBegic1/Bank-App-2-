using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BankApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registration : ContentPage
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (txtPassword.Text == txtPassword2.Text)
            {
                DisplayAlert("USPJESNO REGISTROVAN!", "Registracijom prihvatate sve uslove korištenja!", "Ok");
                Navigation.PushAsync(new MyFlyoutPage());
            }
            else
            {
                DisplayAlert("GREŠKA", "Password-i nisu isti!", "Ok");
                
            }
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LoginPage());
        }
    }
}