using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace MasterDetailAndActionSheet.Shared
{
	public class App : Application
	{
		public App ()
		{
			// The root page of your application
            
            var button = new Button { Text = "New root"};
                        var contenPage = new ContentPage()
            {
                Content = new StackLayout()
                {
                    Padding = 20,
                    Children = { button }
                }
            };

            button.Clicked += (sender, e) =>
            {
                MainPage = new MenuMasterDetailPage();
            };



            MainPage = contenPage;

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
