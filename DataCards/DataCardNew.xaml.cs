using System;
using DataCards.Models;
using Xamarin.Forms;

namespace DataCards
{
    public partial class DataCardNew : ContentPage
    {
        public DataCardNew()
        {
            InitializeComponent();
        }

        async void OnSaveButtonClicked(object sender, EventArgs e)
        {
            using (var context = new DataCardContext(App.DbPath))
            {
                var datacard = (DataCard)BindingContext;
                await context.DataCards.AddAsync(datacard);
                await context.SaveChangesAsync();
            }

            // FIXME: remove this debugging code once confident that this method works.
            Console.WriteLine("OnSaveButtonClicked event");
            await Navigation.PopAsync();
        }
    }
}
