﻿using SlimGym.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SlimGym
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        public async void Clicked_ButtonAsync(object sender, EventArgs e)
        {
            User user = new User(Entry_username.Text, Entry_password.Text);
            if (user.CheckInformation().Equals(true))

                await Navigation.PushAsync(new MenuFeature());
            else
                await DisplayAlert("Login", "Login unsuccessful,wrong username or password", "Oke");
        }
    }
}
