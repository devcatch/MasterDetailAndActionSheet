using System;
using Xamarin.Forms;
using System.Threading.Tasks;
using System.Threading;

namespace MasterDetailAndActionSheet.Shared
{
    public class MenuMasterDetailPage : MasterDetailPage
    {
        public MenuMasterDetailPage ()
        {
            var mapPage = new ContentPage()
            {
                BackgroundColor = Color.Red
            };

            var logout = new Button { 
                Text = "Log ud",
                VerticalOptions = LayoutOptions.StartAndExpand
            };

            logout.Clicked += async (sender, e) => {
                var action = await ShowDialogWithDiferentParamsForEachPlatform ();

                if (action == "Logout")
                {
                    Master.Title = action;
                }
            };

            Master = new ContentPage {
                Title = "Menu",
                Content = new StackLayout {
                    Padding = 20,
                    Children = {
                        new Label { Text = "Hello Master" },
                        logout
                    }
                }
            };

            Detail = new NavigationPage (mapPage);
        }

        async Task<string> ShowDialogWithDiferentParamsForEachPlatform ()
        {
            return await DisplayActionSheet(
#if __IOS__
                null, "Logout", "Cancel"
#endif
#if __ANDROID__
"Are You shure?", null, null, "Cancel", "Logout"
#endif
#if WINDOWS_PHONE
"Are You shure?", "Logout", "Cancel"
#endif
);
        }
    }
}


