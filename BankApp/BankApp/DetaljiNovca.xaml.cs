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
    public partial class DetaljiNovca : ContentPage
    {
        public DetaljiNovca()
        {
            InitializeComponent();
        }


        int number;
        private void Button_Clicked(object sender, EventArgs e)
        {

            number = int.Parse(txtBalans.Text);
            App.finalni_balans += number;

            DisplayAlert("USPJEŠNO", "Vaš balans iznosi: " + App.finalni_balans, " OK");

            Navigation.PushAsync(new HomePage());
        }
    }
}