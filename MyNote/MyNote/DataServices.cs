using System;
using System.Collections.Generic;
using System.Text;
using MyNote.DataModels;
using SQLite.Net;
using Xamarin.Forms;

namespace MyNote
{
    public class DataServices
    {
        SQLiteConnection dbConn;

        public DataServices()
        {
            dbConn = DependencyService.Get<ISQLite>().GetConnection();
            dbConn.CreateTable<Note>();
        }

        public List<Note> GetNotesList()
        {
            return dbConn.Query<Note>("SELECT * FROM [Note] ORDER BY [Created]");
        }

        public int SaveNote(Note note)
        {
            return dbConn.Insert(note);
        }

        public int UpdateNote(Note note)
        {
            return dbConn.Update(note);
        }

        public int DeleteNote(Note note)
        {
            return dbConn.Delete(note);
        }
    }
}
