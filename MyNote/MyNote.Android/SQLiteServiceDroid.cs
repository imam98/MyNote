using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SQLite;
using SQLite.Net;
using Xamarin.Forms;
using MyNote.Droid;

[assembly: Dependency(typeof(SQLiteServiceDroid))]
namespace MyNote.Droid
{
    public class SQLiteServiceDroid : ISQLite
    {
        public SQLiteConnection GetConnection()
        {
            string DocumentPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            string DatabasePath = Path.Combine(DocumentPath, "SavedNotes.db3");

            if (!File.Exists(DatabasePath))
                File.Create(DatabasePath);

            var platform = new SQLite.Net.Platform.XamarinAndroid.SQLitePlatformAndroid();
            var connection = new SQLite.Net.SQLiteConnection(platform, DatabasePath);
            return connection;
        }
    }
}