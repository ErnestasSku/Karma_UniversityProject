﻿using MobileUI.Models;
using MobileUI.ViewModels;
using System;
using System.Linq;
using Xamarin.Forms;

namespace MobileUI.Views
{
    public partial class MainPage : ContentPage
    {
        //Still breaks for being null
        public DataBase.Models.Item currentItem = App.Items.First();
        public DataBase.Models.Item previousItem;
        
        public MainPage()
        {
            InitializeComponent();
            
        }
        private async void Item_Tapped(object sender, EventArgs e)
        {
            ItemDetailPageViewModel.Name = currentItem.Name;
            ItemDetailPageViewModel.Description = currentItem.Description;
            ItemDetailPageViewModel.Img = currentItem.Image;
            await HomePage.Navigation.PushAsync(new ItemDetailPage()); 
        }
        void OnCurrentItemChanged(object sender, CurrentItemChangedEventArgs e)
        {
            previousItem = e.PreviousItem as DataBase.Models.Item;
            currentItem = e.CurrentItem as DataBase.Models.Item;
        }
    }
}
