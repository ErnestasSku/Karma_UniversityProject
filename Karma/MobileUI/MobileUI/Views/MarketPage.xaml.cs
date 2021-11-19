﻿using MobileUI.Models;
using MobileUI.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileUI.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MarketPage : ContentPage
    {
        public MarketPage()
        {
            InitializeComponent();

        }
        public async void Item_Tapped(object sender, ItemTappedEventArgs e)
        {
            var item = ((ListView)sender).SelectedItem as Item;
            if (item == null)
                return;

            ((ListView)sender).SelectedItem = null;
            ItemDetailPageViewModel.Name = item.Name;
            ItemDetailPageViewModel.Description = item.Description;
            ItemDetailPageViewModel.Img = item.ImgSource;
            await ItemPage.Navigation.PushAsync(new ItemDetailPage());
        }
    }
}