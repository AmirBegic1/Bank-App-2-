﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BankApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyFlyoutPageDetail : ContentPage
    {
        public MyFlyoutPageDetail()
        {
            InitializeComponent();

            

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Transakcije());
        }
    }
}