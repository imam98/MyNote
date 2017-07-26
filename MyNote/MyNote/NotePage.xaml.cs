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

        public NotePage()
        {
            InitializeComponent();
            isNew = true;
            BackBtn.IsVisible = (Device.Idiom == TargetIdiom.Desktop) ? true : false;
        }

        public NotePage(Note note)
        {
            InitializeComponent();
            mNote = note;
            TitleEntry.Text = note.Title;
            NoteEditor.Text = note.Content;
            isNew = false;
            BackBtn.IsVisible = (Device.Idiom == TargetIdiom.Desktop) ? true : false;
        }

        protected override bool OnBackButtonPressed()
        {
            var title = TitleEntry.Text;
            var content = NoteEditor.Text;

            Device.BeginInvokeOnMainThread(async () =>
            {
                if (isNew)
                {
                    if (!String.IsNullOrEmpty(title) || !String.IsNullOrEmpty(content))
                    {
                        await save(title, content);
                    }
                }
                else
                {
                    if (mNote.Title != title || mNote.Content != content)
                    {
                        await save(title, content);
                    }
                }

                base.OnBackButtonPressed();
            });

            return true;
        }

        private async Task save(string title, string content)
        {
            var accept = await DisplayAlert("Save Changes?", "Do you want to save these changes?", "Yes", "No");
            if (accept)
            {
                if (isNew)
                {
                    mNote = new Note()
                    {
                        Title = title,
                        Content = content,
                        Created = DateTime.Now
                    };
                    App.DBUtils.SaveNote(mNote);
                }
                else
                {
                    mNote.Title = title;
                    mNote.Content = content;
                    App.DBUtils.UpdateNote(mNote);
                }
            }
        }

        private void OnBackBtn_Clicked(object sender, EventArgs e)
        {
            OnBackButtonPressed();
        }
    }
}
