using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace App1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();


            MainPage = new NavigationPage(new App1.LogInPage());
            //MainPage = new ContentPage
            //{
            //    Content = new StackLayout
            //    {
            //        VerticalOptions = LayoutOptions.Center,
            //        Children = {
            //      new Label {
            //         HorizontalTextAlignment = TextAlignment.Center,
            //         Text = "Welcome to Xamarin Forms!"
            //      },
            //      /* This is what I added: */
            //      new FontAwesomeLabel
            //      {
            //         Text = "\uf000",
            //         FontSize = 30
            //      }
            //      /**/
            //   }
            //    }
            //};

        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
