using System;

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
            // TODO: Write to database. Reference: https://docs.microsoft.com/en-us/xamarin/get-started/quickstarts/multi-page?pivots=macos
            // NoteEntryPage.xaml.cs
            Console.WriteLine("OnSaveButtonClicked event");
            await Navigation.PopAsync();
        }
    }
}
