using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Blaze
{
    public partial class App : Application
    {
        public static int Height, Width = 0;
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new SlideUpMenuPage());
        }
        public static void SetScreenDimensions(int height,int width)
        {
            Height = height;
            Width = width;
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
