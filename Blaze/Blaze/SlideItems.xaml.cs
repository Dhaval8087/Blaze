using SlideOverKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Blaze
{
    public partial class SlideItems : SlideMenuView
    {
        public SlideItems()
        {
            InitializeComponent();
            this.BindingContext = this;
            this.HeightRequest = 250;
            // You must set IsFullScreen in this case, 
            // otherwise you need to set WidthRequest, 
            // just like the QuickInnerMenu sample
            this.IsFullScreen = true;
            this.MenuOrientations = MenuOrientation.BottomToTop;

            // You must set BackgroundColor, 
            // and you cannot put another layout with background color cover the whole View
            // otherwise, it cannot be dragged on Android
            this.BackgroundColor = Color.Black;
            this.BackgroundViewColor = Color.Transparent;

            // In some small screen size devices, the menu cannot be full size layout.
            // In this case we need to set different size for Android.
            if (Device.OS == TargetPlatform.Android)
                HeightRequest += 50;

            var scrollableContent = new StackLayout()
            {
                Orientation = StackOrientation.Horizontal,
                HorizontalOptions = LayoutOptions.Fill,
              };
          
            TapGestureRecognizer ts = new TapGestureRecognizer();
            ts.Tapped += (ea, sa) =>
            {
                var lbl = ea as Label;
                lbl.ScaleTo(1.5);
                lbl.BackgroundColor = Color.FromHex("#c73f3b");

            };
            for (int i = 18; i < 100; i++)
            {
                Button ls = new Button();
                ls.Text = i.ToString();
                ls.HeightRequest = 25;
                ls.WidthRequest = 25;
                ls.BorderColor = Color.Transparent;
                ls.BackgroundColor = Color.Transparent;
                ls.Clicked += (ea, sa) =>
                {
                    var ss = ea as Button;
                    if(ss.Scale >1.1)
                    {
                        ss.Scale = 1;
                    }
                    else
                    {
                        ss.ScaleTo(1.5);
                    }
                   
                    ss.BackgroundColor = Color.FromHex("#c73f3b");
                };
               
                ls.TextColor = Color.White;
                Trigger t = new Trigger(typeof(Label));
                ls.GestureRecognizers.Add(ts);
                scrollableContent.Children.Add(ls);
            }
            scrl.BackgroundColor = Color.FromHex("#ab7676");
            scrl.Content = scrollableContent;



        }
        private List<Labeltxt> _MyDataSource;

        public List<Labeltxt> MyDataSource
        {
            get { return _MyDataSource; }
            set { _MyDataSource = value; }
        }

    }
    public class Labeltxt
    {
        public string LabelText { get; set; }
    }
}
