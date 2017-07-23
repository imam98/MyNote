using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace MyNote
{
	public partial class App : Application
	{
        private static DataServices dbUtils;

		public App ()
		{
			InitializeComponent();

			MainPage = new NavigationPage(new MyNote.MainPage());
		}

        public static DataServices DBUtils
        {
            get
            {
                if (dbUtils == null)
                {
                    dbUtils = new DataServices();
                }
                return dbUtils;
            }
        }

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
