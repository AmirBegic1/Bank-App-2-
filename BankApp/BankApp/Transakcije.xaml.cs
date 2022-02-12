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
    public partial class Transakcije : ContentPage
    {
        public Transakcije()
        {
            InitializeComponent();
        }
        int number;
        private void Button_Clicked(object sender, EventArgs e)
        {
            number = int.Parse(Druga.Text);

            App.finalni_balans -= number;

            DisplayAlert("Uspjesno!", "Vas balans sada iznosi " + App.finalni_balans, "Ok");
            
        }
    }
}