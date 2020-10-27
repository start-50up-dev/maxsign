﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace RealWorldApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void BtnSave_Clicked(object send, EventArgs e)
        {
            Preferences.Set("username", EntUserName.Text);
        }

        private void BtnRetrieve_Clicked(object send, EventArgs e)
        {
            var response = Preferences.Get("username", string.Empty);
            LblUserName.Text = response;
        }

    }
}
