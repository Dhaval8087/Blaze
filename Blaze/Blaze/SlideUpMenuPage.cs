using SlideOverKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Blaze
{
    public class SlideUpMenuPage: MenuContainerPage
    {
        public SlideUpMenuPage()
        {
            var ctn = new StackLayout();
            var img = new Image();
            img.VerticalOptions = LayoutOptions.Start;
            img.HorizontalOptions = LayoutOptions.Center;
            var windowSize = App.Height/2;
            img.HeightRequest = windowSize;
            img.Source = ImageSource.FromFile("blaze_logo.png");
            ctn.Children.Add(img);


            Content = ctn;


            this.SlideMenu = new SlideItems();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            this.ShowMenu();
        }
    }
}
