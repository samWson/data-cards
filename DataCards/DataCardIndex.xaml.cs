using System;
using DataCards.Models;
using Xamarin.Forms;

namespace DataCards
{
    public partial class DataCardIndex : ContentPage
    {
        public DataCardIndex()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            // TODO: Set up list view of Data Cards here.
            // i.e. grab them from the database.
        }

        async void OnDataCardAddedClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DataCardNew
            {
                BindingContext = new DataCard()
            });
        }

        async void OnDataCardListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new DataCardNew
                {
                    BindingContext = e.SelectedItem as DataCard
                });
            }
        }
    }
}
