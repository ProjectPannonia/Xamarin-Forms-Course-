using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Hello_Xamarin_1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ImagePage : ContentPage
    {
        public ImagePage()
        {
            InitializeComponent();

            //var imageSource = (UriImageSource) ImageSource.FromUri(new Uri("http://..."));

            /*
            var imageSource = new UriImageSource 
            { 
                Uri = new Uri("https://www.gettyimages.pt/gi-resources/images/Homepage/Hero/PT/PT_hero_42_153645159.jpg") 
            };

            imageSource.CachingEnabled = false;
            //imageSource.CacheValidity = TimeSpan.FromHours(1);

            image.Source = imageSource;
            */

            //image.Source = ImageSource.FromResource("Hello_Xamarin_1.Images.Background.jpg");
            btn.ImageSource = ImageSource.FromFile(
                Device.OnPlatform(
                    iOS:"clock.png",
                    Android:"clock.png",
                    WinPhone:"Images/clock.png"
                    ));
        }
    }
}