using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using MyNote.DataModels;

namespace MyNote
{
    public partial class MainPage : ContentPage
    {
        private List<Note> ListOfNotes;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnAddNote_Clicked(object sender, EventArgs e)
        {
            var notePage = new NotePage();
            await Navigation.PushModalAsync(notePage);
        }

        private async void OnNote_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                var note = (Note)e.SelectedItem;
                var notePage = new NotePage(note);
                await Navigation.PushModalAsync(notePage);
                ((ListView)sender).SelectedItem = null;
            }
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            ListOfNotes = App.DBUtils.GetNotesList();
            NotesList.ItemsSource = ListOfNotes;
        }
    }
}
