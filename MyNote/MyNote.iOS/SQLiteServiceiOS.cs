using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using SQLite;
using SQLite.Net;
using MyNote.iOS;
using Xamarin.Forms;

[assembly: Dependency(typeof(SQLiteServiceiOS))]
namespace MyNote.iOS
{
    public class SQLiteServiceiOS : ISQLite
    {
        public SQLiteConnection GetConnection()
        {
            string DocumentPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            string DatabasePath = Path.Combine(DocumentPath, "SavedNotes.db3");

            if (!File.Exists(DatabasePath))
                File.Create(DatabasePath);

            var platform = new SQLite.Net.Platform.XamarinIOS.SQLitePlatformIOS();
            var connection = new SQLiteConnection(platform, DatabasePath);
            return connection;
        }
    }
}
