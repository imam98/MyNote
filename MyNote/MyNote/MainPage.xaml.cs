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
		public MainPage()
		{
			InitializeComponent();
            BindingContext = new ListOfNotes();
		}

        private async void OnAddNote_Clicked(object sender, EventArgs e)
        {
            var notePage = new NotePage();
            await Navigation.PushModalAsync(notePage);
        }
	}

    public class ListOfNotes : BindableObject
    {
        private List<Note> notesList;
        public List<Note> NotesList
        {
            get { return notesList; }
            set { notesList = value; OnPropertyChanged("NotesList"); }
        }

        public ListOfNotes()
        {
            notesList = new List<Note>
            {
                new Note {Title = "ABC", NotePreview = "aeddasaesnxsian\njliuok\njuhy", Created = DateTime.Now},
                new Note {Title = "ASE", NotePreview = "tersuasnxiebwisawsadsidnijonxknaskoqwokskalmxnkalnonwpoqjejifndoewiriojdnsclnlalswqo", Created = DateTime.Now},
                new Note {Title = "ASE", NotePreview = "tersuasnxiebwisawsadsidnijonxknaskoqwokskalmxnkalnonwp papsdkxkjdoiewojx aspdkoewodjdncweodjasodkwjsmax sdfedacaswdersdcdsda", Created = DateTime.Now}
            };
        }
    }
}
