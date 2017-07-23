using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using SQLite.Net;
using MyNote.UWP;
using Xamarin.Forms;

[assembly: Dependency(typeof(SQLiteServiceUWP))]
namespace MyNote.UWP
{
    public class SQLiteServiceUWP : ISQLite
    {
        public SQLiteConnection GetConnection()
        {
            string DocumentPath = Windows.Storage.ApplicationData.Current.LocalFolder.Path;
            string DatabasePath = Path.Combine(DocumentPath, "SavedNotes.db3");

            if (!File.Exists(DatabasePath))
                File.Create(DatabasePath);

            var platform = new SQLite.Net.Platform.WinRT.SQLitePlatformWinRT();
            var connection = new SQLiteConnection(platform, DatabasePath);
            return connection;
        }
    }
}
