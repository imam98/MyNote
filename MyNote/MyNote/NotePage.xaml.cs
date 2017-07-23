using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MyNote.DataModels;

namespace MyNote
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class NotePage : ContentPage
	{
        private bool isNew;
        private Note mNote;

		public NotePage ()
		{
			InitializeComponent ();
            isNew = false;
		}

        public NotePage(Note note)
        {
            InitializeComponent();
            mNote = note;
            TitleEntry.Text = note.Title;
            NoteEditor.Text = note.Content;
            isNew = true;
        }

        protected override async void OnDisappearing()
        {
            

            var title = TitleEntry.Text;
            var content = NoteEditor.Text;
            if (!String.IsNullOrEmpty(title) || !String.IsNullOrEmpty(content))
            {
                bool save = await DisplayAlert("Save Changes?", "Do you want to save these changes?", "Yes", "No");
                if (save)
                {
                    try
                    {
                        if (isNew)
                        {
                            Note note = new Note
                            {
                                Title = title,
                                Content = content,
                                Created = DateTime.Now
                            };
                            App.DBUtils.SaveNote(note);
                            MainPage.ListOfNotes = App.DBUtils.GetNotesList();
                        }
                        else
                        {
                            mNote.Title = title;
                            mNote.Content = content;
                            App.DBUtils.UpdateNote(mNote);
                        }
                    }
                    catch (Exception ex)
                    {
                        await DisplayAlert("ERROR", ex.Message, "OK");
                    }
                }
            }

            base.OnDisappearing();
        }
    }
}
